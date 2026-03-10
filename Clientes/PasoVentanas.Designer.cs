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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            dgvPasivasPract = new DataGridView();
            pictureBox4 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).BeginInit();
            group_Pasivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).BeginInit();
            group_Comentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivasPract).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // group_Seguridad
            // 
            group_Seguridad.Controls.Add(dgvSeguridad);
            group_Seguridad.Location = new Point(622, 33);
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
            dgvSeguridad.Size = new Size(252, 113);
            dgvSeguridad.TabIndex = 2;
            dgvSeguridad.CellMouseUp += dgvSeguridad_CellMouseUp;
            // 
            // group_Pasivas
            // 
            group_Pasivas.Controls.Add(dgvPasivas);
            group_Pasivas.Location = new Point(321, 33);
            group_Pasivas.Name = "group_Pasivas";
            group_Pasivas.Size = new Size(289, 154);
            group_Pasivas.TabIndex = 5;
            group_Pasivas.TabStop = false;
            group_Pasivas.Text = "Hoja Pasiva";
            // 
            // dgvPasivas
            // 
            dgvPasivas.AllowUserToAddRows = false;
            dgvPasivas.AllowUserToDeleteRows = false;
            dgvPasivas.AllowUserToOrderColumns = true;
            dgvPasivas.Anchor = AnchorStyles.None;
            dgvPasivas.BackgroundColor = Color.White;
            dgvPasivas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasivas.Location = new Point(17, 22);
            dgvPasivas.Name = "dgvPasivas";
            dgvPasivas.ReadOnly = true;
            dgvPasivas.RowHeadersVisible = false;
            dgvPasivas.Size = new Size(254, 115);
            dgvPasivas.TabIndex = 2;
            dgvPasivas.CellMouseUp += dgvPasivas_CellMouseUp;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_Observaciones);
            group_Comentarios.Location = new Point(18, 472);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(916, 104);
            group_Comentarios.TabIndex = 10;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_Observaciones
            // 
            txt_Observaciones.Location = new Point(17, 22);
            txt_Observaciones.MaxLength = 1000;
            txt_Observaciones.Multiline = true;
            txt_Observaciones.Name = "txt_Observaciones";
            txt_Observaciones.Size = new Size(888, 66);
            txt_Observaciones.TabIndex = 8;
            txt_Observaciones.TextChanged += txt_Observaciones_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 156);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPasivasPract);
            groupBox1.Location = new Point(317, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 154);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hoja Pasiva";
            // 
            // dgvPasivasPract
            // 
            dgvPasivasPract.AllowUserToAddRows = false;
            dgvPasivasPract.AllowUserToDeleteRows = false;
            dgvPasivasPract.AllowUserToOrderColumns = true;
            dgvPasivasPract.Anchor = AnchorStyles.None;
            dgvPasivasPract.BackgroundColor = Color.White;
            dgvPasivasPract.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasivasPract.Location = new Point(17, 22);
            dgvPasivasPract.Name = "dgvPasivasPract";
            dgvPasivasPract.ReadOnly = true;
            dgvPasivasPract.Size = new Size(254, 116);
            dgvPasivasPract.TabIndex = 2;
            dgvPasivasPract.CellMouseUp += dgvPasivasPract_CellMouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(138, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(156, 156);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(group_Seguridad);
            groupBox2.Controls.Add(group_Pasivas);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(12, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(922, 206);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oscilobatientes";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Location = new Point(12, 235);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(922, 206);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Practicables";
            // 
            // PasoVentanas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(group_Comentarios);
            Name = "PasoVentanas";
            Size = new Size(946, 604);
            Load += PasoVentanas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).EndInit();
            group_Pasivas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasivasPract).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private DataGridView dgvPasivasPract;
        private PictureBox pictureBox4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
