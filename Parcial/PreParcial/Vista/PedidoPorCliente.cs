using System;
using System.Windows.Forms;

namespace ClaseGUI05
{
    public partial class PedidoPorCliente : UserControl
    {
        public PedidoPorCliente()
        {
            InitializeComponent();
        }

        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }

            else
            {
                try
                {
                    var dt = Conexion.realizarConsulta($"SELECT prod.producto, ped.cantidad " +
                                                       "FROM pedidos ped, inventario prod, usuario usu " +
                                                       $"WHERE ped.producto = prod.producto AND ped.idusuario = usu.usuario " +
                                                       $"AND ped.idusuario = '{txtUsuario.Text}'");

                    dgvPedidos.DataSource = dt;
                    MessageBox.Show("Datos obtenidos exitosamente");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un problema");
                }
            }
        }
    }
}