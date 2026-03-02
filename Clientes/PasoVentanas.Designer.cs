namespace RotoGestionClientes
{
    partial class PasoVentanas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasoVentanas));
            pictureBox1 = new PictureBox();
            group_Seguridad = new GroupBox();
            dgvSeguridad = new DataGridView();
            group_Pasivas = new GroupBox();
            dgvPasivas = new DataGridView();
            group_Comentarios = new GroupBox();
            txt_Observaciones = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).BeginInit();
            group_Pasivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).BeginInit();
            group_Comentarios.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 156);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // group_Seguridad
            // 
            group_Seguridad.Controls.Add(dgvSeguridad);
            group_Seguridad.Location = new Point(296, 153);
            group_Seguridad.Name = "group_Seguridad";
            group_Seguridad.Size = new Size(289, 154);
            group_Seguridad.TabIndex = 4;
            group_Seguridad.TabStop = false;
            group_Seguridad.Text = "Seguridad";
            // 
            // dgvSeguridad
            // 
            dgvSeguridad.AllowUserToAddRows = false;
            dgvSeguridad.AllowUserToDeleteRows = false;
            dgvSeguridad.AllowUserToOrderColumns = true;
            dgvSeguridad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSeguridad.BackgroundColor = Color.White;
            dgvSeguridad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguridad.Location = new Point(17, 22);
            dgvSeguridad.Name = "dgvSeguridad";
            dgvSeguridad.ReadOnly = true;
            dgvSeguridad.Size = new Size(252, 115);
            dgvSeguridad.TabIndex = 2;
            dgvSeguridad.CellMouseUp += dgvSeguridad_CellMouseUp;
            // 
            // group_Pasivas
            // 
            group_Pasivas.Controls.Add(dgvPasivas);
            group_Pasivas.Location = new Point(609, 153);
            group_Pasivas.Name = "group_Pasivas";
            group_Pasivas.Size = new Size(289, 154);
            group_Pasivas.TabIndex = 5;
            group_Pasivas.TabStop = false;
            group_Pasivas.Text = "Cremona Pasiva";
            // 
            // dgvPasivas
            // 
            dgvPasivas.AllowUserToAddRows = false;
            dgvPasivas.AllowUserToDeleteRows = false;
            dgvPasivas.AllowUserToOrderColumns = true;
            dgvPasivas.Anchor = AnchorStyles.None;
            dgvPasivas.BackgroundColor = Color.White;
            dgvPasivas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasivas.Location = new Point(17, 28);
            dgvPasivas.Name = "dgvPasivas";
            dgvPasivas.ReadOnly = true;
            dgvPasivas.Size = new Size(254, 102);
            dgvPasivas.TabIndex = 2;
            dgvPasivas.CellMouseUp += dgvPasivas_CellMouseUp;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_Observaciones);
            group_Comentarios.Location = new Point(296, 334);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(601, 164);
            group_Comentarios.TabIndex = 10;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_Observaciones
            // 
            txt_Observaciones.Location = new Point(6, 22);
            txt_Observaciones.MaxLength = 1000;
            txt_Observaciones.Multiline = true;
            txt_Observaciones.Name = "txt_Observaciones";
            txt_Observaciones.Size = new Size(589, 136);
            txt_Observaciones.TabIndex = 8;
            txt_Observaciones.TextChanged += txt_Observaciones_TextChanged;
            // 
            // PasoVentanas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(group_Comentarios);
            Controls.Add(group_Pasivas);
            Controls.Add(group_Seguridad);
            Controls.Add(pictureBox1);
            Name = "PasoVentanas";
            Size = new Size(1008, 654);
            Load += PasoVentanas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).EndInit();
            group_Pasivas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox group_Seguridad;
        private DataGridView dgvSeguridad;
        private GroupBox group_Pasivas;
        private DataGridView dgvPasivas;
        private GroupBox group_Comentarios;
        private TextBox txt_Observaciones;
    }
}
