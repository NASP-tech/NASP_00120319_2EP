using Parcial2.Control;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            populateControls();
        }

        private void populateControls()
        {
            cmbUsername.DataSource = null;
            cmbUsername.ValueMember = "password";
            cmbUsername.DisplayMember = "username";
            cmbUsername.DataSource = APPUSERDAO.getList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Encryptor.CompareMD5(txtPassword.Text, cmbUsername.SelectedValue.ToString()))
            {
                APPUSER u = (APPUSER)cmbUsername.SelectedItem;

                MessageBox.Show("Welcome!",
                       "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //APPUSERDAO.updateAccess(u.username);
                frmMainPage ventana = new frmMainPage();
                ventana.Show();
                //ventana.size = new Size(420, 200);
                this.Hide();
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Clase GUI 05",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword unaVentana = new frmChangePassword();
            unaVentana.ShowDialog();
            populateControls();
        }
    }
}
