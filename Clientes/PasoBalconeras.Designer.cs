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
            btn_DefinitAgujaBalPerfil = new Button();
            cmb_AgujaBalconeras = new ComboBox();
            rb_AgujaBalcPerfil = new RadioButton();
            rb_AgujaBalcGenerica = new RadioButton();
            group_PuertaSec = new GroupBox();
            group_AgujaPuertaSec = new GroupBox();
            cmb_AgujaPuertaSec = new ComboBox();
            btn_DefinirAgujaPuertaSecPerfil = new Button();
            rb_AgujaPuertaSecGenerica = new RadioButton();
            rb_AgujaPuertaSecPerfil = new RadioButton();
            group_Cerraduras = new GroupBox();
            dgvCerraduras = new DataGridView();
            pictureBox4 = new PictureBox();
            group_Bisagras = new GroupBox();
            dgvBisagras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Pasivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).BeginInit();
            group_Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).BeginInit();
            group_Comentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            group_Balconeras.SuspendLayout();
            group_Aguja.SuspendLayout();
            group_PuertaSec.SuspendLayout();
            group_AgujaPuertaSec.SuspendLayout();
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
            pictureBox1.Location = new Point(19, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // group_Pasivas
            // 
            group_Pasivas.Controls.Add(dgvPasivas);
            group_Pasivas.Location = new Point(662, 111);
            group_Pasivas.Margin = new Padding(3, 4, 3, 4);
            group_Pasivas.Name = "group_Pasivas";
            group_Pasivas.Padding = new Padding(3, 4, 3, 4);
            group_Pasivas.Size = new Size(330, 200);
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
            dgvPasivas.Location = new Point(19, 29);
            dgvPasivas.Margin = new Padding(3, 4, 3, 4);
            dgvPasivas.Name = "dgvPasivas";
            dgvPasivas.ReadOnly = true;
            dgvPasivas.RowHeadersWidth = 51;
            dgvPasivas.Size = new Size(289, 152);
            dgvPasivas.TabIndex = 2;
            dgvPasivas.CellMouseUp += dgvPasivas_CellMouseUp;
            // 
            // group_Seguridad
            // 
            group_Seguridad.Controls.Add(dgvSeguridad);
            group_Seguridad.Location = new Point(325, 111);
            group_Seguridad.Margin = new Padding(3, 4, 3, 4);
            group_Seguridad.Name = "group_Seguridad";
            group_Seguridad.Padding = new Padding(3, 4, 3, 4);
            group_Seguridad.Size = new Size(330, 200);
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
            dgvSeguridad.Location = new Point(19, 29);
            dgvSeguridad.Margin = new Padding(3, 4, 3, 4);
            dgvSeguridad.Name = "dgvSeguridad";
            dgvSeguridad.ReadOnly = true;
            dgvSeguridad.RowHeadersWidth = 51;
            dgvSeguridad.Size = new Size(293, 152);
            dgvSeguridad.TabIndex = 2;
            dgvSeguridad.CellMouseUp += dgvSeguridad_CellMouseUp;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesBalconeras);
            group_Comentarios.Location = new Point(23, 663);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(1010, 139);
            group_Comentarios.TabIndex = 11;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesBalconeras
            // 
            txt_ObservacionesBalconeras.Location = new Point(19, 29);
            txt_ObservacionesBalconeras.Margin = new Padding(3, 4, 3, 4);
            txt_ObservacionesBalconeras.MaxLength = 1000;
            txt_ObservacionesBalconeras.Multiline = true;
            txt_ObservacionesBalconeras.Name = "txt_ObservacionesBalconeras";
            txt_ObservacionesBalconeras.Size = new Size(972, 87);
            txt_ObservacionesBalconeras.TabIndex = 8;
            txt_ObservacionesBalconeras.TextChanged += txt_ObservacionesBalconeras_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(170, 29);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 281);
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
            group_Balconeras.Location = new Point(23, 7);
            group_Balconeras.Margin = new Padding(3, 4, 3, 4);
            group_Balconeras.Name = "group_Balconeras";
            group_Balconeras.Padding = new Padding(3, 4, 3, 4);
            group_Balconeras.Size = new Size(1010, 321);
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
            group_Aguja.Location = new Point(325, 23);
            group_Aguja.Margin = new Padding(3, 4, 3, 4);
            group_Aguja.Name = "group_Aguja";
            group_Aguja.Padding = new Padding(3, 4, 3, 4);
            group_Aguja.Size = new Size(667, 80);
            group_Aguja.TabIndex = 14;
            group_Aguja.TabStop = false;
            group_Aguja.Text = "Aguja";
            // 
            // btn_DefinitAgujaBalPerfil
            // 
            btn_DefinitAgujaBalPerfil.Image = (Image)resources.GetObject("btn_DefinitAgujaBalPerfil.Image");
            btn_DefinitAgujaBalPerfil.Location = new Point(525, 16);
            btn_DefinitAgujaBalPerfil.Margin = new Padding(3, 4, 3, 4);
            btn_DefinitAgujaBalPerfil.Name = "btn_DefinitAgujaBalPerfil";
            btn_DefinitAgujaBalPerfil.Size = new Size(55, 56);
            btn_DefinitAgujaBalPerfil.TabIndex = 4;
            btn_DefinitAgujaBalPerfil.UseVisualStyleBackColor = true;
            btn_DefinitAgujaBalPerfil.Click += btn_DefinitAgujaBalPerfil_Click;
            // 
            // cmb_AgujaBalconeras
            // 
            cmb_AgujaBalconeras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_AgujaBalconeras.FormattingEnabled = true;
            cmb_AgujaBalconeras.Location = new Point(146, 29);
            cmb_AgujaBalconeras.Margin = new Padding(3, 4, 3, 4);
            cmb_AgujaBalconeras.Name = "cmb_AgujaBalconeras";
            cmb_AgujaBalconeras.Size = new Size(165, 28);
            cmb_AgujaBalconeras.TabIndex = 0;
            cmb_AgujaBalconeras.SelectedValueChanged += cmb_AgujaBalconeras_SelectedValueChanged;
            // 
            // rb_AgujaBalcPerfil
            // 
            rb_AgujaBalcPerfil.AutoSize = true;
            rb_AgujaBalcPerfil.Location = new Point(358, 29);
            rb_AgujaBalcPerfil.Margin = new Padding(3, 4, 3, 4);
            rb_AgujaBalcPerfil.Name = "rb_AgujaBalcPerfil";
            rb_AgujaBalcPerfil.Size = new Size(90, 24);
            rb_AgujaBalcPerfil.TabIndex = 3;
            rb_AgujaBalcPerfil.TabStop = true;
            rb_AgujaBalcPerfil.Text = "Por perfil";
            rb_AgujaBalcPerfil.UseVisualStyleBackColor = true;
            rb_AgujaBalcPerfil.CheckedChanged += rb_AgujaBalcPerfil_CheckedChanged;
            // 
            // rb_AgujaBalcGenerica
            // 
            rb_AgujaBalcGenerica.AutoSize = true;
            rb_AgujaBalcGenerica.Location = new Point(26, 29);
            rb_AgujaBalcGenerica.Margin = new Padding(3, 4, 3, 4);
            rb_AgujaBalcGenerica.Name = "rb_AgujaBalcGenerica";
            rb_AgujaBalcGenerica.Size = new Size(70, 24);
            rb_AgujaBalcGenerica.TabIndex = 2;
            rb_AgujaBalcGenerica.TabStop = true;
            rb_AgujaBalcGenerica.Text = "Todos";
            rb_AgujaBalcGenerica.UseVisualStyleBackColor = true;
            rb_AgujaBalcGenerica.CheckedChanged += rb_AgujaBalcGenerica_CheckedChanged;
            // 
            // group_PuertaSec
            // 
            group_PuertaSec.Controls.Add(group_AgujaPuertaSec);
            group_PuertaSec.Controls.Add(group_Cerraduras);
            group_PuertaSec.Controls.Add(pictureBox4);
            group_PuertaSec.Controls.Add(group_Bisagras);
            group_PuertaSec.Location = new Point(23, 336);
            group_PuertaSec.Margin = new Padding(3, 4, 3, 4);
            group_PuertaSec.Name = "group_PuertaSec";
            group_PuertaSec.Padding = new Padding(3, 4, 3, 4);
            group_PuertaSec.Size = new Size(1010, 321);
            group_PuertaSec.TabIndex = 14;
            group_PuertaSec.TabStop = false;
            group_PuertaSec.Text = "Puerta Secundaria";
            // 
            // group_AgujaPuertaSec
            // 
            group_AgujaPuertaSec.Controls.Add(cmb_AgujaPuertaSec);
            group_AgujaPuertaSec.Controls.Add(btn_DefinirAgujaPuertaSecPerfil);
            group_AgujaPuertaSec.Controls.Add(rb_AgujaPuertaSecGenerica);
            group_AgujaPuertaSec.Controls.Add(rb_AgujaPuertaSecPerfil);
            group_AgujaPuertaSec.Location = new Point(325, 23);
            group_AgujaPuertaSec.Margin = new Padding(3, 4, 3, 4);
            group_AgujaPuertaSec.Name = "group_AgujaPuertaSec";
            group_AgujaPuertaSec.Padding = new Padding(3, 4, 3, 4);
            group_AgujaPuertaSec.Size = new Size(667, 79);
            group_AgujaPuertaSec.TabIndex = 14;
            group_AgujaPuertaSec.TabStop = false;
            group_AgujaPuertaSec.Text = "Aguja";
            // 
            // cmb_AgujaPuertaSec
            // 
            cmb_AgujaPuertaSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_AgujaPuertaSec.FormattingEnabled = true;
            cmb_AgujaPuertaSec.Location = new Point(146, 29);
            cmb_AgujaPuertaSec.Margin = new Padding(3, 4, 3, 4);
            cmb_AgujaPuertaSec.Name = "cmb_AgujaPuertaSec";
            cmb_AgujaPuertaSec.Size = new Size(165, 28);
            cmb_AgujaPuertaSec.TabIndex = 0;
            cmb_AgujaPuertaSec.SelectedValueChanged += cmb_AgujaPuertaSec_SelectedValueChanged;
            // 
            // btn_DefinirAgujaPuertaSecPerfil
            // 
            btn_DefinirAgujaPuertaSecPerfil.Image = (Image)resources.GetObject("btn_DefinirAgujaPuertaSecPerfil.Image");
            btn_DefinirAgujaPuertaSecPerfil.Location = new Point(525, 17);
            btn_DefinirAgujaPuertaSecPerfil.Margin = new Padding(3, 4, 3, 4);
            btn_DefinirAgujaPuertaSecPerfil.Name = "btn_DefinirAgujaPuertaSecPerfil";
            btn_DefinirAgujaPuertaSecPerfil.Size = new Size(55, 56);
            btn_DefinirAgujaPuertaSecPerfil.TabIndex = 7;
            btn_DefinirAgujaPuertaSecPerfil.UseVisualStyleBackColor = true;
            btn_DefinirAgujaPuertaSecPerfil.Click += btn_DefinirAgujaPuertaSecPerfil_Click;
            // 
            // rb_AgujaPuertaSecGenerica
            // 
            rb_AgujaPuertaSecGenerica.AutoSize = true;
            rb_AgujaPuertaSecGenerica.Location = new Point(26, 31);
            rb_AgujaPuertaSecGenerica.Margin = new Padding(3, 4, 3, 4);
            rb_AgujaPuertaSecGenerica.Name = "rb_AgujaPuertaSecGenerica";
            rb_AgujaPuertaSecGenerica.Size = new Size(70, 24);
            rb_AgujaPuertaSecGenerica.TabIndex = 5;
            rb_AgujaPuertaSecGenerica.TabStop = true;
            rb_AgujaPuertaSecGenerica.Text = "Todos";
            rb_AgujaPuertaSecGenerica.UseVisualStyleBackColor = true;
            rb_AgujaPuertaSecGenerica.CheckedChanged += rb_AgujaPuertaSecGenerica_CheckedChanged;
            // 
            // rb_AgujaPuertaSecPerfil
            // 
            rb_AgujaPuertaSecPerfil.AutoSize = true;
            rb_AgujaPuertaSecPerfil.Location = new Point(358, 31);
            rb_AgujaPuertaSecPerfil.Margin = new Padding(3, 4, 3, 4);
            rb_AgujaPuertaSecPerfil.Name = "rb_AgujaPuertaSecPerfil";
            rb_AgujaPuertaSecPerfil.Size = new Size(90, 24);
            rb_AgujaPuertaSecPerfil.TabIndex = 6;
            rb_AgujaPuertaSecPerfil.TabStop = true;
            rb_AgujaPuertaSecPerfil.Text = "Por perfil";
            rb_AgujaPuertaSecPerfil.UseVisualStyleBackColor = true;
            rb_AgujaPuertaSecPerfil.CheckedChanged += rb_AgujaPuertaSecPerfil_CheckedChanged;
            // 
            // group_Cerraduras
            // 
            group_Cerraduras.Controls.Add(dgvCerraduras);
            group_Cerraduras.Location = new Point(662, 105);
            group_Cerraduras.Margin = new Padding(3, 4, 3, 4);
            group_Cerraduras.Name = "group_Cerraduras";
            group_Cerraduras.Padding = new Padding(3, 4, 3, 4);
            group_Cerraduras.Size = new Size(330, 205);
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
            dgvCerraduras.Location = new Point(21, 29);
            dgvCerraduras.Margin = new Padding(3, 4, 3, 4);
            dgvCerraduras.Name = "dgvCerraduras";
            dgvCerraduras.ReadOnly = true;
            dgvCerraduras.RowHeadersWidth = 51;
            dgvCerraduras.Size = new Size(289, 168);
            dgvCerraduras.TabIndex = 2;
            dgvCerraduras.CellMouseUp += dgvCerraduras_CellMouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(89, 29);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 281);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // group_Bisagras
            // 
            group_Bisagras.Controls.Add(dgvBisagras);
            group_Bisagras.Location = new Point(325, 105);
            group_Bisagras.Margin = new Padding(3, 4, 3, 4);
            group_Bisagras.Name = "group_Bisagras";
            group_Bisagras.Padding = new Padding(3, 4, 3, 4);
            group_Bisagras.Size = new Size(330, 205);
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
            dgvBisagras.Location = new Point(19, 29);
            dgvBisagras.Margin = new Padding(3, 4, 3, 4);
            dgvBisagras.Name = "dgvBisagras";
            dgvBisagras.ReadOnly = true;
            dgvBisagras.RowHeadersWidth = 51;
            dgvBisagras.Size = new Size(293, 168);
            dgvBisagras.TabIndex = 2;
            dgvBisagras.CellMouseUp += dgvBisagras_CellMouseUp;
            // 
            // PasoBalconeras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(group_PuertaSec);
            Controls.Add(group_Balconeras);
            Controls.Add(group_Comentarios);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1081, 805);
            Name = "PasoBalconeras";
            Size = new Size(1081, 805);
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
            group_PuertaSec.ResumeLayout(false);
            group_AgujaPuertaSec.ResumeLayout(false);
            group_AgujaPuertaSec.PerformLayout();
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
        private GroupBox group_PuertaSec;
        private GroupBox group_AgujaPuertaSec;
        private ComboBox cmb_AgujaPuertaSec;
        private GroupBox group_Cerraduras;
        private DataGridView dgvCerraduras;
        private PictureBox pictureBox4;
        private GroupBox group_Bisagras;
        private DataGridView dgvBisagras;
        private RadioButton rb_AgujaBalcPerfil;
        private RadioButton rb_AgujaBalcGenerica;
        private Button btn_DefinitAgujaBalPerfil;
        private Button btn_DefinirAgujaPuertaSecPerfil;
        private RadioButton rb_AgujaPuertaSecGenerica;
        private RadioButton rb_AgujaPuertaSecPerfil;
    }
}
