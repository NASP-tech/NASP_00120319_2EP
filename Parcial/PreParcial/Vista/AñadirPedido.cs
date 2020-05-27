using System.Windows.Forms;
//using ClaseGUI05.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data;
using System.Windows.Forms;

namespace ClaseGUI05
{
    public partial class AñadirPedido : UserControl
    {
        public AñadirPedido()
        {
            InitializeComponent();
        }

     
        
        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            
            if (cmbUsuarios.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios");
            }
            else
            {
                //try
                //{
                    var idCantidad = Convert.ToInt32(txtCantidad.Text.ToString());

                    string nonQuery = $" INSERT INTO PEDIDOS(cantidad, producto, idusuario) VALUES(" +
                                      $"{idCantidad},"+
                                      $"'{cmbProductos.SelectedItem.ToString()}'," + 
                                      $"'{cmbUsuarios.SelectedItem.ToString()}')"; 

                    Connection.addNonQuery(nonQuery);

                    MessageBox.Show("Se ha iniciado la orden de su pedido! Muchas gracias por preferirnos!!! :)");

                //}
                //catch (Exception exception)
                //{
                //    MessageBox.Show("Ha ocurrido un error");
                //}
            }
            
            
        }


        private void AñadirPedido_Load(object sender, EventArgs e)
        {
            var usuarios = Connection.addQuery("SELECT usuario FROM usuario");
            var usuariosCombo = new List<string>();

            foreach (DataRow dr in usuarios.Rows)
            {
                usuariosCombo.Add(dr[0].ToString());
            }

            cmbUsuarios.DataSource = usuariosCombo;

            var productos = Connection.addQuery("SELECT producto FROM inventario");
            var productosCombo = new List<string>();

            foreach (DataRow dl in productos.Rows)
            {
                productosCombo.Add(dl[0].ToString());
            }
            cmbProductos.DataSource = productosCombo;
        }
    }
}