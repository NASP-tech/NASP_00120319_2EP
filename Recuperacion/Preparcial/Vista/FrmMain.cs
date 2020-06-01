using Preparcial.Modelo;
using Preparcial.Controlador;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Preparcial.Vista
{

    public partial class FrmMain : Form
    {
        private Usuario u;
        public FrmMain()
        {
            InitializeComponent();
            //this.u = u;
        }

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            if (!txtNewUser.Text.Equals(""))
            {
                ControladorUsuario.CrearUsuario(txtNewUser.Text);
                ActualizarCrearUsuario();
            }
        }

        private void ActualizarCrearUsuario()
        {
            //Natalia: Aqui debe estar una lista que se llene con los datos adquiridos de usuario
            List<Usuario> lista = ControladorUsuario.getList();
            //dgvCreateUser.DataSource = ControladorUsuario.get;
            dgvCreateUser.DataSource = null;
            dgvCreateUser.DataSource = lista;
        }

        private void ActualizarInventario()
        {
            //Natalia: Aqui debe estar una lista que se llene con los datos adquiridos de inventario
            //List<Inventario> listado = ControladorInventario.GetProductosTable();
            dgvInventary.DataSource = ControladorInventario.GetProductosTable();
            //dgvInventary.DataSource = null;
            //dgvInventary.DataSource = listado;
        }

        private void ActualizarOrdenes()
        {
            //Natalia: Aqui debe estar una lista que se llene con los datos adquiridos de pedidos
            //List<Pedido> list = ControladorPedido.GetPedidosTable();
            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
            //dgvAllOrders.DataSource = null;
            //dgvAllOrders.DataSource = list;
        }

        private void ActualizarOrdenesUsuario()
        {
            dgvMyOrders.DataSource = ControladorPedido.GetPedidosUsuarioTable("1");
            cmbProductMakeOrder.ValueMember = "idarticulo";
            cmbProductMakeOrder.DisplayMember = "producto";
            cmbProductMakeOrder.DataSource = ControladorInventario.GetProductosTable();
            //dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
        }

        private void bttnAddInventary_Click(object sender, EventArgs e)
        {
            if (txtProductNameInventary.Text.Equals("") &&
                txtDescriptionInventary.Text.Equals("") &&
                txtPriceInventary.Text.Equals("") &&
                txtStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.AnadirProducto(txtProductNameInventary.Text, txtDescriptionInventary.Text,
                    txtPriceInventary.Text, txtStockInventary.Text);
                //Natalia: Anadir actualizacion
                ActualizarInventario();
            }
        }

        private void bttnDeleteInventary_Click(object sender, EventArgs e)
        {
            //Natalia: Arreglar la sintaxis
            //if(txtDeleteInventary.Text.Equals(""))
            //    MessageBox.Show("No puede dejar campos vacios");

            try { 

            if (MessageBox.Show("Are you sure you want to delete " + txtDeleteInventary.Text + "?",
             "UCA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            
                {
                    ControladorInventario.EliminarProducto(txtDeleteInventary.Text);
                    //Natalia: Anadir actualizacion
                    ActualizarInventario();
                }
            }
            catch
            {
                MessageBox.Show("No se puede eliminar un producto con pedidos");
            }
        }

        private void bttnUpdateStockInventary_Click(object sender, EventArgs e)
        {
            if (txtUpdateStockIdInventary.Text.Equals("") && txtUpdateStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.ActualizarProducto(txtUpdateStockIdInventary.Text, txtUpdateStockInventary.Text);
                //Natalia: Anadir actualizacion
                ActualizarInventario();
            }
        }

        private void bttnMakeOrder_Click(object sender, EventArgs e)
        {
            int idarticulo;
            if (txtMakeOrderQuantity.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                idarticulo = ControladorInventario.GetProductId(cmbProductMakeOrder.Text);
                ControladorPedido.HacerPedido("1", idarticulo.ToString(), txtMakeOrderQuantity.Text);
                ActualizarOrdenesUsuario();
                actualizarControles();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Natalia: u.Admin, cambiarlo a u.Tipo
            //if (tabControl1.SelectedTab.Name.Equals("createNewUserTab") && u.Tipo)
            //    ActualizarCrearUsuario();

            //else if (tabControl1.SelectedTab.Name.Equals("inventaryTab") && u.Tipo)
            //    ActualizarInventario();

            //else if (tabControl1.SelectedTab.Name.Equals("createOrderTab") && !u.Tipo)
            //    ActualizarOrdenesUsuario();

            //else if (tabControl1.SelectedTab.Name.Equals("viewOrdersTab") && u.Tipo)
            //    ActualizarOrdenes();
            
            //else
            //{
            //    MessageBox.Show("No tiene permisos para ver esta pestana");
            //    tabControl1.SelectedTab = tabControl1.TabPages[0];
            //}

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
    Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            actualizarControles();
        }

        //Metodo creado por Natalia
        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            //List<APPUSER> lista = APPUSERDAO.getList();
            List<Inventario> listi = ControladorInventario.GetProductosTable();
            

            cmbProductMakeOrder.DataSource = null;
            cmbProductMakeOrder.ValueMember = "nombreart";
            cmbProductMakeOrder.DisplayMember = "nombreart";
            cmbProductMakeOrder.DataSource = listi;

            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();


        }

    }
}
