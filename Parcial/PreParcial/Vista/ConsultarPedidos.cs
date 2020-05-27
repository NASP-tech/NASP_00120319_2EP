using System;
using System.Windows.Forms;

namespace ClaseGUI05
{
    public partial class ConsultarPedidos : UserControl
    {
        public ConsultarPedidos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.realizarConsulta($"SELECT * FROM pedidos");

                dataGridView1.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
}