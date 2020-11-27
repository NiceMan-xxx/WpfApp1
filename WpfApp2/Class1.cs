using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Class1
    {
        public Class1()
        {
            
            ColorsList = new List<Color>();
            ColorsList.Add(new Color() { Code = "#FF8C08",CodeTwo="5" });
            ColorsList.Add(new Color() { Code = "#FFEEB4", CodeTwo = "6" });
            Colors = new Colors()
            {
                Codes = "fff"
            };
        }
        public  void ss()
        {
            aa = "ff";
        }

        public List<Color> ColorsList { get; set; }

        public string Name { get; set; }
        public Colors Colors { get; set; }
        public string aa { get; set; }
    }
    public class Color
    {

        public string Code { get; set; }
        public string CodeTwo { get; set; }


    }
    public class Colors
    {
        //public Colors()
        //{
        //    Codes = "s";
        //}

        public string Codes { get; set; }


    }
}
