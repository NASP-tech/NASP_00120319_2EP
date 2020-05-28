using Parcial2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class frmMainPage : Form
    {
        private APPUSER usuario;
        //private APPUSER pUsuario;

        public frmMainPage()
        {
            InitializeComponent();
            //usuario = pusuario;

           // if (usuario.administrator) ;
            //{
            //    graficoEstadisticas = new CartesianChart();
            //    this.Controls.Add(graficoEstadisticas);
            //    graficoEstadisticas.Parent = tabContenedor.TabPages[3];
            //}
        }

        //Create User
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtName.Text.Length >= 5)
                {
                    APPUSERDAO.CreateUser(txtName.Text, txtUsername.Text);

                    MessageBox.Show("User added! " +
                                    "at beginning password is the same fullname, no administrator",
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtName.Clear();
                    txtUsername.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Minimum length 5",
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.",
            //        "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //Update 
        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<APPUSER> lista = APPUSERDAO.getList();
            List<BUSINESS> list = BUSINESSDAO.getList();
            List<PRODUCT> listado = PRODUCTDAO.getList();
            List<APPORDER> listi = APPORDERDAO.getList();
            List<ADDRESS> listo = ADDRESSDAO.getList();

            // Tabla (data grid view)
            dvgUser.DataSource = null;
            dvgUser.DataSource = lista;
            // Menu desplegable (combo box)
            //txtName.DataSource = null;
            cmbUsername.DataSource = null;
            cmbUsername.ValueMember = "password";
            cmbUsername.DisplayMember = "username";
            cmbUsername.DataSource = lista;


            cmbUsernameId.DataSource = null;
            cmbUsernameId.ValueMember = "password";
            cmbUsernameId.DisplayMember = "username";
            cmbUsernameId.DataSource = lista;
            //cmbUsuario.ValueMember = "contrasena";
            //cmbUsuario.DisplayMember = "usuario";
            //cmbUsuario.DataSource = lista;
            // Grafico con estadisticas
            //poblarGrafico();
            dgvBusiness.DataSource = null;
            dgvBusiness.DataSource = list;
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "businessname";
            cmbBusiness.DisplayMember = "businessname";
            cmbBusiness.DataSource = list;

            cmbUsernameAddress.DataSource = null;
            cmbUsernameAddress.ValueMember = "password";
            cmbUsernameAddress.DisplayMember = "username";
            cmbUsernameAddress.DataSource = lista;

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = listado;

            
            dgvProductsOptions.DataSource = null;
            dgvProductsOptions.DataSource = listado;

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = listi;

            dgvAllOrders.DataSource = null;
            dgvAllOrders.DataSource = listi;

            dgvAddressModify.DataSource = null;
            dgvAddressModify.DataSource = listo;
        }

        //Load Form
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            actualizarControles();
            //if (usuario.administrator)
            //{
            //    actualizarControles();

            //}
            //else
            //{
            //    tabControl1.TabPages[0].Parent = null;
            //    tabControl1.TabPages[1].Parent = null;
            //}

        }

        //Add user
        private void btnSave_Click(object sender, EventArgs e)
        {
            APPUSERDAO.updateAccess(cmbUsername.Text, rbAdministrator.Checked);
            ADDRESSDAO.CreateAddress(txtAddress.Text, cmbUsername.Text);

            MessageBox.Show("User updated!",
                "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            actualizarControles();
        }

        //Delete User
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete " + cmbUsername.Text + "?",
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    APPUSERDAO.delete(cmbUsername.Text);

                    MessageBox.Show("Delete success!",
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarControles();
                }
            }
            catch
            {
                MessageBox.Show("You can't delete an administrator");
            }
        }

        //Add Business
        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            try
            {
                BUSINESSDAO.CreateBusiness(txtBusinessName.Text, txtDescription.Text);
                MessageBox.Show("Business added to HUGO!",
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarControles();
            }
            catch (Exception)
            {
                MessageBox.Show("Your Business already exists");
            }
            
        }
              
       

        //Delete Business
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete " + txtBusinessName.Text + "?",
                "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUSINESSDAO.delete(txtBusinessName.Text);

                    MessageBox.Show("Delete success!",
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarControles();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You can't delete a Business with products");
            }
            
        }

        //Delete Products

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete " + txtProductName.Text + "?",
            "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PRODUCTDAO.delete(txtProductName.Text);

                    MessageBox.Show("Delete success!",
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarControles();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You product did not exists");
            }


        }

        //Add Product

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                PRODUCTDAO.CreateProduct(txtProductName.Text, cmbBusiness.Text);
                MessageBox.Show("Product added to HUGO!",
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarControles();
            }
            catch (Exception)
            {
                MessageBox.Show("Your product already exists");
            }
           
        }

        //Add orders
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {

            try
            {
                APPORDERDAO.CreateOrder(Convert.ToInt32(txtProductID.Text), cmbUsernameId.Text, txtDate.Text);
                MessageBox.Show("Order added to HUGO!",
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarControles();
            }
            catch (Exception)
            {
                MessageBox.Show("Your order already exists");
            }
        }

        //Delete Order
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete " + txtProductID.Text + "?",
           "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    APPORDERDAO.delete(Convert.ToInt32(txtProductID.Text), cmbUsernameId.Text);

                    MessageBox.Show("Delete success!",
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarControles();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your didn't exists");
            }

        }

        //Add Address
        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
                ADDRESSDAO.CreateAddress(txtAddressFix.Text, cmbUsernameAddress.Text);
                    MessageBox.Show("Address added to HUGO!",
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarControles();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Your order already exists");
            //}
        }

        //Delete Address
        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (MessageBox.Show("Are you sure you want to delete " + txtIdAddress.Text + "?",
                 "HUGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ADDRESSDAO.delete( txtIdAddress.Text);

                    MessageBox.Show("Delete success!",
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarControles();
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Your didn't exists");
            //}
        }

        
    }
}
