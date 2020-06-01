using System.Data;
using System.Collections.Generic;
using Preparcial.Modelo;
using System;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    //Natalia: Aqui no se necesita public static, simplemente class
    class ControladorUsuario
    {
        public static List<Usuario> getList()
        {
            //Natalia: Escribir el try desde el principio de la funcion
            //try
            //{
            //Natalia: anadir la instruccion para seleccionar la tabla usuario
            string sql = "select * from usuario";


            //Natalia: DataTable tableUsuarios = null; Debe anadirse la coneccion a la base de datos:
            DataTable tableUsuarios = ConexionBD.EjecutarConsulta(sql);
            
            //Natalia: var usuarios = new List<Usuario>(); debe ser asi:
            List<Usuario> list = new List<Usuario>();


                // Natalia, se hizo anteriormente...tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");

                //Natalia arreglar la sintaxis del foreach
                //foreach(DataRow dr in tableUsuarios.Rows)
                foreach (DataRow dr in tableUsuarios.Rows)
                {
                    //usuarios.Add(new Usuario
                    //    (
                    //Natalia: Se debe crear un nuevo objeto usuario:
                    Usuario u = new Usuario();
                    //Natalia: Escribir los atributos de usuario    
                    //dr[0].ToString(),
                    //dr[1].ToString(),
                    //dr[2].ToString(),
                    u.IdUsuario = dr[0].ToString();
                    u.Nombre = dr[1].ToString();
                    u.Contrasenia = dr[2].ToString();
                    u.Tipo = Convert.ToBoolean(dr[3].ToString());

                    //Natalia: se debe anadir a la lista el objeto usuario
                    list.Add(u);
                    //Convert.ToBoolean(dr[3].ToString())
                   
               // );
            }

            //Natalia: Aqui debe retornar list y no usuarios...
            return list;
            //}
            //Natalia: Se debe escribir el catch hasta el final de la funcion
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Ha ocurrido un error");
            //}

        }

        //Natalia: Uso incorrecto de llamar a un usuario... 
        //La funcion que lo realiza es la primera en esta clase

        //public static DataTable GetUsuariosTable()
        //{
        //    DataTable tableUsuarios = null;

        //    try
        //    {
        //        tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ha ocurrido un error");
        //    }

        //    return tableUsuarios;
        //}

        //Natalia en lugar de poner string idUsuario es ---> string nombre. 
        //idUsuario es serial en todo caso
        public static void ActualizarContrasena(string nombre, string nueva)
        {
            try
            {
                //Natalia: Sintaxis incorrecta para actualizar informacion en la base de datos
                //ConexionBD.EjecutarComando($"UPDATE USUARIO SET contrasenia = '{nueva}' " +
                //    $"WHERE idUsuario = {idUsuario}");

                //Natalia: Debe ser asi:
                string sql = String.Format(
                    "update usuario set contrasenia = '{0}' where usuario = '{1}';",
                    nueva, nombre);
                //Natalia: Debe llamarse a la conexion de la base de datos:
                ConexionBD.EjecutarComando(sql);


                MessageBox.Show("Se ha actualizado la contrasena");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        
        public static void CrearUsuario(string usuario)
        {
            try
            {
                //Natalia: La sintaxis para crear un nuevo usuario no es correcta
                //ConexionBD.EjecutarComando("INSERT INTO USUARIO(nombreUsuario, contrasenia, tipo)" +
                //    $" VALUES('{usuario}', '{usuario}', false)");

                string sql = String.Format(
                    "insert into usuario(nombre, contrasenia, tipo)" +
                    "values('{0}', '{0}', false);",
                    usuario);

                //Natalia: Debe llamarse a la conexion de la base de datos:
                ConexionBD.EjecutarComando(sql);

                MessageBox.Show("Se ha agregado el nuevo usuario, contrasenia igual al nombre");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
