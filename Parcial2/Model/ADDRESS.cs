using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class ADDRESS
    {
        public int idAddress { get; set; }
        public string username { get; set; }
        public string address { get; set; }


        public ADDRESS()
        {
            idAddress = 0;
            username = "";
            address = "";
        }
       
    }
}
