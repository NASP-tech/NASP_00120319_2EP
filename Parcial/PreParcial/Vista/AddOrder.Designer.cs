using System.ComponentModel;

namespace ClaseGUI05
{
    partial class AddOrder
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.btnCheckOrderHistory = new System.Windows.Forms.Button();
            this.dgvCheckOrderHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCheckOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddOrder, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckOrderHistory, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvCheckOrderHistory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbOrder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2196, 1558);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(3, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 311);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(3, 622);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(652, 311);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddOrder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddOrder, 2);
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddOrder.Location = new System.Drawing.Point(3, 936);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(2190, 305);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(1046, 753);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(762, 49);
            this.cmbOrder.TabIndex = 7;
            // 
            // cmbAddress
            // 
            this.cmbAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(1040, 442);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(774, 49);
            this.cmbAddress.TabIndex = 8;
            // 
            // btnCheckOrderHistory
            // 
            this.btnCheckOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckOrderHistory.Font = new System.Drawing.Font("Comic Sans MS", 12F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCheckOrderHistory.Location = new System.Drawing.Point(3, 1247);
            this.btnCheckOrderHistory.Name = "btnCheckOrderHistory";
            this.btnCheckOrderHistory.Size = new System.Drawing.Size(652, 308);
            this.btnCheckOrderHistory.TabIndex = 9;
            this.btnCheckOrderHistory.Text = "Check Order History";
            this.btnCheckOrderHistory.UseVisualStyleBackColor = true;
            this.btnCheckOrderHistory.Click += new System.EventHandler(this.btnCheckOrderHistory_Click);
            // 
            // dgvCheckOrderHistory
            // 
            this.dgvCheckOrderHistory.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckOrderHistory.Location = new System.Drawing.Point(661, 1247);
            this.dgvCheckOrderHistory.Name = "dgvCheckOrderHistory";
            this.dgvCheckOrderHistory.RowTemplate.Height = 40;
            this.dgvCheckOrderHistory.Size = new System.Drawing.Size(1532, 308);
            this.dgvCheckOrderHistory.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 311);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Location = new System.Drawing.Point(1138, 132);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(578, 47);
            this.txtUser.TabIndex = 12;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(2196, 1558);
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCheckOrderHistory)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Button btnCheckOrderHistory;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dgvCheckOrderHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
    }
}