using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class APPORDERDAO
    {
        public static List<APPORDER> getList()
        {
            string sql = "select * from apporder";

            DataTable dt = Connection.addQuery(sql);

            List<APPORDER> list = new List<APPORDER>();
            foreach (DataRow Row in dt.Rows)
            {
                APPORDER o = new APPORDER();
                o.idorder = Convert.ToInt32(Row[0].ToString());
                o.createdate = Row[1].ToString();
                o.idproduct = Convert.ToInt32(Row[2].ToString());
                o.username = Row[3].ToString();
                list.Add(o);
                
            }

            return list;
        }


        public static void CreateOrder(int idProduct, string username, string fecha)
        {
            string sql = String.Format(
                "insert into apporder( idproduct, username, createdate) " +
                "values('{0}', '{1}', '{2}');",
                idProduct, username, fecha);

            Connection.addNonQuery(sql);
        }


        public static void delete(int idproduct, string username)
        {
            string sql = String.Format(
                "delete from apporder where idproduct = '{0}' AND username = '{1}';",
                idproduct, username);
            Connection.addNonQuery(sql);

        }
    }
}
