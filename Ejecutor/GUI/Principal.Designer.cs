namespace Inicial.GUI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseDatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPerfil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exprotar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Importar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.AllowUserToResizeColumns = false;
            this.dtgDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(23)))), ((int)(((byte)(44)))));
            this.dtgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDatos.BackgroundColor = System.Drawing.Color.White;
            this.dtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Perfil,
            this.Servidor,
            this.BaseDatos,
            this.Usuario,
            this.Contra,
            this.Puerto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDatos.GridColor = System.Drawing.Color.Silver;
            this.dtgDatos.Location = new System.Drawing.Point(0, 0);
            this.dtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDatos.MultiSelect = false;
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDatos.RowTemplate.Height = 24;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(875, 380);
            this.dtgDatos.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "cID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "cPerfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // Servidor
            // 
            this.Servidor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Servidor.DataPropertyName = "cServidor";
            this.Servidor.HeaderText = "Servidor";
            this.Servidor.Name = "Servidor";
            this.Servidor.ReadOnly = true;
            // 
            // BaseDatos
            // 
            this.BaseDatos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BaseDatos.DataPropertyName = "cBaseDatos";
            this.BaseDatos.HeaderText = "Base de Datos";
            this.BaseDatos.Name = "BaseDatos";
            this.BaseDatos.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.DataPropertyName = "cUsuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Contra
            // 
            this.Contra.DataPropertyName = "cContra";
            this.Contra.HeaderText = "Contraseña";
            this.Contra.Name = "Contra";
            this.Contra.ReadOnly = true;
            this.Contra.Visible = false;
            // 
            // Puerto
            // 
            this.Puerto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puerto.DataPropertyName = "cPuerto";
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(107, 24);
            this.btnPerfil.Text = "Agregar Perfil";
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 24);
            this.btnEditar.Text = "Editar Perfil";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 24);
            this.toolStripButton1.Text = "Eliminar Perfil";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Exprotar
            // 
            this.btn_Exprotar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exprotar.Image")));
            this.btn_Exprotar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exprotar.Name = "btn_Exprotar";
            this.btn_Exprotar.Size = new System.Drawing.Size(97, 24);
            this.btn_Exprotar.Text = "Exportar BD";
            this.btn_Exprotar.Click += new System.EventHandler(this.btn_Exprotar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Importar
            // 
            this.btn_Importar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Importar.Image")));
            this.btn_Importar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(99, 24);
            this.btn_Importar.Text = "Importar BD";
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfil,
            this.toolStripSeparator2,
            this.btnEditar,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btn_Exprotar,
            this.toolStripSeparator5,
            this.btn_Importar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgDatos);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 380);
            this.panel1.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Dump Operador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.ToolStripButton btnPerfil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Exprotar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_Importar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

