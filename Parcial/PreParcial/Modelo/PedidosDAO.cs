using System;
using System.Collections.Generic;
using System.Data;

namespace ClaseGUI05
{
    public class PedidosDAO
    {
        public static List<Pedidos> getLista()
        {
            string sql = "select * from pedidos";

            DataTable dp = Connection.addQuery(sql);

            List<Pedidos> lista = new List<Pedidos>();
            foreach (DataRow fila in dp.Rows)
            {
                Pedidos p = new Pedidos();
                p.idusuario = fila[1].ToString();
                p.producto = fila[2].ToString();
                p.cantidad = Convert.ToInt32(fila[3].ToString());
                
                lista.Add(p);
            }
            return lista;
        }

        public static void actualizarPedido(string cmbProductsText, string producto, string nuevaDescripcion)
        {
            string sql = String.Format(
                "update inventario set descripcion='{1}' where producto='{2}';",
                nuevaDescripcion, producto);
            
            Connection.addNonQuery(sql);
        }

        public static void crearNuevo(string producto, string descripcion, double precio)
        {
            //string nusuario = usuario.Substring(0, 15);
            string sql = String.Format(
                "insert into inventario(producto, descripcion, precio, stock) " +
                "values('{0}', '{1}', '{2}', 0);",
                producto, descripcion, precio);
            
            Connection.addNonQuery(sql);
        }

        public static void eliminarProducto(string producto)
        {
            string sql = String.Format(
                "delete from pedidos where producto ='{0}'; " +
                "delete from inventario where producto='{0}';",
                producto);
            
            Connection.addNonQuery(sql);
        }

    }
}