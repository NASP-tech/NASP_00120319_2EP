using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorInventario
    {
        // Metodo encargado de devolver un DataTable con todos los elementos del inventario
        //El metodo debe ser tipo List y no DataTable


        //public static DataTable GetProductosTable()
        //{
        //    DataTable productos = null;

        //    // Solamente la consulta y conexion a la BD van en el try, ya que lo demas no puede ocasionar excepcion
        //    try
        //    {
        //        productos = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Ha ocurrido un error");
        //    }

        //    return productos;
        //}

        // Adicionado por Natalia
        public static int GetProductId(string nombre)
        {
            int idProducto;
            // Solamente la consulta y conexion a la BD van en el try, ya que lo demas no puede ocasionar excepcion
            try
            {
                string sql = String.Format($"select idarticulo from inventario where nombreart = '{nombre}' ");
                //idProducto = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");
                idProducto = ConexionBD.EjecutaEscalar(sql);
                return idProducto;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                idProducto = 0;
                return idProducto;
            }
        }

    // Metodo que devuelve los productos en formato de List
    public static List<Inventario> GetProductosTable()
        {
            //try
            //{
                //Natalia: Cambios en Declaracion de lista y DataTable
                string sql = "select idArticulo,nombreArt,descripcion,stock from inventario";
                //Natalia: Hacer la conexion con la DB
                DataTable dt = ConexionBD.EjecutarConsulta(sql);
                //Natalia: LLenar la lista

                List<Inventario> list = new List<Inventario>();
            foreach (DataRow Row in dt.Rows)
            {
                //productos.Add(new Inventario
                //    (
                //Natalia: Arreglando los valores, y corriegiendo la , por ;
                Inventario i = new Inventario();
                i.idArticulo = Convert.ToInt32(Row[0].ToString());
                i.nombreArt = Row[1].ToString();
                i.descripcion = Row[2].ToString();
                //i.precio = Row[3].ToDouble().ToString("c");
                i.stock = Convert.ToInt32(Row[3].ToString());
                    list.Add(i);
                }

                return list;

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ha ocurrido un error");
            //}
            
        }


        // Metodo para anadir productos
        public static void AnadirProducto(string nombre, string descripcion, string precio, string stock)
        {
            try
            {
                //Natalia: Arreglar la sintaxis para insertar datos en la lista de productos
                //ConexionBD.EjecutarComando();

                string sql = String.Format(
                    "INSERT INTO INVENTARIO(nombreart, descripcion, precio, stock)" +
                    $" VALUES('{nombre}', '{descripcion}', {precio}, {stock});");

                //Natalia: Anadir la conexion con la base de datos
                ConexionBD.EjecutarComando(sql);
                
                MessageBox.Show("Se ha agregado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Metodo para eliminar productos
        public static void EliminarProducto(string id)
        {
            try
            {
                //Natalia: Arreglar la sintaxis para insertar datos en la lista de productos
                //ConexionBD.EjecutarComando();
                string sql = String.Format($"DELETE FROM INVENTARIO WHERE idarticulo = {id}");

                //Natalia: Anadir la conexion con la base de datos
                ConexionBD.EjecutarComando(sql);

                MessageBox.Show("Se ha eliminado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Metodo para actualizar stock de un producto
        public static void ActualizarProducto(string id, string stock)
        {
            try
            {
                //Natalia: Arreglar la sintaxis para insertar datos en la lista de productos
                //ConexionBD.EjecutarComando();
                string sql = String.Format($"UPDATE INVENTARIO SET stock = {stock} WHERE idArticulo = {id}");

                //Natalia: Anadir la conexion con la base de datos
                ConexionBD.EjecutarComando(sql);
                MessageBox.Show("Se ha actualizado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
