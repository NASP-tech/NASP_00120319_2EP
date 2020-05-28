using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class BUSINESSDAO
    {
        public static List<BUSINESS> getList()
        {
            string sql = "select * from business";

            DataTable dt = Connection.addQuery(sql);

            List<BUSINESS> list = new List<BUSINESS>();
            foreach (DataRow Row in dt.Rows)
            {
                BUSINESS b = new BUSINESS();
                b.idbusiness = Convert.ToInt32(Row[0].ToString());
                b.businessname = Row[1].ToString();
                b.description = Row[2].ToString();
                list.Add(b);
            }

            return list;
        }

       
        public static void CreateBusiness(string businessname, string description)
        {
            string sql = String.Format(
                "insert into business( businessname, description) " +
                "values('{0}', '{1}');",
                businessname, description);

            Connection.addNonQuery(sql);
        }


        public static void delete(string businessname)
        {
            string sql = String.Format(
                "delete from business where businessname = '{0}';",
                businessname);
            Connection.addNonQuery(sql);

        }
    }
}
