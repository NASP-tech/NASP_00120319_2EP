using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class APPUSER
    {
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool administrator { get; set; }

        public APPUSER()
        {
            fullname = "";
            username = "";
            password = "";
            administrator = false;
        }

    }
}
