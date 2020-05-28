using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class APPORDER
    {
        public int idorder { get; set; }
        public string createdate { get; set; }
        public int idproduct { get; set; }
        public string username { get; set; }

        public APPORDER()
        {
            idorder = 0;
            createdate = ""; 
            idproduct = 0;
            username = "";
        }
    }
}
