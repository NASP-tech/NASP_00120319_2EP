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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            cmbUsername.DataSource = null;
            cmbUsername.ValueMember = "password";
            cmbUsername.DisplayMember = "username";
            cmbUsername.DataSource = APPUSERDAO.getList();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            bool currentPassword = Encryptor.CompareMD5(txtCurrentPassword.Text, cmbUsername.SelectedValue.ToString());
            bool newEquals = txtNewPassword.Text.Equals(txtRepeatNewPassword.Text);
            bool newValidate = txtNewPassword.Text.Length > 0;

            if(currentPassword && newEquals && newValidate)
            {
                try
                {
                    APPUSERDAO.updatePassword(cmbUsername.Text, Encryptor.CreateMD5(txtNewPassword.Text));

                    MessageBox.Show("Updated Password!", "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

                catch (Exception)
                {
                    MessageBox.Show("Try Again :(", "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verify your data", "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
