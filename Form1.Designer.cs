namespace PryMendozaTpFinal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblEstadoDeConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.DgvEmpleado = new System.Windows.Forms.DataGridView();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtFiltradoPorApellido = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GroupBOx = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnCargarDatos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).BeginInit();
            this.GroupBOx.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblEstadoDeConexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblEstadoDeConexion
            // 
            this.LblEstadoDeConexion.Name = "LblEstadoDeConexion";
            this.LblEstadoDeConexion.Size = new System.Drawing.Size(12, 17);
            this.LblEstadoDeConexion.Text = "-";
            // 
            // DgvEmpleado
            // 
            this.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleado.Location = new System.Drawing.Point(12, 71);
            this.DgvEmpleado.Name = "DgvEmpleado";
            this.DgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleado.Size = new System.Drawing.Size(552, 152);
            this.DgvEmpleado.TabIndex = 2;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(59, 44);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(215, 16);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Ingrese el apellido del cliente deseeado ";
            // 
            // TxtFiltradoPorApellido
            // 
            this.TxtFiltradoPorApellido.Location = new System.Drawing.Point(280, 44);
            this.TxtFiltradoPorApellido.Name = "TxtFiltradoPorApellido";
            this.TxtFiltradoPorApellido.Size = new System.Drawing.Size(196, 20);
            this.TxtFiltradoPorApellido.TabIndex = 4;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(62, 72);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(414, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // GroupBOx
            // 
            this.GroupBOx.Controls.Add(this.BtnBuscar);
            this.GroupBOx.Controls.Add(this.LblApellido);
            this.GroupBOx.Controls.Add(this.TxtFiltradoPorApellido);
            this.GroupBOx.Location = new System.Drawing.Point(12, 237);
            this.GroupBOx.Name = "GroupBOx";
            this.GroupBOx.Size = new System.Drawing.Size(552, 117);
            this.GroupBOx.TabIndex = 6;
            this.GroupBOx.TabStop = false;
            this.GroupBOx.Text = "Filtrado";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(552, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // BtnCargarDatos
            // 
            this.BtnCargarDatos.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarDatos.Location = new System.Drawing.Point(74, 389);
            this.BtnCargarDatos.Name = "BtnCargarDatos";
            this.BtnCargarDatos.Size = new System.Drawing.Size(414, 23);
            this.BtnCargarDatos.TabIndex = 8;
            this.BtnCargarDatos.Text = "Cargar nuevo registro";
            this.BtnCargarDatos.UseVisualStyleBackColor = true;
            this.BtnCargarDatos.Click += new System.EventHandler(this.BtnCargarDatos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar programa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCargarDatos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GroupBOx);
            this.Controls.Add(this.DgvEmpleado);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión - Módulo Recuros Humanos ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).EndInit();
            this.GroupBOx.ResumeLayout(false);
            this.GroupBOx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblEstadoDeConexion;
        private System.Windows.Forms.DataGridView DgvEmpleado;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtFiltradoPorApellido;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GroupBOx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnCargarDatos;
        private System.Windows.Forms.Button button1;
    }
}

