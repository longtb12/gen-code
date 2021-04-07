using System;
using System.Collections;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using GeneralCode.Model;
using GeneralCode.DA;
namespace GeneralCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var listTable = getListTable();
            var objGencode = new GenCodeDA();
            //CreateFunctionSelectDynamicPaping(new StringBuilder(), new StringBuilder(), new StringBuilder(), new StringBuilder(), "tblItems", check);
            //Input for model
            Console.WriteLine("Enter Floder Output");
            var folderRoot = Console.ReadLine();
            if (!Directory.Exists(folderRoot))
            {
                Directory.CreateDirectory(folderRoot);
            }

            Console.WriteLine("Enter namespace Model");
            var namespaceModel = Console.ReadLine();
            var folderModel = folderRoot + "\\Model";
            if (!Directory.Exists(folderModel))
            {
                Directory.CreateDirectory(folderModel);
            }

            Console.WriteLine("Enter namespace Base Model");
            var namespaceBaseModel = Console.ReadLine();


            ////Input for DA
            //Console.WriteLine("Enter namespace Interface DA");
            //var namespaceInterfaceDA = Console.ReadLine();
            




            ////Console.WriteLine("Enter path folder interface DA");
            //var folderInterfaceDA = folderRoot+"\\DA\\Interface";
            //if (!Directory.Exists(folderInterfaceDA))
            //{
            //    Directory.CreateDirectory(folderInterfaceDA);
            //}


            //Console.WriteLine("Enter namespace implement DA");




           // var namespaceImplementDA = Console.ReadLine();
           // //Console.WriteLine("Enter path folder implement DA");
           // var folderImplementDA = folderRoot + "\\DA\\Implement";
           // if (!Directory.Exists(folderImplementDA))
           // {
           //     Directory.CreateDirectory(folderImplementDA);
           // }

           // //Input for Business
           // Console.WriteLine("Enter namespace for interface Business");
           // var namespaceInterfaceBusiness = Console.ReadLine();
           // //Console.WriteLine("Enter path folder interface Business");
           // var folderInterfaceBusiness = folderRoot + "\\Business\\Interface";
           // if (!Directory.Exists(folderInterfaceBusiness))
           // {
           //     Directory.CreateDirectory(folderInterfaceBusiness);
           // }


           // Console.WriteLine("Enter namespace for implement Business");
           // var namespaceImplementBusiness = Console.ReadLine();
           // //Console.WriteLine("Enter path folder interface Business");
           // var folderImplementBusiness = folderRoot + "\\Business\\Implement";
           // if (!Directory.Exists(folderImplementBusiness))
           // {
           //     Directory.CreateDirectory(folderImplementBusiness);
           // }


           // //Input for Common Repositories
           // Console.WriteLine("Enter namespage for interface Repositories");
           // var namespaceRepositories = Console.ReadLine();
           // //Finish gencode           
           //// var listTable = getListTable();//new List<string>();
           // //listTable.Add("tblComapanys");
           // //listTable.Add("tblCompanyLanguages");
           // //listTable.Add("tblItemLanguages");
           // //listTable.Add("tblLanguage");
            foreach (var item in listTable)
            {
                var check = objGencode.GetProperty(item);
                string pathModel = @"" + folderModel + "\\" + item + ".cs";
                //string pathInterfaceDA =@""+folderInterfaceDA+ "\\I" + item + "DataAccess.cs";
                //string pathImplementDA = @"" + folderImplementDA + "\\" + item + "DataAccess.cs";
                //string pathInterfaceBs = @"" + folderInterfaceBusiness + "\\I" + item + "Service.cs";
                //string pathImplementBs = @"" + folderImplementBusiness + "\\" + item + "Service.cs";
                objGencode.CreateModel(pathModel, item, namespaceModel);
                ////Interface for DA
                //var strbuildInterfaceDA = new StringBuilder();
                //var strbuildImplementDA= new StringBuilder();
                //var strbuildInterfaceBS = new StringBuilder();
                //var strbuildImplementBS = new StringBuilder();

                ////Begin All file
                ////01 Interface DA
                //strbuildInterfaceDA.AppendLine("using System.Collections.Generic;");
                //strbuildInterfaceDA.AppendLine("using " + namespaceModel + ";");
                //strbuildInterfaceDA.AppendLine("using " + namespaceBaseModel + ";");
                //strbuildInterfaceDA.AppendLine("namespace " + namespaceInterfaceDA);
                //strbuildInterfaceDA.AppendLine("{");
                //strbuildInterfaceDA.AppendLine("public " + "interface I"+ item + "DataAccess");
                //strbuildInterfaceDA.AppendLine("{");
                ////02 Implement DA
                //strbuildImplementDA.AppendLine("using System;");
                //strbuildImplementDA.AppendLine("using System.Collections.Generic; ");
                //strbuildImplementDA.AppendLine("using " + namespaceModel + ";");
                //strbuildImplementDA.AppendLine("using " + namespaceBaseModel + ";");
                //strbuildImplementDA.AppendLine("using " + namespaceInterfaceDA + ";");
                //strbuildImplementDA.AppendLine("using " + namespaceRepositories + ";");
                //strbuildImplementDA.AppendLine("namespace "+namespaceImplementDA);
                //strbuildImplementDA.AppendLine("{");
                //strbuildImplementDA.AppendLine("public class "+ item + "DataAccess : I" + item + "DataAccess");
                //strbuildImplementDA.AppendLine("{");
                //strbuildImplementDA.AppendLine("private readonly ICommonRepository _commonRepository;");
                //strbuildImplementDA.AppendLine("public "+ item + "DataAccess(ICommonRepository commonRepository)");
                //strbuildImplementDA.AppendLine("{");
                //strbuildImplementDA.AppendLine("_commonRepository = commonRepository;");
                //strbuildImplementDA.AppendLine("}");
                ////03 Interface Bussness
                //strbuildInterfaceBS.AppendLine("using System.Collections.Generic;");
                //strbuildInterfaceBS.AppendLine("using " + namespaceModel + ";");
                //strbuildInterfaceBS.AppendLine("using " + namespaceBaseModel + ";");
                //strbuildInterfaceBS.AppendLine("namespace " + namespaceInterfaceBusiness);
                //strbuildInterfaceBS.AppendLine("{");
                //strbuildInterfaceBS.AppendLine("public " + "interface I" + item + "Service");
                //strbuildInterfaceBS.AppendLine("{");
                ////04 Implement Business
                //strbuildImplementBS.AppendLine("using System;");
                //strbuildImplementBS.AppendLine("using System.Collections.Generic; ");
                //strbuildImplementBS.AppendLine("using " + namespaceModel + ";");
                //strbuildImplementBS.AppendLine("using " + namespaceBaseModel + ";");
                //strbuildImplementBS.AppendLine("using " + namespaceImplementDA + ";");
                //strbuildImplementBS.AppendLine("using " + namespaceInterfaceBusiness + ";");
                //strbuildImplementBS.AppendLine("namespace " + namespaceImplementBusiness);
                //strbuildImplementBS.AppendLine("{");
                //strbuildImplementBS.AppendLine("public class " + item+ "Service : I" + item + "Service");
                //strbuildImplementBS.AppendLine("{");
                //strbuildImplementBS.AppendLine("private readonly I"+ item + "DataAccess _" + item + "DataAccess;");
                //strbuildImplementBS.AppendLine("public "+ item + "Service(I"+ item + "DataAccess " + item + "DataAccess)");
                //strbuildImplementBS.AppendLine("{");
                //strbuildImplementBS.AppendLine("_"+ item + "DataAccess = " + item + "DataAccess;");
                //strbuildImplementBS.AppendLine("}");

                //CreateFunctionGetAllObject(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                //CreateFunctionGetObjectByKey(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                //CreateFunctionCreateObject(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                //CreateFunctionUpdateObjectByKey(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                //CreateFunctionUpdateObjectByKey2(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                //CreateFunctionSelectDynamic(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                //CreateFunctionSelectDynamicPaping(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                //DeleteByKey(strbuildImplementDA, strbuildInterfaceDA, strbuildImplementBS,
                //    strbuildInterfaceBS, item, check);
                ////End content all file
                //strbuildImplementBS.AppendLine("}");
                //strbuildInterfaceBS.AppendLine("}");
                //strbuildImplementDA.AppendLine("}");
                //strbuildInterfaceDA.AppendLine("}");
                //strbuildImplementBS.AppendLine("}");
                //strbuildInterfaceBS.AppendLine("}");
                //strbuildImplementDA.AppendLine("}");
                //strbuildInterfaceDA.AppendLine("}");
                ////create file
                //objGencode.CreateFile(strbuildImplementDA,pathImplementDA);
                //objGencode.CreateFile(strbuildInterfaceDA, pathInterfaceDA);
                //objGencode.CreateFile(strbuildImplementBS, pathImplementBs);
                //objGencode.CreateFile(strbuildInterfaceBS, pathInterfaceBs);

            }
            Console.ReadLine();

        }
        
        public static List<string> getListTable()
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
        public static string GetClrType(string sqlType)
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
        public static void GetAllColumnFromTableForSelect(List<PropertyTable> listProperty, StringBuilder sbSP)
        {            
            var i = 1;
            foreach(var item in listProperty)
            {
                sbSP.AppendLine("["+item.Column_Name+"]" + (i == listProperty.Count ? "" : ","));
                i = i + 1;
            }
        }
        public static void GetAllColumnForInsert(List<PropertyTable> listProperty, StringBuilder sbSP)
        {
            var i = 1;
            foreach (var item in listProperty.Where(c => c.Is_Identity == false).ToList())
            {
                var paraColumn = "@" + item.Column_Name + " AS " + item.Data_type.ToUpper() + (item.Data_type == "ntext" || item.Data_type == "text" || item.CHARACTER_MAXIMUM_LENGTH==0 ? "" : (item.CHARACTER_MAXIMUM_LENGTH == -1 ? "(MAX)" : "(" + item.CHARACTER_MAXIMUM_LENGTH + ")"));
                paraColumn = paraColumn + (item.is_nullable == false ? "" : " = NULL") + (i == listProperty.Where(c => c.Is_Identity == false).ToList().Count ? "" : ",");
                sbSP.AppendLine(paraColumn);
                i = i + 1;
            }
        }
        public static void GetAllColumnForUpdate(List<PropertyTable> listProperty, StringBuilder sbSP)
        {
            var i = 1;
            foreach (var item in listProperty.Where(c => c.Is_Identity == false || c.Primary_Key==true).ToList())
            {
                var paraColumn = "@" + item.Column_Name + " AS " + item.Data_type.ToUpper() + (item.Data_type == "ntext" || item.Data_type == "text" || item.CHARACTER_MAXIMUM_LENGTH == 0 ? "" : (item.CHARACTER_MAXIMUM_LENGTH == -1 ? "(MAX)" : "(" + item.CHARACTER_MAXIMUM_LENGTH + ")"));
                paraColumn = paraColumn + (item.is_nullable == false ? "" : " = NULL") + (i == listProperty.Where(c => c.Is_Identity == false || c.Primary_Key == true).ToList().Count ? "" : ",");
                sbSP.AppendLine(paraColumn);
                i = i + 1;
            }
        }
        public static void CreateFunctionGetAllObject(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS, string nameTable, List<PropertyTable> listProperty)
        {
            //Create Store
            var NameStore = nameTable + "_SelectAll";
            StringBuilder sbSP = new StringBuilder();
            sbSP.AppendLine("CREATE PROCEDURE "+ NameStore);            
            sbSP.AppendLine("AS");
            sbSP.AppendLine("BEGIN");
            sbSP.AppendLine("SELECT");
            GetAllColumnFromTableForSelect(listProperty, sbSP);
            sbSP.AppendLine("FROM ["+nameTable+"]");
            sbSP.AppendLine("END");
            new GenCodeDA().ExcuteSQL(sbSP);
            //Finish Create Store
            //nameTable = nameTable.Replace("tbl", "");
            //Create for interface DA
            sbIDA.AppendLine("List<" + nameTable + "> SelectAll();");
            //Create For implement DA
            sbDA.AppendLine("public List<"+ nameTable+"> SelectAll()");
            sbDA.AppendLine("{");
            sbDA.AppendLine("\ttry");
                sbDA.AppendLine("\t\t{");
                    sbDA.AppendLine("\t\t\treturn _commonRepository.GetListByStoredProcedure<" + nameTable+">(\""+ NameStore + "\");");
                sbDA.AppendLine("\t\t}");
            sbDA.AppendLine("\tcatch (Exception ex)");
                sbDA.AppendLine("\t\t{");
            sbDA.AppendLine("\t\t\tthrow new Exception(ex.ToString());");
            sbDA.AppendLine("\t\t}");
            sbDA.AppendLine("}");
            
            //Create For business 
            //Create for interface business
            sbIBS.AppendLine("\tList<" + nameTable + "> SelectAll();");
            //Implement for business
            sbBS.AppendLine("public List<"+nameTable+"> SelectAll()");
            sbBS.AppendLine("{");
                sbBS.AppendLine("\treturn _"+ nameTable + "DataAccess.SelectAll();");
            sbBS.AppendLine("}");

        }
        public static void CreateFunctionGetObjectByKey(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS, string nameTable, List<PropertyTable> listProperty)
        {
            if (listProperty.Exists(c => c.Primary_Key == true))
            {
                var listPropertyPriKey = listProperty.Where(c => c.Primary_Key == true).ToList();
                //Create Store
                var NameStore = nameTable + "_SelectByKey";
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE " + NameStore);
                var i = 1;
                var strParamFunction = "";
                var strDK = "";
                var strParamPasss = "";
                foreach (var item in listPropertyPriKey)
                {
                    var paraColumn = "@" + item.Column_Name + " AS " + item.Data_type.ToUpper() +
                                     (item.Data_type == "ntext" || item.Data_type == "text" ||
                                      item.CHARACTER_MAXIMUM_LENGTH == 0
                                         ? ""
                                         : (item.CHARACTER_MAXIMUM_LENGTH == -1
                                             ? "(MAX)"
                                             : "(" + item.CHARACTER_MAXIMUM_LENGTH + ")"));
                    paraColumn = paraColumn + (item.is_nullable == false ? "" : " = NULL") +
                                 (i == listPropertyPriKey.Count ? "" : ",");
                    sbSP.AppendLine(paraColumn);
                    strParamFunction = strParamFunction + item.Data_type + " " + item.Column_Name +
                                       (i == listPropertyPriKey.Count ? "" : ", ");
                    strDK = strDK + item.Column_Name + "=@" + item.Column_Name +
                            (i == listPropertyPriKey.Count ? "" : " and ");
                    strParamPasss= strParamPasss+ item.Column_Name +
                                       (i == listPropertyPriKey.Count ? "" : ", ");
                    i = i + 1;
                }
                sbSP.AppendLine("AS");
                sbSP.AppendLine("BEGIN");
                sbSP.AppendLine("SELECT");
                GetAllColumnFromTableForSelect(listProperty, sbSP);
                sbSP.AppendLine("FROM [" + nameTable + "]");
                sbSP.AppendLine("WHERE " + strDK);
                sbSP.AppendLine("END");
                new GenCodeDA().ExcuteSQL(sbSP);
                //nameTable = nameTable.Replace("tbl", "");
                //Finish Create Store
                //Create for interface DA
                sbIDA.AppendLine(nameTable + " SelectByKey(" + strParamFunction + ");");
                //Create For implement DA
                sbDA.AppendLine("public " + nameTable + " SelectByKey(" + strParamFunction + ")");
                sbDA.AppendLine("{");
                sbDA.AppendLine("\ttry");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("\t\t\tvar arg = new[]");
                sbDA.AppendLine("\t\t\t{");
                var j = 1;
                foreach (var item in listPropertyPriKey)
                {
                    sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"" + item.Column_Name + "\", " +
                                    item.Column_Name + ")" + (j == listPropertyPriKey.Count ? "" : ","));
                    j = j + 1;
                }
                sbDA.AppendLine("\t\t\t};");
                sbDA.AppendLine("\t\t\treturn _commonRepository.GetObjectByStoredProcedure<" + nameTable + ">(\"" +
                                NameStore + "\",arg);");
                sbDA.AppendLine("\t\t}");
                sbDA.AppendLine("\tcatch (Exception ex)");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("\t\t\tthrow new Exception(ex.ToString());");
                sbDA.AppendLine("\t\t}");
                sbDA.AppendLine("}");
                //Create For business 
                //Create for interface business
                sbIBS.AppendLine("\t" + nameTable + " SelectByKey(" + strParamFunction + ");");
                //Implement for business
                sbBS.AppendLine("public " + nameTable + " SelectByKey(" + strParamFunction + ")");
                sbBS.AppendLine("{");
                
                
                sbBS.AppendLine("\treturn _" + nameTable + "DataAccess.SelectByKey("+ strParamPasss + ");");
                sbBS.AppendLine("}");
            }
        }
        public static void CreateFunctionCreateObject(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS, string nameTable, List<PropertyTable> listProperty)
        {
            try
            {
                var listPropertynotIdentity = listProperty.Where(c => c.Is_Identity == false).ToList();
                //Create store
                var NameStore = nameTable + "_Insert";
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE " + NameStore);
                GetAllColumnForInsert(listProperty, sbSP);
                
                sbSP.AppendLine("AS");
                sbSP.AppendLine("BEGIN");
                sbSP.AppendLine("INSERT INTO ["+nameTable+"](");

                var i = 1;
                foreach (var item in listPropertynotIdentity)
                {
                    var paraColumn = "["+item.Column_Name+"]";
                    paraColumn = paraColumn + (i == listPropertynotIdentity.Count ? "" : ",");
                    sbSP.AppendLine(paraColumn);
                    i = i + 1;
                }

                sbSP.AppendLine(")");
                sbSP.AppendLine("VALUES( ");
                var k = 1;
                foreach (var item in listPropertynotIdentity)
                {
                    var paraColumn = "@" + item.Column_Name;
                    paraColumn = paraColumn + (k == listPropertynotIdentity.Count ? "" : ",");
                    sbSP.AppendLine(paraColumn);                    
                    k = k + 1;
                }
                sbSP.AppendLine(")");
                sbSP.AppendLine("END");
                new GenCodeDA().ExcuteSQL(sbSP);

                //nameTable = nameTable.Replace("tbl", "");
                //Create for interface DA
                sbIDA.AppendLine("BaseResponse Create_" + nameTable + "(" + nameTable + " obj" + nameTable + ");");
                //Create For implement DA
                sbDA.AppendLine("public BaseResponse Create_" + nameTable + "(" + nameTable + " obj" + nameTable + ")");
                sbDA.AppendLine("{");
                sbDA.AppendLine("var objReturn=new BaseResponse();");
                sbDA.AppendLine("try");
                sbDA.AppendLine("{");
                //Add pram and call reponsitive                
                sbDA.AppendLine("var arg = new[]");
                sbDA.AppendLine("{");
                var j = 1;
                foreach(var item in listPropertynotIdentity)
                {
                    sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"" + item.Column_Name + "\", " + "obj" + nameTable + "." + item.Column_Name + ")" + (j == listPropertynotIdentity.Count ? "" : ","));
                    j = j + 1;
                }
                sbDA.AppendLine("};");
                var listPropertyPrimaryKeyIdentity = listProperty.Where(c => c.Primary_Key == true && c.Is_Identity == true).ToList();
                if (listPropertyPrimaryKeyIdentity != null && listPropertyPrimaryKeyIdentity.Count == 1)
                {
                    sbDA.AppendLine("objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue(\""+NameStore+"\",\""+listPropertyPrimaryKeyIdentity.FirstOrDefault().Column_Name+"\",arg);");
                }
                else
                {
                    sbDA.AppendLine("objReturn.Success =_commonRepository.ExecuteStoredProcedure(\"" + NameStore + "\",arg);");
                }
                sbDA.AppendLine("}");
                sbDA.AppendLine("catch (Exception ex)");
                sbDA.AppendLine("{");
                sbDA.AppendLine("objReturn.Success=false;");
                sbDA.AppendLine("objReturn.Message=ex.ToString();");
                sbDA.AppendLine("}");
                sbDA.AppendLine("return objReturn;");
                sbDA.AppendLine("}");
                //Create For business 
                //Create for interface business
                sbIBS.AppendLine("BaseResponse Create_" + nameTable + "(" + nameTable + " obj" + nameTable + ");");
                //Implement for business
                sbBS.AppendLine("public BaseResponse Create_"+nameTable+ "(" + nameTable + " obj" + nameTable + ")");
                sbBS.AppendLine("{");
                sbBS.AppendLine("\treturn _" + nameTable + "DataAccess.Create_"+nameTable+"(obj" + nameTable + ");");
                sbBS.AppendLine("}");
            }
            catch (Exception ex) {
            }
        }
        public static void CreateFunctionUpdateObjectByKey(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS, string nameTable, List<PropertyTable> listProperty)
        {
            try
            {
                var listPropertynotIdentity = listProperty.Where(c => c.Is_Identity == false || c.Primary_Key==false).ToList();
                //Create store
                var NameStore = nameTable + "_Update";
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE " + NameStore);
                GetAllColumnForUpdate(listProperty, sbSP);

                sbSP.AppendLine("AS");
                sbSP.AppendLine("BEGIN");
                sbSP.AppendLine("UPDATE [" + nameTable + "] SET");

                var i = 1;
                foreach (var item in listPropertynotIdentity)
                {
                    var paraColumn = "["+item.Column_Name +"]=@"+item.Column_Name;
                    paraColumn = paraColumn + (i == listPropertynotIdentity.Count ? "" : ",");
                    sbSP.AppendLine(paraColumn);
                    i = i + 1;
                }
                
                sbSP.AppendLine("WHERE ");
                var k = 1;
                foreach (var item in listProperty.Where(c=>c.Primary_Key==true).ToList())
                {
                    var paraColumn = "["+item.Column_Name+"]=@" + item.Column_Name;
                    paraColumn = paraColumn + (k == listProperty.Where(c => c.Primary_Key == true).ToList().Count ? "" : " AND");
                    sbSP.AppendLine(paraColumn);
                    k = k + 1;
                }
                sbSP.AppendLine("");
                sbSP.AppendLine("END");
                new GenCodeDA().ExcuteSQL(sbSP);
                //nameTable = nameTable.Replace("tbl", "");
                //Create for interface DA
                sbIDA.AppendLine("BaseResponse Update_" + nameTable + "(" + nameTable + " obj" + nameTable + ");");
                //Create For implement DA
                sbDA.AppendLine("public BaseResponse Update_" + nameTable + "(" + nameTable + " obj" + nameTable + ")");
                sbDA.AppendLine("{");
                sbDA.AppendLine("var objReturn=new BaseResponse();");
                sbDA.AppendLine("try");
                sbDA.AppendLine("{");
                //Add pram and call reponsitive                
                sbDA.AppendLine("var arg = new[]");
                sbDA.AppendLine("{");
                var j = 1;
                foreach (var item in listProperty)
                {
                    sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"" + item.Column_Name + "\", " + "obj"+ nameTable +"."+ item.Column_Name + ")" + (j == listProperty.Count ? "" : ","));
                    j = j + 1;
                }
                sbDA.AppendLine("};");                
                sbDA.AppendLine("objReturn.Success =_commonRepository.ExcuteStore(\"" + NameStore + "\",arg);");
                sbDA.AppendLine("}");
                sbDA.AppendLine("catch (Exception ex)");
                sbDA.AppendLine("{");
                sbDA.AppendLine("objReturn.Success=false;");
                sbDA.AppendLine("objReturn.Message=ex.ToString();");
                sbDA.AppendLine("}");
                sbDA.AppendLine("return objReturn;");
                sbDA.AppendLine("}");
                //Create For business 
                //Create for interface business
                sbIBS.AppendLine("BaseResponse Update_" + nameTable + "(" + nameTable + " obj" + nameTable + ");");
                //Implement for business
                sbBS.AppendLine("public BaseResponse Update_" + nameTable + "(" + nameTable + " obj" + nameTable + ")");
                sbBS.AppendLine("{");
                sbBS.AppendLine("\treturn _" + nameTable + "DataAccess.Update_" + nameTable + "(obj" + nameTable + ");");
                sbBS.AppendLine("}");
            }
            catch(Exception ex)
            {

            }
        }
        public static void CreateFunctionUpdateObjectByKey2(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS, string nameTable, List<PropertyTable> listProperty)
        {
            try
            {
                var listPropertynotIdentity = listProperty.Where(c => c.Is_Identity == false || c.Primary_Key == false).ToList();
                //Create store
                var NameStore = nameTable + "_Update2";
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE " + NameStore);
                GetAllColumnForUpdate(listProperty, sbSP);

                sbSP.AppendLine("AS");
                sbSP.AppendLine("BEGIN");                
                foreach(var item in listProperty.Where(c => c.Primary_Key == false).ToList())
                {
                    sbSP.AppendLine("DECLARE @" + item.Column_Name + "_Old AS " + item.Data_type.ToUpper()+ (item.Data_type == "ntext" || item.Data_type == "text" || item.CHARACTER_MAXIMUM_LENGTH == 0 ? "" : (item.CHARACTER_MAXIMUM_LENGTH == -1 ? "(MAX)" : "(" + item.CHARACTER_MAXIMUM_LENGTH + ")")));
                }
                sbSP.AppendLine("SELECT");
                var z = 1;
                foreach (var item in listProperty.Where(c => c.Primary_Key == false).ToList())
                {
                    sbSP.AppendLine("@" + item.Column_Name + "_Old=["+item.Column_Name+"]"+(listProperty.Where(c => c.Primary_Key == false).ToList().Count==z?"":","));
                    z = z + 1;
                }
                sbSP.AppendLine("FROM ["+nameTable+"]");

                sbSP.AppendLine("WHERE");
                var n = 1;
                foreach(var item in listProperty.Where(c => c.Primary_Key == true).ToList())
                {
                    sbSP.AppendLine("["+item.Column_Name + "]=@" + item.Column_Name + (listProperty.Where(c => c.Primary_Key == true).ToList().Count == n ? "" : " AND "));
                    n = n + 1;
                }

                sbSP.AppendLine("UPDATE [" + nameTable + "] SET");
                var i = 1;
                foreach (var item in listPropertynotIdentity)
                {
                    var paraColumn = "["+item.Column_Name + "]=ISNULL(@" + item.Column_Name+",@"+ item.Column_Name+"_Old)";
                    paraColumn = paraColumn + (i == listPropertynotIdentity.Count ? "" : ",");
                    sbSP.AppendLine(paraColumn);
                    i = i + 1;
                }

                sbSP.AppendLine("WHERE ");
                var k = 1;
                foreach (var item in listProperty.Where(c => c.Primary_Key == true).ToList())
                {
                    var paraColumn = "["+item.Column_Name + "]=@" + item.Column_Name;
                    paraColumn = paraColumn + (k == listProperty.Where(c => c.Primary_Key == true).ToList().Count ? "" : " AND");
                    sbSP.AppendLine(paraColumn);
                    k = k + 1;
                }
                sbSP.AppendLine("");
                sbSP.AppendLine("END");
                new GenCodeDA().ExcuteSQL(sbSP);
                //nameTable = nameTable.Replace("tbl", "");
                //Create for interface DA
                sbIDA.AppendLine("BaseResponse Update_" + nameTable + "2(" + nameTable + " obj" + nameTable + ");");
                //Create For implement DA
                sbDA.AppendLine("public BaseResponse Update_" + nameTable + "2(" + nameTable + " obj" + nameTable + ")");
                sbDA.AppendLine("{");
                sbDA.AppendLine("var objReturn=new BaseResponse();");
                sbDA.AppendLine("try");
                sbDA.AppendLine("{");
                //Add pram and call reponsitive                
                sbDA.AppendLine("var arg = new[]");
                sbDA.AppendLine("{");
                var j = 1;
                foreach (var item in listProperty)
                {
                    sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"" + item.Column_Name + "\", " + "obj" + nameTable + "." + item.Column_Name + ")" + (j == listProperty.Count ? "" : ","));
                    j = j + 1;
                }
                sbDA.AppendLine("};");
                sbDA.AppendLine("objReturn.Success =_commonRepository.ExcuteStore(\"" + NameStore + "\",arg);");
                sbDA.AppendLine("}");
                sbDA.AppendLine("catch (Exception ex)");
                sbDA.AppendLine("{");
                sbDA.AppendLine("objReturn.Success=false;");
                sbDA.AppendLine("objReturn.Message=ex.ToString();");
                sbDA.AppendLine("}");
                sbDA.AppendLine("return objReturn;");
                sbDA.AppendLine("}");
                //Create For business 
                //Create for interface business
                sbIBS.AppendLine("BaseResponse Update_" + nameTable + "2(" + nameTable + " obj" + nameTable + ");");
                //Implement for business
                sbBS.AppendLine("public BaseResponse Update_" + nameTable + "2(" + nameTable + " obj" + nameTable + ")");
                sbBS.AppendLine("{");
                sbBS.AppendLine("\treturn _" + nameTable + "DataAccess.Update_" + nameTable + "2(obj" + nameTable + ");");
                sbBS.AppendLine("}");
            }
            catch (Exception ex)
            {

            }
        }
        public static void CreateFunctionSelectDynamic(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS, string nameTable, List<PropertyTable> listProperty)
        {
            try
            {
                //Create Store
                var NameStore = nameTable + "_SelectDynamic";
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE " + NameStore);
                sbSP.AppendLine("@WhereCondition nvarchar(500),");
                sbSP.AppendLine("@OrderByExpression nvarchar(250) = NULL");
                sbSP.AppendLine("AS");
                sbSP.AppendLine("BEGIN");
                sbSP.AppendLine("DECLARE @SQL nvarchar(3250)");
                sbSP.AppendLine("SET @SQL = '");
                sbSP.AppendLine("SELECT");
                GetAllColumnFromTableForSelect(listProperty, sbSP);
                sbSP.AppendLine("FROM [" + nameTable + "]");
                sbSP.AppendLine("WHERE ' + @WhereCondition");
                sbSP.AppendLine("IF @OrderByExpression IS NOT NULL AND LEN(@OrderByExpression) > 0");
                sbSP.AppendLine("BEGIN");
                sbSP.AppendLine("SET @SQL = @SQL + '");
                sbSP.AppendLine("ORDER BY");
                sbSP.AppendLine("' + @OrderByExpression");
                sbSP.AppendLine("END");
                sbSP.AppendLine("EXEC sp_executesql @SQL");
                sbSP.AppendLine("END");
                new GenCodeDA().ExcuteSQL(sbSP);
                //nameTable = nameTable.Replace("tbl", "");
                //Finish Create Store
                //Create for interface DA
                sbIDA.AppendLine("List<"+nameTable + "> SelectDynamic(string WhereCondition, string OrderByExpression);");
                //Create For implement DA
                sbDA.AppendLine("public List<" + nameTable + "> SelectDynamic(string WhereCondition, string OrderByExpression)");
                sbDA.AppendLine("{");
                sbDA.AppendLine("\ttry");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("\t\t\tvar arg = new[]");
                sbDA.AppendLine("\t\t\t{");
                sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"WhereCondition\", WhereCondition ),");
                sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"OrderByExpression\", OrderByExpression )");
                sbDA.AppendLine("\t\t\t};");
                sbDA.AppendLine("\t\t\treturn _commonRepository.GetListByStoredProcedure<" + nameTable + ">(\"" + NameStore + "\",arg);");
                sbDA.AppendLine("\t\t}");
                sbDA.AppendLine("\tcatch (Exception ex)");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("\t\t\tthrow new Exception(ex.ToString());");
                sbDA.AppendLine("\t\t}");
                sbDA.AppendLine("}");
                //Create For business 
                //Create for interface business
                sbIBS.AppendLine("\tList<" + nameTable + "> SelectDynamic(string WhereCondition, string OrderByExpression);");
                //Implement for business
                sbBS.AppendLine("public List<" + nameTable + "> SelectDynamic(string WhereCondition, string OrderByExpression)");
                sbBS.AppendLine("{");
                sbBS.AppendLine("\treturn _" + nameTable + "DataAccess.SelectDynamic(WhereCondition, OrderByExpression);");
                sbBS.AppendLine("}");
            }
            catch(Exception ex) { }
        }
        public static void CreateFunctionSelectDynamicPaping(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS, string nameTable, List<PropertyTable> listProperty)
        {
            try
            {
                //Create Store
                var NameStore = nameTable + "_SelectDynamicPaping";
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE " + NameStore);
                sbSP.AppendLine("@PageIndex INT,");
                sbSP.AppendLine("@PageSize INT,");
                sbSP.AppendLine("@WhereCondition NVARCHAR(500),");
                sbSP.AppendLine("@OrderByExpression NVARCHAR(250) = NULL");
                sbSP.AppendLine("AS");
                sbSP.AppendLine("BEGIN");
                sbSP.AppendLine("DECLARE @SQL NVARCHAR(3250)");
                sbSP.AppendLine("SET @SQL = '");
                sbSP.AppendLine("DECLARE @TotalRecord INT");
                sbSP.AppendLine("SELECT @TotalRecord=COUNT(*) FROM [" + nameTable + "] WHERE '+@WhereCondition");
                sbSP.AppendLine("+'SELECT");
                sbSP.AppendLine("Rownumber,");
                sbSP.AppendLine("TotalRecord,");
                GetAllColumnFromTableForSelect(listProperty, sbSP);
                sbSP.AppendLine("FROM (SELECT ROW_NUMBER() OVER(ORDER BY '+@OrderByExpression+') AS Rownumber, @TotalRecord AS TotalRecord,");
                GetAllColumnFromTableForSelect(listProperty, sbSP);
                sbSP.AppendLine("FROM [" + nameTable+ "] WHERE '+@WhereCondition");
                sbSP.AppendLine("+') AS somex WHERE Rownumber >= (@PageIndex-1)*@PageSize AND Rownumber <=@PageIndex*@PageSize'");
                sbSP.AppendLine("EXEC sp_executesql @SQL, N'@PageSize int, @PageIndex int',@PageSize, @PageIndex");
                sbSP.AppendLine("END");
                new GenCodeDA().ExcuteSQL(sbSP);
                //nameTable = nameTable.Replace("tbl", "");
                //Finish Create Store
                //Create for interface DA
                sbIDA.AppendLine("List<" + nameTable + "> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);");
                //Create For implement DA
                sbDA.AppendLine("public List<" + nameTable + "> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)");
                sbDA.AppendLine("{");
                sbDA.AppendLine("\ttry");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("\t\t\tvar arg = new[]");
                sbDA.AppendLine("\t\t\t{");
                sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"PageIndex\", PageIndex ),");
                sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"PageSize\", PageSize ),");
                sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"WhereCondition\", WhereCondition ),");
                sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"OrderByExpression\", OrderByExpression )");
                sbDA.AppendLine("\t\t\t};");
                sbDA.AppendLine("\t\t\treturn _commonRepository.GetListByStoredProcedure<" + nameTable + ">(\"" + NameStore + "\",arg);");
                sbDA.AppendLine("\t\t}");
                sbDA.AppendLine("\tcatch (Exception ex)");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("\t\t\tthrow new Exception(ex.ToString());");
                sbDA.AppendLine("\t\t}");
                sbDA.AppendLine("}");
                //Create For business 
                //Create for interface business
                sbIBS.AppendLine("\tList<" + nameTable + "> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);");
                //Implement for business
                sbBS.AppendLine("public List<" + nameTable + "> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)");
                sbBS.AppendLine("{");
                sbBS.AppendLine("\treturn _" + nameTable + "DataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);");
                sbBS.AppendLine("}");
            }
            catch (Exception ex) { }
        }

        public static void DeleteByKey(StringBuilder sbDA, StringBuilder sbIDA, StringBuilder sbBS, StringBuilder sbIBS,
            string nameTable, List<PropertyTable> listProperty)
        {
            try
            {
                var listPropertyPriKey = listProperty.Where(c => c.Primary_Key == true).ToList();
                var NameStore = nameTable + "_DeleteByKey";
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("CREATE PROCEDURE " + NameStore);
                var i = 1;
                var strParamFunction = "";
                var strDK = "";
                var strParamPasss = "";
                foreach (var item in listPropertyPriKey)
                {
                    var paraColumn = "@" + item.Column_Name + " AS " + item.Data_type.ToUpper() +
                                     (item.Data_type == "ntext" || item.Data_type == "text" ||
                                      item.CHARACTER_MAXIMUM_LENGTH == 0
                                         ? ""
                                         : (item.CHARACTER_MAXIMUM_LENGTH == -1
                                             ? "(MAX)"
                                             : "(" + item.CHARACTER_MAXIMUM_LENGTH + ")"));
                    paraColumn = paraColumn + (item.is_nullable == false ? "" : " = NULL") +
                                 (i == listPropertyPriKey.Count ? "" : ",");
                    sbSP.AppendLine(paraColumn);
                    strParamFunction = strParamFunction + item.Data_type + " " + item.Column_Name +
                                       (i == listPropertyPriKey.Count ? "" : ", ");
                    strDK = strDK + item.Column_Name + "=@" + item.Column_Name +
                            (i == listPropertyPriKey.Count ? "" : " and ");
                    strParamPasss = strParamPasss + item.Column_Name +
                                       (i == listPropertyPriKey.Count ? "" : ", ");
                    i = i + 1;
                }
                sbSP.AppendLine("AS");
                sbSP.AppendLine("BEGIN");
                sbSP.AppendLine("DELETE FROM "+nameTable +" WHERE " + strDK);
                sbSP.AppendLine("END");
                new GenCodeDA().ExcuteSQL(sbSP);
                //nameTable = nameTable.Replace("tbl", "");
                //Finish Create Store
                //Create for interface DA
                sbIDA.AppendLine("BaseResponse DeleteByKey(" + strParamFunction + ");");
                //Create For implement DA
                sbDA.AppendLine("public BaseResponse DeleteByKey(" + strParamFunction + ")");
                sbDA.AppendLine("{");
                sbDA.AppendLine("var objReturn=new BaseResponse();");

                sbDA.AppendLine("\ttry");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("\t\t\tvar arg = new[]");
                sbDA.AppendLine("\t\t\t{");
                var j = 1;
                foreach (var item in listPropertyPriKey)
                {
                    sbDA.AppendLine("\t\t\tnew KeyValuePair<string, object>(\"" + item.Column_Name + "\", " +
                                    item.Column_Name + ")" + (j == listPropertyPriKey.Count ? "" : ","));
                    j = j + 1;
                }
                sbDA.AppendLine("\t\t\t};");
                sbDA.AppendLine("\t\t\t objReturn= _commonRepository.ExcuteStore(\"" +
                                NameStore + "\",arg);");
                sbDA.AppendLine("\t\t}");
                sbDA.AppendLine("\tcatch (Exception ex)");
                sbDA.AppendLine("\t\t{");
                sbDA.AppendLine("objReturn.Success=false;");
                sbDA.AppendLine("objReturn.Message=ex.ToString();");
                sbDA.AppendLine("\t\t}");

                sbDA.AppendLine("return objReturn;");
                sbDA.AppendLine("}");
                //Create For business 
                //Create for interface business
                sbIBS.AppendLine("\tBaseResponse DeleteByKey(" + strParamFunction + ");");
                //Implement for business
                sbBS.AppendLine("public BaseResponse DeleteByKey(" + strParamFunction + ")");
                sbBS.AppendLine("{");


                sbBS.AppendLine("\treturn _" + nameTable + "DataAccess.DeleteByKey(" + strParamPasss + ");");
                sbBS.AppendLine("}");




            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
