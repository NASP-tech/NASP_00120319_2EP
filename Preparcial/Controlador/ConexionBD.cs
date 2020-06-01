using System.Data;
using Npgsql;

namespace Preparcial.Controlador
{
    public static class ConexionBD
    {
        // Cadena de conexion
        //Natalia: Modifique la conexion con mi base de datos local
        private static string cadenaC = "Server=Localhost;" +
                                        "Port=5432;" +
                                        "UserId=postgres;" +
                                        "Password=natalia.99;" +
                                        "Database=parcialDosReposicion;";

        // Ejecutar consulta (Comando SELECT)
        public static DataTable EjecutarConsulta(string consulta)
        {
            var conn = new NpgsqlConnection(cadenaC);
            var ds = new DataSet();

            conn.Open();
            var da = new NpgsqlDataAdapter(consulta, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        // Natalia: Ejecutar consulta escalar(Comando SELECT)
        // Natalia: metodo hecho por Natalia
        public static int EjecutaEscalar(string consulta)
        {
            var conn = new NpgsqlConnection(cadenaC);
            //var ds = new DataSet();

            conn.Open();
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(consulta, conn);
            int count = (int)command.ExecuteScalar();
            //var da = new NpgsqlDataAdapter(consulta, conn);
            //da.Fill(ds);
            conn.Close();

            return count;
        }

        // Ejecutar comando (UPDATE, INSERT, DELETE, ETC)
        public static void EjecutarComando(string comando)
        {
            var conn = new NpgsqlConnection(cadenaC);

            conn.Open();
            var comm = new NpgsqlCommand(comando, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}