using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    class PRODUCTDAO
    {
        public static List<PRODUCT> getList()
        {
            string sql = "select * from product";

            DataTable dt = Connection.addQuery(sql);

            List<PRODUCT> list = new List<PRODUCT>();
            foreach (DataRow Row in dt.Rows)
            {
                PRODUCT p = new PRODUCT();
                p.idproduct = Convert.ToInt32(Row[0].ToString());
                p.productname = Row[1].ToString();
                p.businessname = Row[2].ToString();
                list.Add(p);
            }

            return list;
        }

       
        public static void CreateProduct(string product, string business)
        {
            string sql = String.Format(
                "insert into product( productname, businessname) " +
                "values('{0}', '{1}');",
                product, business);

            Connection.addNonQuery(sql);
        }


        public static void delete(string product)
        {
            string sql = String.Format(
                "delete from product where productname = '{0}';",
                product);
            Connection.addNonQuery(sql);

        }
    }
}
