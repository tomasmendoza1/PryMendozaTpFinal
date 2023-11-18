namespace PryMendozaTpFinal
{
    partial class FrmCargarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.GroupBOx = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.GroupBOx.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBOx
            // 
            this.GroupBOx.Controls.Add(this.TxtCiudad);
            this.GroupBOx.Controls.Add(this.TxtDireccion);
            this.GroupBOx.Controls.Add(this.TxtApellido);
            this.GroupBOx.Controls.Add(this.LblCiudad);
            this.GroupBOx.Controls.Add(this.LblDireccion);
            this.GroupBOx.Controls.Add(this.LblApellido);
            this.GroupBOx.Controls.Add(this.LblNombre);
            this.GroupBOx.Controls.Add(this.TxtNombre);
            this.GroupBOx.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBOx.Location = new System.Drawing.Point(23, 12);
            this.GroupBOx.Name = "GroupBOx";
            this.GroupBOx.Size = new System.Drawing.Size(336, 216);
            this.GroupBOx.TabIndex = 7;
            this.GroupBOx.TabStop = false;
            this.GroupBOx.Text = "Datos personales";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(23, 234);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(336, 23);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(6, 32);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(59, 16);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(71, 29);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(196, 24);
            this.TxtNombre.TabIndex = 4;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(7, 82);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 16);
            this.LblApellido.TabIndex = 5;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(6, 130);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(64, 16);
            this.LblDireccion.TabIndex = 6;
            this.LblDireccion.Text = "Dirección:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(7, 174);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(51, 16);
            this.LblCiudad.TabIndex = 7;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(71, 79);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(196, 24);
            this.TxtApellido.TabIndex = 8;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(71, 127);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(196, 24);
            this.TxtDireccion.TabIndex = 9;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(71, 166);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(196, 24);
            this.TxtCiudad.TabIndex = 10;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(23, 292);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(336, 23);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(23, 263);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(336, 23);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FrmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 326);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GroupBOx);
            this.Name = "FrmCargarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Nuevo Registro";
            this.GroupBOx.ResumeLayout(false);
            this.GroupBOx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBOx;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnVolver;
    }
}