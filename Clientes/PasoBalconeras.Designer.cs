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
            rb_AgujaBalcPerfil = new RadioButton();
            rb_AgujaBalcGenerica = new RadioButton();
            cmb_AgujaBalconeras = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            cmb_AgujaPuertaSec = new ComboBox();
            group_Cerraduras = new GroupBox();
            dgvCerraduras = new DataGridView();
            pictureBox4 = new PictureBox();
            group_Bisagras = new GroupBox();
            dgvBisagras = new DataGridView();
            btn_DefinitAgujaBalPerfil = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Pasivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).BeginInit();
            group_Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).BeginInit();
            group_Comentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            group_Balconeras.SuspendLayout();
            group_Aguja.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            group_Cerraduras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCerraduras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            group_Bisagras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBisagras).BeginInit();
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
            group_Pasivas.Location = new Point(579, 116);
            group_Pasivas.Name = "group_Pasivas";
            group_Pasivas.Size = new Size(289, 117);
            group_Pasivas.TabIndex = 7;
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
            dgvPasivas.Location = new Point(18, 22);
            dgvPasivas.Name = "dgvPasivas";
            dgvPasivas.ReadOnly = true;
            dgvPasivas.Size = new Size(253, 81);
            dgvPasivas.TabIndex = 2;
            dgvPasivas.CellMouseUp += dgvPasivas_CellMouseUp;
            // 
            // group_Seguridad
            // 
            group_Seguridad.Controls.Add(dgvSeguridad);
            group_Seguridad.Location = new Point(284, 116);
            group_Seguridad.Name = "group_Seguridad";
            group_Seguridad.Size = new Size(289, 117);
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
            dgvSeguridad.Size = new Size(256, 81);
            dgvSeguridad.TabIndex = 2;
            dgvSeguridad.CellMouseUp += dgvSeguridad_CellMouseUp;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesBalconeras);
            group_Comentarios.Location = new Point(20, 507);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(884, 94);
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
            txt_ObservacionesBalconeras.Size = new Size(851, 66);
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
            group_Aguja.Controls.Add(btn_DefinitAgujaBalPerfil);
            group_Aguja.Controls.Add(cmb_AgujaBalconeras);
            group_Aguja.Controls.Add(rb_AgujaBalcPerfil);
            group_Aguja.Controls.Add(rb_AgujaBalcGenerica);
            group_Aguja.Location = new Point(284, 17);
            group_Aguja.Name = "group_Aguja";
            group_Aguja.Size = new Size(584, 60);
            group_Aguja.TabIndex = 14;
            group_Aguja.TabStop = false;
            group_Aguja.Text = "Aguja";
            // 
            // rb_AgujaBalcPerfil
            // 
            rb_AgujaBalcPerfil.AutoSize = true;
            rb_AgujaBalcPerfil.Location = new Point(313, 22);
            rb_AgujaBalcPerfil.Name = "rb_AgujaBalcPerfil";
            rb_AgujaBalcPerfil.Size = new Size(73, 19);
            rb_AgujaBalcPerfil.TabIndex = 3;
            rb_AgujaBalcPerfil.TabStop = true;
            rb_AgujaBalcPerfil.Text = "Por perfil";
            rb_AgujaBalcPerfil.UseVisualStyleBackColor = true;
            rb_AgujaBalcPerfil.CheckedChanged += rb_AgujaBalcPerfil_CheckedChanged;
            // 
            // rb_AgujaBalcGenerica
            // 
            rb_AgujaBalcGenerica.AutoSize = true;
            rb_AgujaBalcGenerica.Location = new Point(23, 22);
            rb_AgujaBalcGenerica.Name = "rb_AgujaBalcGenerica";
            rb_AgujaBalcGenerica.Size = new Size(56, 19);
            rb_AgujaBalcGenerica.TabIndex = 2;
            rb_AgujaBalcGenerica.TabStop = true;
            rb_AgujaBalcGenerica.Text = "Todos";
            rb_AgujaBalcGenerica.UseVisualStyleBackColor = true;
            rb_AgujaBalcGenerica.CheckedChanged += rb_AgujaBalcGenerica_CheckedChanged;
            // 
            // cmb_AgujaBalconeras
            // 
            cmb_AgujaBalconeras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_AgujaBalconeras.FormattingEnabled = true;
            cmb_AgujaBalconeras.Location = new Point(128, 22);
            cmb_AgujaBalconeras.Name = "cmb_AgujaBalconeras";
            cmb_AgujaBalconeras.Size = new Size(145, 23);
            cmb_AgujaBalconeras.TabIndex = 0;
            cmb_AgujaBalconeras.SelectedValueChanged += cmb_AgujaBalconeras_SelectedValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(group_Cerraduras);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(group_Bisagras);
            groupBox1.Location = new Point(20, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 241);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Puerta Secundaria";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(579, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 59);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aguja";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmb_AgujaPuertaSec);
            groupBox2.Location = new Point(284, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 59);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aguja";
            // 
            // cmb_AgujaPuertaSec
            // 
            cmb_AgujaPuertaSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_AgujaPuertaSec.FormattingEnabled = true;
            cmb_AgujaPuertaSec.Location = new Point(17, 22);
            cmb_AgujaPuertaSec.Name = "cmb_AgujaPuertaSec";
            cmb_AgujaPuertaSec.Size = new Size(256, 23);
            cmb_AgujaPuertaSec.TabIndex = 0;
            cmb_AgujaPuertaSec.SelectedValueChanged += cmb_AgujaPuertaSec_SelectedValueChanged;
            // 
            // group_Cerraduras
            // 
            group_Cerraduras.Controls.Add(dgvCerraduras);
            group_Cerraduras.Location = new Point(579, 79);
            group_Cerraduras.Name = "group_Cerraduras";
            group_Cerraduras.Size = new Size(289, 154);
            group_Cerraduras.TabIndex = 7;
            group_Cerraduras.TabStop = false;
            group_Cerraduras.Text = "Cerraduras";
            // 
            // dgvCerraduras
            // 
            dgvCerraduras.AllowUserToAddRows = false;
            dgvCerraduras.AllowUserToDeleteRows = false;
            dgvCerraduras.AllowUserToOrderColumns = true;
            dgvCerraduras.Anchor = AnchorStyles.None;
            dgvCerraduras.BackgroundColor = Color.White;
            dgvCerraduras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCerraduras.Location = new Point(18, 22);
            dgvCerraduras.Name = "dgvCerraduras";
            dgvCerraduras.ReadOnly = true;
            dgvCerraduras.Size = new Size(253, 126);
            dgvCerraduras.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(78, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 211);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // group_Bisagras
            // 
            group_Bisagras.Controls.Add(dgvBisagras);
            group_Bisagras.Location = new Point(284, 79);
            group_Bisagras.Name = "group_Bisagras";
            group_Bisagras.Size = new Size(289, 154);
            group_Bisagras.TabIndex = 6;
            group_Bisagras.TabStop = false;
            group_Bisagras.Text = "Bisagras";
            // 
            // dgvBisagras
            // 
            dgvBisagras.AllowUserToAddRows = false;
            dgvBisagras.AllowUserToDeleteRows = false;
            dgvBisagras.AllowUserToOrderColumns = true;
            dgvBisagras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBisagras.BackgroundColor = Color.White;
            dgvBisagras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBisagras.Location = new Point(17, 22);
            dgvBisagras.Name = "dgvBisagras";
            dgvBisagras.ReadOnly = true;
            dgvBisagras.Size = new Size(256, 126);
            dgvBisagras.TabIndex = 2;
            dgvBisagras.CellMouseUp += dgvBisagras_CellMouseUp;
            // 
            // btn_DefinitAgujaBalPerfil
            // 
            btn_DefinitAgujaBalPerfil.Image = (Image)resources.GetObject("btn_DefinitAgujaBalPerfil.Image");
            btn_DefinitAgujaBalPerfil.Location = new Point(459, 12);
            btn_DefinitAgujaBalPerfil.Name = "btn_DefinitAgujaBalPerfil";
            btn_DefinitAgujaBalPerfil.Size = new Size(48, 42);
            btn_DefinitAgujaBalPerfil.TabIndex = 4;
            btn_DefinitAgujaBalPerfil.UseVisualStyleBackColor = true;
            // 
            // PasoBalconeras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
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
            group_Aguja.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            group_Cerraduras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCerraduras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            group_Bisagras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBisagras).EndInit();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmb_AgujaPuertaSec;
        private GroupBox group_Cerraduras;
        private DataGridView dgvCerraduras;
        private PictureBox pictureBox4;
        private GroupBox group_Bisagras;
        private DataGridView dgvBisagras;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private RadioButton rb_AgujaBalcPerfil;
        private RadioButton rb_AgujaBalcGenerica;
        private Button btn_DefinitAgujaBalPerfil;
    }
}
