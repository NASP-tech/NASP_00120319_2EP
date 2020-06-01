using System;
using System.Drawing;
using System.Windows.Forms;
using Preparcial.Controlador;
using Preparcial.Modelo;
using Preparcial.Vista;

namespace Preparcial
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Evento Load del FrmLogin, para cargar la imagen del logo UCA desde la carpeta root
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Natalia: Hacer los cambios con respecto a la imagen desde el designer
            //pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            //pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            PoblarControlers();
        }
        
        // Metodo para poblar el comboBox con todos los usuarios, asignando el value member y display member desde
        // las PROPIEDADES de la clase Usuario, deben ser publicas y llamarse igual para que funcione, ademas
        // primero se asigna el ValueMember, luego DisplayMember, y por ultimo el DataSource, sino tira excepcion
        private void PoblarControlers()
        {
            //Natalia: Arreglar la sintaxis para rellenar el comboBox
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "contrasenia";
            cmbUser.DisplayMember = "nombre";
            cmbUser.DataSource = ControladorUsuario.getList();
        }

        // EventHandler para detectar el click para inciar sesion
        private void BttnLogin_Click(object sender, EventArgs e)
        {
            // Si la contrasena del textBox es igual al SelectedValue del comboBox, entonces iniciar sesion
            if (textBox1.Text.Equals(cmbUser.SelectedValue.ToString()))
            {
                //Natalia: Permitir iniciar acceso al usuario seleccionado del comboBox
                Usuario u = (Usuario)cmbUser.SelectedItem;

                // Crear ventana principal enviandole el item seleccionado
                // Recordar que SelectedItem devuelve un objeto, con polimorfismo se convierte a Usuario
                FrmMain frmMain = new FrmMain();
                // Esconder frmLogin y mostrar frmMain

                //Natalia: Cambiar a frmMain.show(); antes de Hide() que debe ser this.Hide();
                frmMain.Show();
                this.Hide();
            //Hide();
            //frmMain.Show();
        }
            else
                MessageBox.Show("Contrasena incorrecta");
        }

        // EventHandler para invocar al form de actualizar contrasena
        private void BttnUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmPassword frmPassword = new FrmPassword();
            frmPassword.Show();
        }
    }
}
