using Parcial2.Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class ADDRESSDAO
    {
         public static List<ADDRESS> getList()
        {
            string sql = "select * from address";

            DataTable dt = Connection.addQuery(sql);

            List<ADDRESS> list = new List<ADDRESS>();
            foreach(DataRow Row in dt.Rows)
            {
                ADDRESS a = new ADDRESS();
                a.idAddress = Convert.ToInt32(Row[0].ToString());
                a.username = Row[1].ToString();
                a.address = Row[2].ToString();
                list.Add(a);
            }

            return list;
        }

        public static void updateAddress( string newaddress, string username)
        {
            string sql = String.Format(
                "update address set address = '{1}' where idaddress = '{0}';",
                username,newaddress);
            Connection.addNonQuery(sql);
        }

        public static void CreateAddress(string address, string username)
        {
            string sql = String.Format(
                "insert into address( username, address) " +
                "values('{1}', '{0}');",
                address, username);
            
            Connection.addNonQuery(sql);
        }

        
        public static void delete(string address)
        {
            string sql = String.Format(
                "delete from address where idaddress = '{0}';",
                address);
            Connection.addNonQuery(sql);

        }


       
    }
}
