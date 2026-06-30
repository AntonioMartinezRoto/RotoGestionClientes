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
            group_PasivaPracticables = new GroupBox();
            dgvPasivasPract = new DataGridView();
            pictureBox4 = new PictureBox();
            group_Oscilobatientes = new GroupBox();
            pictureBox5 = new PictureBox();
            group_Practicables = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).BeginInit();
            group_Pasivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).BeginInit();
            group_Comentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            group_PasivaPracticables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivasPract).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            group_Oscilobatientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            group_Practicables.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 41);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // group_Seguridad
            // 
            group_Seguridad.Controls.Add(dgvSeguridad);
            group_Seguridad.Location = new Point(815, 41);
            group_Seguridad.Margin = new Padding(3, 4, 3, 4);
            group_Seguridad.Name = "group_Seguridad";
            group_Seguridad.Padding = new Padding(3, 4, 3, 4);
            group_Seguridad.Size = new Size(211, 205);
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
            dgvSeguridad.Location = new Point(19, 29);
            dgvSeguridad.Margin = new Padding(3, 4, 3, 4);
            dgvSeguridad.Name = "dgvSeguridad";
            dgvSeguridad.ReadOnly = true;
            dgvSeguridad.RowHeadersWidth = 51;
            dgvSeguridad.Size = new Size(173, 153);
            dgvSeguridad.TabIndex = 2;
            dgvSeguridad.CellMouseUp += dgvSeguridad_CellMouseUp;
            // 
            // group_Pasivas
            // 
            group_Pasivas.Controls.Add(dgvPasivas);
            group_Pasivas.Location = new Point(575, 41);
            group_Pasivas.Margin = new Padding(3, 4, 3, 4);
            group_Pasivas.Name = "group_Pasivas";
            group_Pasivas.Padding = new Padding(3, 4, 3, 4);
            group_Pasivas.Size = new Size(211, 205);
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
            dgvPasivas.Location = new Point(19, 29);
            dgvPasivas.Margin = new Padding(3, 4, 3, 4);
            dgvPasivas.Name = "dgvPasivas";
            dgvPasivas.ReadOnly = true;
            dgvPasivas.RowHeadersVisible = false;
            dgvPasivas.RowHeadersWidth = 51;
            dgvPasivas.Size = new Size(173, 153);
            dgvPasivas.TabIndex = 2;
            dgvPasivas.CellMouseUp += dgvPasivas_CellMouseUp;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_Observaciones);
            group_Comentarios.Location = new Point(21, 629);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(1047, 139);
            group_Comentarios.TabIndex = 10;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_Observaciones
            // 
            txt_Observaciones.Location = new Point(19, 29);
            txt_Observaciones.Margin = new Padding(3, 4, 3, 4);
            txt_Observaciones.MaxLength = 1000;
            txt_Observaciones.Multiline = true;
            txt_Observaciones.Name = "txt_Observaciones";
            txt_Observaciones.Size = new Size(1014, 87);
            txt_Observaciones.TabIndex = 8;
            txt_Observaciones.TextChanged += txt_Observaciones_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 41);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 208);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 41);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(119, 208);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // group_PasivaPracticables
            // 
            group_PasivaPracticables.Controls.Add(dgvPasivasPract);
            group_PasivaPracticables.Location = new Point(362, 29);
            group_PasivaPracticables.Margin = new Padding(3, 4, 3, 4);
            group_PasivaPracticables.Name = "group_PasivaPracticables";
            group_PasivaPracticables.Padding = new Padding(3, 4, 3, 4);
            group_PasivaPracticables.Size = new Size(330, 205);
            group_PasivaPracticables.TabIndex = 14;
            group_PasivaPracticables.TabStop = false;
            group_PasivaPracticables.Text = "Hoja Pasiva";
            // 
            // dgvPasivasPract
            // 
            dgvPasivasPract.AllowUserToAddRows = false;
            dgvPasivasPract.AllowUserToDeleteRows = false;
            dgvPasivasPract.AllowUserToOrderColumns = true;
            dgvPasivasPract.Anchor = AnchorStyles.None;
            dgvPasivasPract.BackgroundColor = Color.White;
            dgvPasivasPract.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasivasPract.Location = new Point(19, 29);
            dgvPasivasPract.Margin = new Padding(3, 4, 3, 4);
            dgvPasivasPract.Name = "dgvPasivasPract";
            dgvPasivasPract.ReadOnly = true;
            dgvPasivasPract.RowHeadersWidth = 51;
            dgvPasivasPract.Size = new Size(290, 155);
            dgvPasivasPract.TabIndex = 2;
            dgvPasivasPract.CellMouseUp += dgvPasivasPract_CellMouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(158, 41);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(178, 208);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // group_Oscilobatientes
            // 
            group_Oscilobatientes.Controls.Add(pictureBox5);
            group_Oscilobatientes.Controls.Add(group_Seguridad);
            group_Oscilobatientes.Controls.Add(group_Pasivas);
            group_Oscilobatientes.Controls.Add(pictureBox1);
            group_Oscilobatientes.Controls.Add(pictureBox2);
            group_Oscilobatientes.Location = new Point(14, 20);
            group_Oscilobatientes.Margin = new Padding(3, 4, 3, 4);
            group_Oscilobatientes.Name = "group_Oscilobatientes";
            group_Oscilobatientes.Padding = new Padding(3, 4, 3, 4);
            group_Oscilobatientes.Size = new Size(1054, 275);
            group_Oscilobatientes.TabIndex = 16;
            group_Oscilobatientes.TabStop = false;
            group_Oscilobatientes.Text = "Oscilobatientes";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(362, 41);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(178, 208);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // group_Practicables
            // 
            group_Practicables.Controls.Add(group_PasivaPracticables);
            group_Practicables.Controls.Add(pictureBox3);
            group_Practicables.Controls.Add(pictureBox4);
            group_Practicables.Location = new Point(14, 313);
            group_Practicables.Margin = new Padding(3, 4, 3, 4);
            group_Practicables.Name = "group_Practicables";
            group_Practicables.Padding = new Padding(3, 4, 3, 4);
            group_Practicables.Size = new Size(1054, 275);
            group_Practicables.TabIndex = 17;
            group_Practicables.TabStop = false;
            group_Practicables.Text = "Practicables";
            // 
            // PasoVentanas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(group_Practicables);
            Controls.Add(group_Oscilobatientes);
            Controls.Add(group_Comentarios);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1081, 805);
            Name = "PasoVentanas";
            Size = new Size(1081, 805);
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
            group_PasivaPracticables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasivasPract).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            group_Oscilobatientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            group_Practicables.ResumeLayout(false);
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
        private GroupBox group_PasivaPracticables;
        private DataGridView dgvPasivasPract;
        private PictureBox pictureBox4;
        private GroupBox group_Oscilobatientes;
        private GroupBox group_Practicables;
        private PictureBox pictureBox5;
    }
}
