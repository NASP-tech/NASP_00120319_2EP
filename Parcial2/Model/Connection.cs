using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Connection
    {
        private static string ConnectionChain =
            "Server=Localhost;Port=5432;User Id=postgres;Password=natalia.99;Database=ParcialDos";

        public static DataTable addQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConnectionChain);
            DataSet ds = new DataSet();

            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        public static void addNonQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConnectionChain);
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();

        }


    }
}
