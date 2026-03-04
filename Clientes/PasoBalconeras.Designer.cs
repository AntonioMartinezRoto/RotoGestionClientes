namespace RotoGestionClientes
{
    partial class PasoBalconeras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasoBalconeras));
            pictureBox1 = new PictureBox();
            group_Pasivas = new GroupBox();
            dgvPasivas = new DataGridView();
            group_Seguridad = new GroupBox();
            dgvSeguridad = new DataGridView();
            group_Comentarios = new GroupBox();
            txt_ObservacionesBalconeras = new TextBox();
            pictureBox2 = new PictureBox();
            group_Balconeras = new GroupBox();
            group_Aguja = new GroupBox();
            cmb_AgujaBalconeras = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Pasivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).BeginInit();
            group_Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).BeginInit();
            group_Comentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            group_Balconeras.SuspendLayout();
            group_Aguja.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // group_Pasivas
            // 
            group_Pasivas.Controls.Add(dgvPasivas);
            group_Pasivas.Location = new Point(579, 79);
            group_Pasivas.Name = "group_Pasivas";
            group_Pasivas.Size = new Size(289, 154);
            group_Pasivas.TabIndex = 7;
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
            dgvPasivas.Location = new Point(18, 22);
            dgvPasivas.Name = "dgvPasivas";
            dgvPasivas.ReadOnly = true;
            dgvPasivas.Size = new Size(253, 118);
            dgvPasivas.TabIndex = 2;
            // 
            // group_Seguridad
            // 
            group_Seguridad.Controls.Add(dgvSeguridad);
            group_Seguridad.Location = new Point(284, 79);
            group_Seguridad.Name = "group_Seguridad";
            group_Seguridad.Size = new Size(289, 154);
            group_Seguridad.TabIndex = 6;
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
            dgvSeguridad.Size = new Size(256, 118);
            dgvSeguridad.TabIndex = 2;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesBalconeras);
            group_Comentarios.Location = new Point(20, 497);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(905, 104);
            group_Comentarios.TabIndex = 11;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesBalconeras
            // 
            txt_ObservacionesBalconeras.Location = new Point(17, 22);
            txt_ObservacionesBalconeras.MaxLength = 1000;
            txt_ObservacionesBalconeras.Multiline = true;
            txt_ObservacionesBalconeras.Name = "txt_ObservacionesBalconeras";
            txt_ObservacionesBalconeras.Size = new Size(870, 66);
            txt_ObservacionesBalconeras.TabIndex = 8;
            txt_ObservacionesBalconeras.TextChanged += txt_ObservacionesBalconeras_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(149, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // group_Balconeras
            // 
            group_Balconeras.Controls.Add(group_Aguja);
            group_Balconeras.Controls.Add(group_Pasivas);
            group_Balconeras.Controls.Add(pictureBox2);
            group_Balconeras.Controls.Add(pictureBox1);
            group_Balconeras.Controls.Add(group_Seguridad);
            group_Balconeras.Location = new Point(20, 13);
            group_Balconeras.Name = "group_Balconeras";
            group_Balconeras.Size = new Size(884, 241);
            group_Balconeras.TabIndex = 13;
            group_Balconeras.TabStop = false;
            group_Balconeras.Text = "Balconeras";
            // 
            // group_Aguja
            // 
            group_Aguja.Controls.Add(cmb_AgujaBalconeras);
            group_Aguja.Location = new Point(284, 17);
            group_Aguja.Name = "group_Aguja";
            group_Aguja.Size = new Size(289, 59);
            group_Aguja.TabIndex = 14;
            group_Aguja.TabStop = false;
            group_Aguja.Text = "Aguja";
            // 
            // cmb_AgujaBalconeras
            // 
            cmb_AgujaBalconeras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_AgujaBalconeras.FormattingEnabled = true;
            cmb_AgujaBalconeras.Location = new Point(17, 22);
            cmb_AgujaBalconeras.Name = "cmb_AgujaBalconeras";
            cmb_AgujaBalconeras.Size = new Size(250, 23);
            cmb_AgujaBalconeras.TabIndex = 0;
            cmb_AgujaBalconeras.SelectedValueChanged += cmb_AgujaBalconeras_SelectedValueChanged;
            // 
            // PasoBalconeras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(group_Balconeras);
            Controls.Add(group_Comentarios);
            Name = "PasoBalconeras";
            Size = new Size(946, 604);
            Load += PasoBalconeras_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Pasivas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).EndInit();
            group_Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            group_Balconeras.ResumeLayout(false);
            group_Aguja.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox group_Pasivas;
        private DataGridView dgvPasivas;
        private GroupBox group_Seguridad;
        private DataGridView dgvSeguridad;
        private GroupBox group_Comentarios;
        private TextBox txt_ObservacionesBalconeras;
        private PictureBox pictureBox2;
        private GroupBox group_Balconeras;
        private GroupBox group_Aguja;
        private ComboBox cmb_AgujaBalconeras;
    }
}
