using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class BUSINESS
    {
        public int idbusiness { get; set; }
        public string businessname { get; set; }
        public string description { get; set; }

        public BUSINESS()
        {
            idbusiness = 0;
            businessname = "";
            description = "";
        }
    }
}
