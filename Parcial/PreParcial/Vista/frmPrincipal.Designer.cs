using System.ComponentModel;

namespace ClaseGUI05
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.tabContenedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtNuevoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radInactivo = new System.Windows.Forms.RadioButton();
            this.radActivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radUsuario = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.btnActualizarProductos = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtAñadirProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.consultarPedidos1 = new ClaseGUI05.ConsultarPedidos();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.añadirPedido2 = new ClaseGUI05.AñadirPedido();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.pedidoPorCliente1 = new ClaseGUI05.PedidoPorCliente();
            this.tabContenedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProductos)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBienvenida.Location = new System.Drawing.Point(650, 90);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(1141, 63);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenidos a su centro de venta favorito!";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabContenedor
            // 
            this.tabContenedor.Controls.Add(this.tabPage1);
            this.tabContenedor.Controls.Add(this.tabPage2);
            this.tabContenedor.Controls.Add(this.tabPage3);
            this.tabContenedor.Controls.Add(this.tabPage4);
            this.tabContenedor.Controls.Add(this.tabPage5);
            this.tabContenedor.Controls.Add(this.tabPage6);
            this.tabContenedor.Controls.Add(this.tabPage8);
            this.tabContenedor.Controls.Add(this.tabPage9);
            this.tabContenedor.Controls.Add(this.tabPage10);
            this.tabContenedor.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tabContenedor.Location = new System.Drawing.Point(29, 229);
            this.tabContenedor.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabContenedor.Name = "tabContenedor";
            this.tabContenedor.SelectedIndex = 0;
            this.tabContenedor.Size = new System.Drawing.Size(2543, 1774);
            this.tabContenedor.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.tabPage1.Location = new System.Drawing.Point(10, 73);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabPage1.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(7, 1473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2509, 210);
            this.label3.TabIndex = 6;
            this.label3.Text = "Siempre tu mejor opción, los mejores precios del mercado! ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2509, 1463);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.dgvEmpleados);
            this.tabPage2.Controls.Add(this.btnCrearUsuario);
            this.tabPage2.Controls.Add(this.txtNuevoEmpleado);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(10, 73);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabPage2.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear usuarios";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.IndianRed;
            this.btnActualizar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar.Location = new System.Drawing.Point(1416, 1078);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(450, 161);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar datos";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(114, 268);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(1919, 794);
            this.dgvEmpleados.TabIndex = 9;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.AutoSize = true;
            this.btnCrearUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(1433, 116);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(292, 65);
            this.btnCrearUsuario.TabIndex = 8;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // txtNuevoEmpleado
            // 
            this.txtNuevoEmpleado.Location = new System.Drawing.Point(736, 138);
            this.txtNuevoEmpleado.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNuevoEmpleado.MaxLength = 25;
            this.txtNuevoEmpleado.Name = "txtNuevoEmpleado";
            this.txtNuevoEmpleado.Size = new System.Drawing.Size(568, 63);
            this.txtNuevoEmpleado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(279, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage3.Controls.Add(this.btnGuardar);
            this.tabPage3.Controls.Add(this.cmbUsuario);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(10, 73);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.IndianRed;
            this.btnGuardar.Location = new System.Drawing.Point(1472, 108);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(454, 85);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(822, 120);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(560, 64);
            this.cmbUsuario.TabIndex = 3;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Location = new System.Drawing.Point(1225, 969);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox3.Size = new System.Drawing.Size(955, 589);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar cuenta:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gold;
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(184, 130);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(500, 193);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(344, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 85);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.radInactivo);
            this.groupBox2.Controls.Add(this.radActivo);
            this.groupBox2.Location = new System.Drawing.Point(1225, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox2.Size = new System.Drawing.Size(955, 619);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurar activo o inactivo:";
            // 
            // radInactivo
            // 
            this.radInactivo.Location = new System.Drawing.Point(99, 230);
            this.radInactivo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radInactivo.Name = "radInactivo";
            this.radInactivo.Size = new System.Drawing.Size(469, 198);
            this.radInactivo.TabIndex = 3;
            this.radInactivo.Text = "Inactivo";
            this.radInactivo.UseVisualStyleBackColor = true;
            // 
            // radActivo
            // 
            this.radActivo.Checked = true;
            this.radActivo.Location = new System.Drawing.Point(109, 60);
            this.radActivo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radActivo.Name = "radActivo";
            this.radActivo.Size = new System.Drawing.Size(390, 148);
            this.radActivo.TabIndex = 2;
            this.radActivo.TabStop = true;
            this.radActivo.Text = "Activo";
            this.radActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radAdmin);
            this.groupBox1.Controls.Add(this.radUsuario);
            this.groupBox1.Location = new System.Drawing.Point(177, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Size = new System.Drawing.Size(912, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos de administrador:";
            // 
            // radAdmin
            // 
            this.radAdmin.Location = new System.Drawing.Point(70, 230);
            this.radAdmin.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(521, 157);
            this.radAdmin.TabIndex = 1;
            this.radAdmin.Text = "Administrador";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // radUsuario
            // 
            this.radUsuario.Checked = true;
            this.radUsuario.Location = new System.Drawing.Point(70, 60);
            this.radUsuario.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radUsuario.Name = "radUsuario";
            this.radUsuario.Size = new System.Drawing.Size(396, 116);
            this.radUsuario.TabIndex = 0;
            this.radUsuario.TabStop = true;
            this.radUsuario.Text = "Usuario";
            this.radUsuario.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage4.Location = new System.Drawing.Point(10, 73);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadisticas";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage5.Controls.Add(this.txtPrecio);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.txtDescrip);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.btnAñadirProducto);
            this.tabPage5.Controls.Add(this.btnActualizarProductos);
            this.tabPage5.Controls.Add(this.dgvProductos);
            this.tabPage5.Controls.Add(this.txtAñadirProducto);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(10, 73);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Añadir Productos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(701, 440);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(608, 63);
            this.txtPrecio.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(146, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(493, 116);
            this.label7.TabIndex = 8;
            this.label7.Text = "Precio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(701, 280);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(608, 63);
            this.txtDescrip.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(146, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(493, 116);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.BackColor = System.Drawing.Color.IndianRed;
            this.btnAñadirProducto.Location = new System.Drawing.Point(1563, 102);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(450, 127);
            this.btnAñadirProducto.TabIndex = 5;
            this.btnAñadirProducto.Text = "Añadir Producto\r\n";
            this.btnAñadirProducto.UseVisualStyleBackColor = false;
            this.btnAñadirProducto.Click += new System.EventHandler(this.btnAñadirProducto_Click);
            // 
            // btnActualizarProductos
            // 
            this.btnActualizarProductos.BackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarProductos.Location = new System.Drawing.Point(1706, 913);
            this.btnActualizarProductos.Name = "btnActualizarProductos";
            this.btnActualizarProductos.Size = new System.Drawing.Size(450, 127);
            this.btnActualizarProductos.TabIndex = 4;
            this.btnActualizarProductos.Text = "Actualizar Productos\r\n";
            this.btnActualizarProductos.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(124, 577);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 40;
            this.dgvProductos.Size = new System.Drawing.Size(1559, 671);
            this.dgvProductos.TabIndex = 3;
            // 
            // txtAñadirProducto
            // 
            this.txtAñadirProducto.Location = new System.Drawing.Point(701, 134);
            this.txtAñadirProducto.Name = "txtAñadirProducto";
            this.txtAñadirProducto.Size = new System.Drawing.Size(608, 63);
            this.txtAñadirProducto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(146, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(493, 116);
            this.label4.TabIndex = 0;
            this.label4.Text = "Producto\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.consultarPedidos1);
            this.tabPage6.Location = new System.Drawing.Point(10, 73);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage6.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Historial de Pedidos";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // consultarPedidos1
            // 
            this.consultarPedidos1.BackColor = System.Drawing.Color.OliveDrab;
            this.consultarPedidos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultarPedidos1.Location = new System.Drawing.Point(3, 3);
            this.consultarPedidos1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consultarPedidos1.Name = "consultarPedidos1";
            this.consultarPedidos1.Size = new System.Drawing.Size(2517, 1685);
            this.consultarPedidos1.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage8.Controls.Add(this.añadirPedido2);
            this.tabPage8.Location = new System.Drawing.Point(10, 73);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage8.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Realizar Compra";
            // 
            // añadirPedido2
            // 
            this.añadirPedido2.BackColor = System.Drawing.Color.OliveDrab;
            this.añadirPedido2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.añadirPedido2.Location = new System.Drawing.Point(3, 3);
            this.añadirPedido2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.añadirPedido2.Name = "añadirPedido2";
            this.añadirPedido2.Size = new System.Drawing.Size(2517, 1685);
            this.añadirPedido2.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage9.Controls.Add(this.label9);
            this.tabPage9.Controls.Add(this.label8);
            this.tabPage9.Controls.Add(this.groupBox4);
            this.tabPage9.Controls.Add(this.txtPrice);
            this.tabPage9.Controls.Add(this.txtDescripcion);
            this.tabPage9.Controls.Add(this.btnSave);
            this.tabPage9.Controls.Add(this.cmbProducts);
            this.tabPage9.Controls.Add(this.label5);
            this.tabPage9.Location = new System.Drawing.Point(10, 73);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage9.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Editar Productos";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(189, 668);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(407, 145);
            this.label9.TabIndex = 7;
            this.label9.Text = "Precio";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(189, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(407, 145);
            this.label8.TabIndex = 6;
            this.label8.Text = "Descripción";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminarProducto);
            this.groupBox4.Location = new System.Drawing.Point(1296, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(709, 462);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eliminar Producto";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Gold;
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarProducto.Location = new System.Drawing.Point(98, 138);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(518, 224);
            this.btnEliminarProducto.TabIndex = 0;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(136, 876);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(726, 63);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 552);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(726, 63);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.IndianRed;
            this.btnSave.Location = new System.Drawing.Point(1550, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(572, 98);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar cambios";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(748, 164);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(503, 64);
            this.cmbProducts.TabIndex = 1;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(189, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 145);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.pedidoPorCliente1);
            this.tabPage10.Location = new System.Drawing.Point(10, 73);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage10.Size = new System.Drawing.Size(2523, 1691);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Pedidos";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // pedidoPorCliente1
            // 
            this.pedidoPorCliente1.BackColor = System.Drawing.Color.OliveDrab;
            this.pedidoPorCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pedidoPorCliente1.Location = new System.Drawing.Point(3, 3);
            this.pedidoPorCliente1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pedidoPorCliente1.Name = "pedidoPorCliente1";
            this.pedidoPorCliente1.Size = new System.Drawing.Size(2517, 1685);
            this.pedidoPorCliente1.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(2668, 2108);
            this.Controls.Add(this.tabContenedor);
            this.Controls.Add(this.lblBienvenida);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos - Frutas y Verduras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabContenedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProductos)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoEmpleado;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TabControl tabContenedor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.RadioButton radUsuario;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radActivo;
        private System.Windows.Forms.RadioButton radInactivo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnActualizarProductos;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.TextBox txtAñadirProducto;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescrip;
        private ClaseGUI05.ConsultarPedidos consultarPedidos1;
        private ClaseGUI05.AñadirPedido añadirPedido2;
        private System.Windows.Forms.TabPage tabPage10;
        private ClaseGUI05.PedidoPorCliente pedidoPorCliente1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}