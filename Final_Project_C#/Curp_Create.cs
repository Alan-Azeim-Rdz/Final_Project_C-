using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Final_Project_C_
{
    internal class Curp_Create
    {
        private string _name;
        private string _lastname_Dad;
        private string _lastname_Mom;
        private string _brithday;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string LastName_D
        {
            get { return _lastname_Dad; }
            set { _lastname_Dad = value; }
        }

        public string LastName_M
        {
            get { return _lastname_Mom; }
            set { _lastname_Mom = value; }
        }

        public string Brithday
        {
            get { return _brithday; }
            set { _brithday = value; }
        }

        public Curp_Create()
        {
            _name = "";
            _lastname_Dad = "";
            _lastname_Mom = "";
            _brithday = "";
        }

        public Curp_Create(string name, string lastnameD, string lastnameM, string brithday)
        {
            _name = name;
            _lastname_Dad = lastnameD;
            _lastname_Mom = lastnameM;
            _brithday = brithday;


        }

       

        public override string ToString()
        {

            return $"{_lastname_Dad.Substring(0, 2)}{_lastname_Mom.Substring(0, 1)}{_name.Substring(0, 1)}{_brithday.Substring(8, 2)}{_brithday.Substring(3, 2)}{_brithday.Substring(0, 2)}";

        }
    }
}
