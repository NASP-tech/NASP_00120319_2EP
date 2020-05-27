using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using ClaseGUI05.Controlador;
//using ClaseGUI05.Modelo;
using LiveCharts;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace ClaseGUI05
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuario;
        private CartesianChart graficoEstadisticas;
        
        public frmPrincipal(Usuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;

            if (usuario.admin)
            {
                graficoEstadisticas = new CartesianChart();
                this.Controls.Add(graficoEstadisticas);
                graficoEstadisticas.Parent = tabContenedor.TabPages[3];
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = 
                "Bienvenido " + usuario.usuario + " [" + (usuario.admin ? "Administrador" : "Usuario") + "]";

            if (usuario.admin)
            {
                // Los administradores si tienen acceso a esta informacion
                configurarGrafico();
                actualizarControles();
                actualizando();
                
            }
            else
            {
                // Los usuarios NO administradores no tienen permiso de acceder a estas pestanas
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[2].Parent = null;
            }
        }

        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<Usuario> lista = UsuarioDAO.getLista();
            
            // Tabla (data grid view)
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista;
            // Menu desplegable (combo box)
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.DataSource = lista;
            // Grafico con estadisticas
            actualizando();
            poblarGrafico();
        }

        private void actualizando()
        {
            // Realizar consulta a la base de datos
            //List<Usuario> lista = UsuarioDAO.getLista();
            List<Inventario> list = InventarioDAO.getLista();
            
            // Tabla (data grid view)
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = list;
            
            // Menu desplegable (combo box)
            //cmbUsuario.DataSource = null;
            //cmbUsuario.ValueMember = "contrasena";
            //cmbUsuario.DisplayMember = "usuario";
            //cmbUsuario.DataSource = lista;
            cmbProducts.DataSource = list;
            cmbProducts.ValueMember = "descripcion";
            cmbProducts.DisplayMember = "producto";
            //cmbProducts.DataSource = list;
            
            // Grafico con estadisticas
            //poblarGrafico();
        }
        
        private void configurarGrafico()
        {
            graficoEstadisticas.Top = 10;
            graficoEstadisticas.Left = 10;
            graficoEstadisticas.Width = graficoEstadisticas.Parent.Width - 20;
            graficoEstadisticas.Height = graficoEstadisticas.Parent.Height - 20;

            graficoEstadisticas.Series = new SeriesCollection
            {
                new ColumnSeries{Title = "Cantidad de inicios de sesion", Values = new ChartValues<int>(), DataLabels = true}
            };
            graficoEstadisticas.AxisX.Add(new Axis{Labels = new List<string>()});
            graficoEstadisticas.AxisX[0].Separator = new Separator() {Step = 1, IsEnabled = false};
            graficoEstadisticas.LegendLocation = LegendLocation.Top;
        }
        
        private void poblarGrafico()
        {
            graficoEstadisticas.Series[0].Values.Clear();
            graficoEstadisticas.AxisX[0].Labels.Clear();
            
            foreach (Frecuencia f in UsuarioDAO.getEstadisticas())
            {
                graficoEstadisticas.Series[0].Values.Add(f.cantidad);
                graficoEstadisticas.AxisX[0].Labels.Add(f.usuario);
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + usuario.usuario + "?", 
                "Frutas y Verduras", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    RegistroDAO.cerrarSesion(usuario.usuario);

                    // No se pone el App.Exit() aquí porque volvería a llamar al evento
                    // form closing, ejecutando 2 veces el message box
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha sucedido un error, favor intente dentro de un minuto.", 
                        "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Necesario porque el frmInicioSesion está escondido
            Application.Exit();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoEmpleado.Text.Length >= 5)
                {
                    UsuarioDAO.crearNuevo(txtNuevoEmpleado.Text);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                    "contrasena igual a usuario, no admin y si activo.", 
                        "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtNuevoEmpleado.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)", 
                        "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarControles();
        }
        
        

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario u = (Usuario) cmbUsuario.SelectedItem;

            if (u.admin)
                radAdmin.Checked = true;
            else
                radUsuario.Checked = true;
            
            if (u.activo)
                radActivo.Checked = true;
            else
                radInactivo.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioDAO.actualizarPermisos(cmbUsuario.Text, radAdmin.Checked, radActivo.Checked);
            
            MessageBox.Show("¡Usuario actualizado exitosamente!", 
                "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            actualizarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + cmbUsuario.Text + "?", 
                "Frutas y Verduras", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioDAO.eliminar(cmbUsuario.Text);
                
                MessageBox.Show("¡Usuario eliminado exitosamente!", 
                    "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }


        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAñadirProducto.Text.Length >= 5)
                {
                    var vprecio = Convert.ToDouble(txtPrecio.Text);
                    InventarioDAO.crearNuevo(txtAñadirProducto.Text, txtDescrip.Text, vprecio);
                    
                    MessageBox.Show("Producto agregado exitosamente!", 
                        "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtNuevoEmpleado.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor digite un producto (longitud minima, 5 caracteres)", 
                        "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El producto que ha digitado, no se encuentra disponible.", 
                    "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       private void btnSave_Click(object sender, EventArgs e)
       {
           var idPrecio = Convert.ToDouble(txtPrice.Text);
            InventarioDAO.actualizarProducto(cmbProducts.Text, txtDescripcion.Text, idPrecio);
            //UsuarioDAO.actualizarPermisos(cmbUsuario.Text, radAdmin.Checked, radActivo.Checked);
            
            MessageBox.Show("¡Producto actualizado exitosamente!", 
                "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            actualizarControles();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al producto " + cmbProducts.Text + "?", 
                "Frutas y Verduras", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InventarioDAO.eliminarProducto(cmbProducts.Text);
                
                MessageBox.Show("¡Producto eliminado exitosamente!", 
                    "Frutas y Verduras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventario i = (Inventario) cmbProducts.SelectedItem;
        }

       
    }
}