using System;
using System.Collections.Generic;
using System.Data;
//using ClaseGUI05.Controlador;

namespace ClaseGUI05
{
    public static class InventarioDAO
    {
        public static List<Inventario> getLista()
        {
            string sql = "select * from inventario";

            DataTable dt = Connection.addQuery(sql);

            List<Inventario> lista = new List<Inventario>();
            foreach (DataRow fila in dt.Rows)
            {
                Inventario i = new Inventario();
                i.producto = fila[0].ToString();
                i.descripcion = fila[1].ToString();
                i.precio = Convert.ToDouble(fila[2].ToString());
                i.stock = Convert.ToInt32(fila[3].ToString());

                lista.Add(i);
            }
            return lista;
        }

        public static void actualizarProducto(string producto, string nuevaDescripcion, double cantidad)
        {
            string sql = String.Format(
                "update inventario set descripcion='{1}', precio= '{2}' where producto='{0}';",
                producto,nuevaDescripcion, cantidad);
            
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
        
       /* public static List<FrecuenciaCompras> getEstadisticas()
        {
            string sql = "select count(idpedidos), producto " +
                         "from pedidos " +
                         "where entrar = true " +
                         "group by usuario;";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<FrecuenciaCompras> lista = new List<FrecuenciaCompras>();
            foreach (DataRow fila in dt.Rows)
            {
                FrecuenciaCompras fc = new FrecuenciaCompras();
                fc.cantidad = Convert.ToInt32(fila[0].ToString());
                fc.productos = fila[1].ToString();

                lista.Add(fc);
            }
            return lista;
        }*/
    }
}