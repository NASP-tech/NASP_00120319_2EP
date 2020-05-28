using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class PRODUCT
    {
        public int idproduct { get; set; }
        public string businessname { get; set; }
        public string productname { get; set; }

        public PRODUCT()
        {
            idproduct = 0;
            businessname = "";
            productname = "";
        }
        
    }
}
