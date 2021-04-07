using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralCode.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace GeneralCode.DA
{
    public class GenCodeDA
    {
        public GenCodeDA()
        {

        }
        public List<PropertyTable> GetProperty(string nameTable)
        {
            var sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["ConnectDB"].ToString());
            sqlcon.Open();
            System.Data.SqlClient.SqlCommand SqlCom = new System.Data.SqlClient.SqlCommand();
            SqlCom.Connection = sqlcon;
            SqlCom.CommandType = CommandType.Text;
            var commansql = @"SELECT 
                            c.name 'Column_Name',
                            t.Name 'Data_type',
                            c.max_length 'Max_Length',
                            c.is_nullable,
                            c.precision ,
                            c.scale ,                            
                            ISNULL(i.is_primary_key, 0) 'Primary_Key',
	                        c.is_identity 'Is_Identity',
							isc.CHARACTER_MAXIMUM_LENGTH					
                        FROM
                            sys.columns c
						INNER JOIN
							INFORMATION_SCHEMA.COLUMNS isc on isc.TABLE_NAME='" + nameTable + "' and c.name=isc.COLUMN_NAME";

            commansql = commansql + @" INNER JOIN
                            sys.types t ON c.user_type_id = t.user_type_id
                        LEFT OUTER JOIN
                            sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
                        LEFT OUTER JOIN
                            sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
                        WHERE c.object_id = OBJECT_ID('" + nameTable + "')";
            SqlCom.CommandText = commansql;
            SqlDataReader SqlDR1;
            SqlDR1 = SqlCom.ExecuteReader();
            var objReturn = new List<PropertyTable>();
            while (SqlDR1.Read())
            {
                objReturn.Add(new PropertyTable {
                    Column_Name = SqlDR1.GetString(0),
                    Data_type = SqlDR1.GetString(1),
                    Is_Identity= SqlDR1.GetBoolean(7),
                    is_nullable= SqlDR1.GetBoolean(3),
                    Max_Length= int.Parse(SqlDR1.GetSqlInt16(2).ToString()),
                    //precision= int.Parse(SqlDR1[4].ToString()),
                    //scale = int.Parse(SqlDR1[5].ToString()),
                    CHARACTER_MAXIMUM_LENGTH= int.Parse(SqlDR1.IsDBNull(8)?"0": SqlDR1[8].ToString()),
                    Primary_Key = SqlDR1.GetBoolean(6)                    
                });
            }
            sqlcon.Close();
            return objReturn;
        }
        public List<string> GetListNameTable()
        {
            
            var sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["ConnectDB"].ToString());
            sqlcon.Open();
            System.Data.SqlClient.SqlCommand SqlCom = new System.Data.SqlClient.SqlCommand();
            SqlCom.Connection = sqlcon;
            SqlCom.CommandType = CommandType.Text;
            SqlCom.CommandText = "select * from sys.tables";
            System.Data.SqlClient.SqlDataReader SqlDR;
            SqlDR = SqlCom.ExecuteReader();
            var listObj = new List<string>();
            while (SqlDR.Read())
            {
                listObj.Add(SqlDR.GetString(0));
            }
            sqlcon.Close();
            return listObj;
        }
        public void ExcuteSQL(StringBuilder sbSP)
        {
            try
            {
                var sqlcon = new SqlConnection(ConfigurationSettings.AppSettings["ConnectDB"].ToString());
                sqlcon.Close();
                sqlcon.Open();
                System.Data.SqlClient.SqlCommand SqlCom = new System.Data.SqlClient.SqlCommand();
                SqlCom.Connection = sqlcon;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.CommandText = sbSP.ToString();
                SqlCom.ExecuteNonQuery();
                sqlcon.Close();

            }catch(Exception ex) { }
            
        }
        public void CreateFile(StringBuilder contentFile,string PathFile)
        {
            try
            {
                if (File.Exists(PathFile))
                {
                    File.Delete(PathFile);
                }
                // Create a file model.
                using (StreamWriter sw = File.CreateText(PathFile))
                {
                    sw.Write(contentFile.ToString());
                }
            }
            catch(Exception ex)
            {

            }            
        }
        public void CreateModel(string pathModel, string nameTable, string namespaceModel)
        {
            try
            {
                var listProperty = GetProperty(nameTable);
                StringBuilder sbModel = new StringBuilder();
                sbModel.AppendLine("using System;");
                sbModel.AppendLine("using System.Collections.Generic;");
                sbModel.AppendLine("using System.Linq;");
                sbModel.AppendLine("using System.Text;");
                sbModel.AppendLine("namespace " + namespaceModel);
                sbModel.AppendLine("{");
                sbModel.AppendLine("\tpublic class " + nameTable.Replace("tbl",""));
                sbModel.AppendLine("\t{");
                foreach (var property in listProperty)
                {
                    var strVariable = "\t\tpublic ";

                    if (property.is_nullable == false)
                    {
                        strVariable = strVariable + GetClrType(property.Data_type.ToLower()).ToString();
                    }
                    else
                    {
                        strVariable = strVariable + GetClrType(property.Data_type.ToLower()).ToString() + "?";
                    }

                    strVariable = strVariable + " " + property.Column_Name + " {get; set;}";
                    sbModel.AppendLine(strVariable);
                }
                sbModel.AppendLine("\t}");
                sbModel.AppendLine("}");
                CreateFile(sbModel, pathModel);
            }
            catch(Exception ex)
            {

            }
        }
        public string GetClrType(string sqlType)
        {
            switch (sqlType)
            {
                case "bigint":
                    return "long";

                case "binary":
                case "image":
                case "timestamp":
                case "varbinary":
                    return "byte[]";

                case "bit":
                    return "bool";

                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                case "xml":
                    return "string";

                case "datetime":
                case "smalldatetime":
                case "date":
                case "time":
                case "datetime2":
                    return "DateTime";

                case "decimal":
                case "money":
                case "smallmoney":
                    return "decimal";

                case "float":
                    return "double";

                case "int":
                    return "int";

                case "real":
                    return "float";

                case "uniqueidentifier":
                    return "Guid";

                case "smallint":
                    return "short";

                case "tinyint":
                    return "byte";

                case "variant":
                case "udt":
                    return "object";

                case "structured":
                    return "DataTable";

                case "datetimeoffset":
                    return "DateTimeOffset";

                default:
                    throw new ArgumentOutOfRangeException("sqlType");
            }
        }

        public void DeleteFolder(string yourPath)
        {
            var di = new DirectoryInfo("YourPath");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
