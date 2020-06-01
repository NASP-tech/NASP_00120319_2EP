using System;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorPedido
    {
        
        //Natalia: La funcion debe ser de tipo lista
        public static DataTable GetPedidosUsuarioTable(string id)
        {
            DataTable pedidos = null;

            try
            {
                //Natalia: Correccion en la consulta -->nombreArticulos -->nombreArt
                //Natalia: Eliminar (i.precio * p.cantidad) AS total
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreart, p.cantidad, i.precio" +
                                            " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                            " WHERE p.idArticulo = i.idArticulo" +
                                            " AND p.idUsuario = u.idUsuario" +
                                            $" AND u.idUsuario = {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static DataTable GetPedidosTable()
        {
            DataTable pedidos = null;

            try
            {
                //Natalia: Correccion en la consulta -->nombreArticulos -->nombreArt
                //Natalia: Eliminar (i.precio * p.cantidad) AS total
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreart, p.cantidad, i.precio" +
                                            " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                            " WHERE p.idArticulo = i.idArticulo" +
                                            " AND p.idUsuario = u.idUsuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static void HacerPedido(string idUsuario, string idArticulo, string cantidad)
        {
            //try
            //{
                //Natalia: Arreglar la sintaxis para insertar datos en la lista de productos
                //ConexionBD.EjecutarComando();

                string sql = String.Format("INSERT INTO PEDIDO(idUsuario, idArticulo, cantidad) " +
                    $"VALUES('{idUsuario}', {idArticulo}, {cantidad})");
                //Natalia: Anadir la conexion con la base de datos
                ConexionBD.EjecutarComando(sql);
                MessageBox.Show("Se ha agregado un pedido");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ha ocurrido un error");
            //}
        }
    }
}
