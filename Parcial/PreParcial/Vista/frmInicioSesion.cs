using System;
using System.Windows.Forms;
//using ClaseGUI05.Controlador;
//using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //if (Encriptador.CompararMD5(txtContrasena.Text, cmbUsuario.SelectedValue.ToString()))
            if (true)
            {
                Usuario u = (Usuario) cmbUsuario.SelectedItem;

                if (u.activo)
                {
                    RegistroDAO.iniciarSesion(u.usuario);
                    
                    MessageBox.Show("¡Bienvenido!", 
                        "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    frmPrincipal ventana = new frmPrincipal(u);
                    ventana.Show();
                    //ventana.size = new Size(420, 200);
                    this.Hide();
                }
                else
                    MessageBox.Show("Su cuenta se encuentra inactiva, favor hable con el administrador", 
                        "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "ClaseGUI05",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnIniciarSesion_Click(sender, e);
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            frmCambiarContra unaVentana = new frmCambiarContra();
            unaVentana.ShowDialog();
            poblarControles();
        }
    }
}