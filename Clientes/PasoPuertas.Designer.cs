namespace RotoGestionClientes
{
    partial class PasoPuertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasoPuertas));
            pictureBox1 = new PictureBox();
            group_Puertas = new GroupBox();
            group_Cilindros = new GroupBox();
            btn_Cilindros = new Button();
            rb_CilindrosSi = new RadioButton();
            rb_CilindrosNo = new RadioButton();
            group_Portero = new GroupBox();
            rb_PorteroSi = new RadioButton();
            rb_PorteroNo = new RadioButton();
            group_Aguja = new GroupBox();
            cmb_AgujaPuerta = new ComboBox();
            btn_DefinirAgujaPuertaPerfil = new Button();
            rb_AgujaPuertaGenerica = new RadioButton();
            rb_AgujaPuertaPerfil = new RadioButton();
            group_Cerraduras = new GroupBox();
            dgvCerraduras = new DataGridView();
            group_Bisagras = new GroupBox();
            dgvBisagras = new DataGridView();
            group_Comentarios = new GroupBox();
            txt_ObservacionesPuertas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Puertas.SuspendLayout();
            group_Cilindros.SuspendLayout();
            group_Portero.SuspendLayout();
            group_Aguja.SuspendLayout();
            group_Cerraduras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCerraduras).BeginInit();
            group_Bisagras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBisagras).BeginInit();
            group_Comentarios.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 77);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // group_Puertas
            // 
            group_Puertas.Controls.Add(group_Cilindros);
            group_Puertas.Controls.Add(group_Portero);
            group_Puertas.Controls.Add(group_Aguja);
            group_Puertas.Controls.Add(group_Cerraduras);
            group_Puertas.Controls.Add(pictureBox1);
            group_Puertas.Controls.Add(group_Bisagras);
            group_Puertas.Location = new Point(29, 4);
            group_Puertas.Margin = new Padding(3, 4, 3, 4);
            group_Puertas.Name = "group_Puertas";
            group_Puertas.Padding = new Padding(3, 4, 3, 4);
            group_Puertas.Size = new Size(1010, 613);
            group_Puertas.TabIndex = 16;
            group_Puertas.TabStop = false;
            group_Puertas.Text = "Puertas";
            // 
            // group_Cilindros
            // 
            group_Cilindros.Controls.Add(btn_Cilindros);
            group_Cilindros.Controls.Add(rb_CilindrosSi);
            group_Cilindros.Controls.Add(rb_CilindrosNo);
            group_Cilindros.Location = new Point(303, 164);
            group_Cilindros.Margin = new Padding(3, 4, 3, 4);
            group_Cilindros.Name = "group_Cilindros";
            group_Cilindros.Padding = new Padding(3, 4, 3, 4);
            group_Cilindros.Size = new Size(667, 79);
            group_Cilindros.TabIndex = 16;
            group_Cilindros.TabStop = false;
            group_Cilindros.Text = "Cilindros";
            // 
            // btn_Cilindros
            // 
            btn_Cilindros.Image = (Image)resources.GetObject("btn_Cilindros.Image");
            btn_Cilindros.Location = new Point(154, 15);
            btn_Cilindros.Margin = new Padding(3, 4, 3, 4);
            btn_Cilindros.Name = "btn_Cilindros";
            btn_Cilindros.Size = new Size(55, 56);
            btn_Cilindros.TabIndex = 8;
            btn_Cilindros.UseVisualStyleBackColor = true;
            btn_Cilindros.Click += btn_Cilindros_Click;
            // 
            // rb_CilindrosSi
            // 
            rb_CilindrosSi.AutoSize = true;
            rb_CilindrosSi.Location = new Point(26, 31);
            rb_CilindrosSi.Margin = new Padding(3, 4, 3, 4);
            rb_CilindrosSi.Name = "rb_CilindrosSi";
            rb_CilindrosSi.Size = new Size(42, 24);
            rb_CilindrosSi.TabIndex = 5;
            rb_CilindrosSi.TabStop = true;
            rb_CilindrosSi.Text = "Sí";
            rb_CilindrosSi.UseVisualStyleBackColor = true;
            rb_CilindrosSi.CheckedChanged += rb_CilindrosSi_CheckedChanged;
            // 
            // rb_CilindrosNo
            // 
            rb_CilindrosNo.AutoSize = true;
            rb_CilindrosNo.Location = new Point(358, 31);
            rb_CilindrosNo.Margin = new Padding(3, 4, 3, 4);
            rb_CilindrosNo.Name = "rb_CilindrosNo";
            rb_CilindrosNo.Size = new Size(50, 24);
            rb_CilindrosNo.TabIndex = 6;
            rb_CilindrosNo.TabStop = true;
            rb_CilindrosNo.Text = "No";
            rb_CilindrosNo.UseVisualStyleBackColor = true;
            rb_CilindrosNo.CheckedChanged += rb_CilindrosNo_CheckedChanged;
            // 
            // group_Portero
            // 
            group_Portero.Controls.Add(rb_PorteroSi);
            group_Portero.Controls.Add(rb_PorteroNo);
            group_Portero.Location = new Point(303, 29);
            group_Portero.Margin = new Padding(3, 4, 3, 4);
            group_Portero.Name = "group_Portero";
            group_Portero.Padding = new Padding(3, 4, 3, 4);
            group_Portero.Size = new Size(161, 40);
            group_Portero.TabIndex = 15;
            group_Portero.TabStop = false;
            group_Portero.Text = "Portero eléctrico";
            group_Portero.Visible = false;
            // 
            // rb_PorteroSi
            // 
            rb_PorteroSi.AutoSize = true;
            rb_PorteroSi.Location = new Point(18, 15);
            rb_PorteroSi.Margin = new Padding(3, 4, 3, 4);
            rb_PorteroSi.Name = "rb_PorteroSi";
            rb_PorteroSi.Size = new Size(42, 24);
            rb_PorteroSi.TabIndex = 5;
            rb_PorteroSi.TabStop = true;
            rb_PorteroSi.Text = "Sí";
            rb_PorteroSi.UseVisualStyleBackColor = true;
            rb_PorteroSi.CheckedChanged += rb_PorteroSi_CheckedChanged;
            // 
            // rb_PorteroNo
            // 
            rb_PorteroNo.AutoSize = true;
            rb_PorteroNo.Location = new Point(89, 15);
            rb_PorteroNo.Margin = new Padding(3, 4, 3, 4);
            rb_PorteroNo.Name = "rb_PorteroNo";
            rb_PorteroNo.Size = new Size(50, 24);
            rb_PorteroNo.TabIndex = 6;
            rb_PorteroNo.TabStop = true;
            rb_PorteroNo.Text = "No";
            rb_PorteroNo.UseVisualStyleBackColor = true;
            rb_PorteroNo.CheckedChanged += rb_PorteroNo_CheckedChanged;
            // 
            // group_Aguja
            // 
            group_Aguja.Controls.Add(cmb_AgujaPuerta);
            group_Aguja.Controls.Add(btn_DefinirAgujaPuertaPerfil);
            group_Aguja.Controls.Add(rb_AgujaPuertaGenerica);
            group_Aguja.Controls.Add(rb_AgujaPuertaPerfil);
            group_Aguja.Location = new Point(303, 77);
            group_Aguja.Margin = new Padding(3, 4, 3, 4);
            group_Aguja.Name = "group_Aguja";
            group_Aguja.Padding = new Padding(3, 4, 3, 4);
            group_Aguja.Size = new Size(667, 79);
            group_Aguja.TabIndex = 14;
            group_Aguja.TabStop = false;
            group_Aguja.Text = "Aguja";
            // 
            // cmb_AgujaPuerta
            // 
            cmb_AgujaPuerta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_AgujaPuerta.FormattingEnabled = true;
            cmb_AgujaPuerta.Location = new Point(119, 29);
            cmb_AgujaPuerta.Margin = new Padding(3, 4, 3, 4);
            cmb_AgujaPuerta.Name = "cmb_AgujaPuerta";
            cmb_AgujaPuerta.Size = new Size(165, 28);
            cmb_AgujaPuerta.TabIndex = 0;
            cmb_AgujaPuerta.SelectedValueChanged += cmb_AgujaPuerta_SelectedValueChanged;
            // 
            // btn_DefinirAgujaPuertaPerfil
            // 
            btn_DefinirAgujaPuertaPerfil.Image = (Image)resources.GetObject("btn_DefinirAgujaPuertaPerfil.Image");
            btn_DefinirAgujaPuertaPerfil.Location = new Point(525, 17);
            btn_DefinirAgujaPuertaPerfil.Margin = new Padding(3, 4, 3, 4);
            btn_DefinirAgujaPuertaPerfil.Name = "btn_DefinirAgujaPuertaPerfil";
            btn_DefinirAgujaPuertaPerfil.Size = new Size(55, 56);
            btn_DefinirAgujaPuertaPerfil.TabIndex = 7;
            btn_DefinirAgujaPuertaPerfil.UseVisualStyleBackColor = true;
            btn_DefinirAgujaPuertaPerfil.Click += btn_DefinirAgujaPuertaPerfil_Click;
            // 
            // rb_AgujaPuertaGenerica
            // 
            rb_AgujaPuertaGenerica.AutoSize = true;
            rb_AgujaPuertaGenerica.Location = new Point(26, 31);
            rb_AgujaPuertaGenerica.Margin = new Padding(3, 4, 3, 4);
            rb_AgujaPuertaGenerica.Name = "rb_AgujaPuertaGenerica";
            rb_AgujaPuertaGenerica.Size = new Size(70, 24);
            rb_AgujaPuertaGenerica.TabIndex = 5;
            rb_AgujaPuertaGenerica.TabStop = true;
            rb_AgujaPuertaGenerica.Text = "Todos";
            rb_AgujaPuertaGenerica.UseVisualStyleBackColor = true;
            rb_AgujaPuertaGenerica.CheckedChanged += rb_AgujaPuertaGenerica_CheckedChanged;
            // 
            // rb_AgujaPuertaPerfil
            // 
            rb_AgujaPuertaPerfil.AutoSize = true;
            rb_AgujaPuertaPerfil.Location = new Point(358, 31);
            rb_AgujaPuertaPerfil.Margin = new Padding(3, 4, 3, 4);
            rb_AgujaPuertaPerfil.Name = "rb_AgujaPuertaPerfil";
            rb_AgujaPuertaPerfil.Size = new Size(90, 24);
            rb_AgujaPuertaPerfil.TabIndex = 6;
            rb_AgujaPuertaPerfil.TabStop = true;
            rb_AgujaPuertaPerfil.Text = "Por perfil";
            rb_AgujaPuertaPerfil.UseVisualStyleBackColor = true;
            rb_AgujaPuertaPerfil.CheckedChanged += rb_AgujaPuertaPerfil_CheckedChanged;
            // 
            // group_Cerraduras
            // 
            group_Cerraduras.Controls.Add(dgvCerraduras);
            group_Cerraduras.Location = new Point(640, 259);
            group_Cerraduras.Margin = new Padding(3, 4, 3, 4);
            group_Cerraduras.Name = "group_Cerraduras";
            group_Cerraduras.Padding = new Padding(3, 4, 3, 4);
            group_Cerraduras.Size = new Size(330, 297);
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
            dgvCerraduras.Location = new Point(7, 29);
            dgvCerraduras.Margin = new Padding(3, 4, 3, 4);
            dgvCerraduras.Name = "dgvCerraduras";
            dgvCerraduras.ReadOnly = true;
            dgvCerraduras.RowHeadersWidth = 51;
            dgvCerraduras.Size = new Size(317, 260);
            dgvCerraduras.TabIndex = 2;
            dgvCerraduras.CellMouseUp += dgvCerraduras_CellMouseUp;
            // 
            // group_Bisagras
            // 
            group_Bisagras.Controls.Add(dgvBisagras);
            group_Bisagras.Location = new Point(303, 259);
            group_Bisagras.Margin = new Padding(3, 4, 3, 4);
            group_Bisagras.Name = "group_Bisagras";
            group_Bisagras.Padding = new Padding(3, 4, 3, 4);
            group_Bisagras.Size = new Size(330, 297);
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
            dgvBisagras.Location = new Point(7, 29);
            dgvBisagras.Margin = new Padding(3, 4, 3, 4);
            dgvBisagras.Name = "dgvBisagras";
            dgvBisagras.ReadOnly = true;
            dgvBisagras.RowHeadersWidth = 51;
            dgvBisagras.Size = new Size(317, 260);
            dgvBisagras.TabIndex = 2;
            dgvBisagras.CellMouseUp += dgvBisagras_CellMouseUp;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesPuertas);
            group_Comentarios.Location = new Point(29, 625);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(1010, 139);
            group_Comentarios.TabIndex = 15;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesPuertas
            // 
            txt_ObservacionesPuertas.Location = new Point(19, 29);
            txt_ObservacionesPuertas.Margin = new Padding(3, 4, 3, 4);
            txt_ObservacionesPuertas.MaxLength = 1000;
            txt_ObservacionesPuertas.Multiline = true;
            txt_ObservacionesPuertas.Name = "txt_ObservacionesPuertas";
            txt_ObservacionesPuertas.Size = new Size(972, 87);
            txt_ObservacionesPuertas.TabIndex = 8;
            txt_ObservacionesPuertas.TextChanged += txt_ObservacionesPuertas_TextChanged;
            // 
            // PasoPuertas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(group_Puertas);
            Controls.Add(group_Comentarios);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1081, 805);
            Name = "PasoPuertas";
            Size = new Size(1081, 805);
            Load += PasoPuertas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Puertas.ResumeLayout(false);
            group_Cilindros.ResumeLayout(false);
            group_Cilindros.PerformLayout();
            group_Portero.ResumeLayout(false);
            group_Portero.PerformLayout();
            group_Aguja.ResumeLayout(false);
            group_Aguja.PerformLayout();
            group_Cerraduras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCerraduras).EndInit();
            group_Bisagras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBisagras).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox group_Puertas;
        private GroupBox group_Aguja;
        private ComboBox cmb_AgujaPuerta;
        private Button btn_DefinirAgujaPuertaPerfil;
        private RadioButton rb_AgujaPuertaGenerica;
        private RadioButton rb_AgujaPuertaPerfil;
        private GroupBox group_Cerraduras;
        private DataGridView dgvCerraduras;
        private GroupBox group_Bisagras;
        private DataGridView dgvBisagras;
        private GroupBox group_Comentarios;
        private TextBox txt_ObservacionesPuertas;
        private GroupBox group_Cilindros;
        private RadioButton rb_CilindrosSi;
        private RadioButton rb_CilindrosNo;
        private GroupBox group_Portero;
        private RadioButton rb_PorteroSi;
        private RadioButton rb_PorteroNo;
        private Button btn_Cilindros;
    }
}
