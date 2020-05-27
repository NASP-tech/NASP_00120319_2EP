using System.Data;
using Npgsql;

namespace ClaseGUI05
{
    public static class Connection
    {
        private static string CadenaConexion = 
            "Server=Localhost;Port=5432;User Id=postgres;Password=natalia.99;Database=bddEmpleados";
        
        public static DataTable addQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
            DataSet ds = new DataSet();
            
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            
            return ds.Tables[0];
        }

        public static void addNonQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
            
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}