using Parcial2.Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Parcial2.Model
{
    class APPUSERDAO 
    {
        public static List<APPUSER> getList()
        {
            string sql = "select * from appuser";

            DataTable dt = Connection.addQuery(sql);

            List<APPUSER> list = new List<APPUSER>();
            foreach(DataRow Row in dt.Rows)
            {
                APPUSER u = new APPUSER();
                u.fullname = Row[1].ToString();
                u.username = Row[2].ToString();
                u.password = Row[3].ToString();
                u.administrator = Convert.ToBoolean(Row[4].ToString());

                list.Add(u);
            }

            return list;
        }

        public static void updatePassword(string user, string newPassword)
        {
            string sql = String.Format(
                "update appuser set password = '{0}' where username = '{1}';",
                newPassword, user);
            Connection.addNonQuery(sql);
        }

        public static void CreateUser(string user, string username)
        {
            string sql = String.Format(
                "insert into appuser(fullname, username, password, administrator) " +
                "values('{0}', '{1}', '{2}', false);",
                user, username, Encryptor.CreateMD5(user));
            
            Connection.addNonQuery(sql);
        }

        public static void updateAccess(string user, bool admin)
        {
            string sql = String.Format(
                "update appuser set administrator = {0} where username = '{1}';",
                admin ? "true" : "false", user);
            Connection.addNonQuery(sql);

        }

        public static void delete(string user)
        {
            string sql = String.Format(
                "delete from appuser where username = '{0}';",
                user);
            Connection.addNonQuery(sql);

        }


        public static List<Frequency> GetFrequencies()
        {
            string sql = "select count(idOrder), username"+
                "from apporder"+ "where fullname = '' " +
                "group by appuser;";
            DataTable dt = Connection.addQuery(sql);

            List<Frequency> list = new List<Frequency>();
            foreach(DataRow row in dt.Rows)
            {
                Frequency f = new Frequency();
                f.amount = Convert.ToInt32(row[0].ToString());
                f.user = row[1].ToString();

                list.Add(f);
                                
            }
            return list;
        }
    }
}
