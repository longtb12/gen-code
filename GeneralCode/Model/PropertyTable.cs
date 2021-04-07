using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCode.Model
{
    public class PropertyTable
    {
        public string Column_Name { get; set; }
        public string Data_type { get; set; }
        public int Max_Length { get; set; }
        public bool is_nullable { get; set; }
        public int precision { get; set; }
        public int scale { get; set; }
        public bool Primary_Key { get; set; }
        public bool Is_Identity { get; set; }
        public int CHARACTER_MAXIMUM_LENGTH { get; set; }
    }
}
