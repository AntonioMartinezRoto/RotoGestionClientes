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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            btn_Cilindros = new Button();
            rb_CilindrosSi = new RadioButton();
            rb_CilindrosNo = new RadioButton();
            groupBox3 = new GroupBox();
            rb_PorteroSi = new RadioButton();
            rb_PorteroNo = new RadioButton();
            groupBox2 = new GroupBox();
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
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
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
            pictureBox1.Location = new Point(41, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(group_Cerraduras);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(group_Bisagras);
            groupBox1.Location = new Point(25, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 460);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Puertas";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_Cilindros);
            groupBox4.Controls.Add(rb_CilindrosSi);
            groupBox4.Controls.Add(rb_CilindrosNo);
            groupBox4.Location = new Point(284, 159);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(584, 59);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Cilindros";
            // 
            // btn_Cilindros
            // 
            btn_Cilindros.Image = (Image)resources.GetObject("btn_Cilindros.Image");
            btn_Cilindros.Location = new Point(135, 11);
            btn_Cilindros.Name = "btn_Cilindros";
            btn_Cilindros.Size = new Size(48, 42);
            btn_Cilindros.TabIndex = 8;
            btn_Cilindros.UseVisualStyleBackColor = true;
            btn_Cilindros.Click += btn_Cilindros_Click;
            // 
            // rb_CilindrosSi
            // 
            rb_CilindrosSi.AutoSize = true;
            rb_CilindrosSi.Location = new Point(23, 23);
            rb_CilindrosSi.Name = "rb_CilindrosSi";
            rb_CilindrosSi.Size = new Size(34, 19);
            rb_CilindrosSi.TabIndex = 5;
            rb_CilindrosSi.TabStop = true;
            rb_CilindrosSi.Text = "Sí";
            rb_CilindrosSi.UseVisualStyleBackColor = true;
            rb_CilindrosSi.CheckedChanged += rb_CilindrosSi_CheckedChanged;
            // 
            // rb_CilindrosNo
            // 
            rb_CilindrosNo.AutoSize = true;
            rb_CilindrosNo.Location = new Point(313, 23);
            rb_CilindrosNo.Name = "rb_CilindrosNo";
            rb_CilindrosNo.Size = new Size(41, 19);
            rb_CilindrosNo.TabIndex = 6;
            rb_CilindrosNo.TabStop = true;
            rb_CilindrosNo.Text = "No";
            rb_CilindrosNo.UseVisualStyleBackColor = true;
            rb_CilindrosNo.CheckedChanged += rb_CilindrosNo_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rb_PorteroSi);
            groupBox3.Controls.Add(rb_PorteroNo);
            groupBox3.Location = new Point(284, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(584, 59);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Portero eléctrico";
            // 
            // rb_PorteroSi
            // 
            rb_PorteroSi.AutoSize = true;
            rb_PorteroSi.Location = new Point(23, 23);
            rb_PorteroSi.Name = "rb_PorteroSi";
            rb_PorteroSi.Size = new Size(34, 19);
            rb_PorteroSi.TabIndex = 5;
            rb_PorteroSi.TabStop = true;
            rb_PorteroSi.Text = "Sí";
            rb_PorteroSi.UseVisualStyleBackColor = true;
            rb_PorteroSi.CheckedChanged += rb_PorteroSi_CheckedChanged;
            // 
            // rb_PorteroNo
            // 
            rb_PorteroNo.AutoSize = true;
            rb_PorteroNo.Location = new Point(313, 23);
            rb_PorteroNo.Name = "rb_PorteroNo";
            rb_PorteroNo.Size = new Size(41, 19);
            rb_PorteroNo.TabIndex = 6;
            rb_PorteroNo.TabStop = true;
            rb_PorteroNo.Text = "No";
            rb_PorteroNo.UseVisualStyleBackColor = true;
            rb_PorteroNo.CheckedChanged += rb_PorteroNo_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmb_AgujaPuerta);
            groupBox2.Controls.Add(btn_DefinirAgujaPuertaPerfil);
            groupBox2.Controls.Add(rb_AgujaPuertaGenerica);
            groupBox2.Controls.Add(rb_AgujaPuertaPerfil);
            groupBox2.Location = new Point(284, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 59);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aguja";
            // 
            // cmb_AgujaPuerta
            // 
            cmb_AgujaPuerta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_AgujaPuerta.FormattingEnabled = true;
            cmb_AgujaPuerta.Location = new Point(104, 22);
            cmb_AgujaPuerta.Name = "cmb_AgujaPuerta";
            cmb_AgujaPuerta.Size = new Size(145, 23);
            cmb_AgujaPuerta.TabIndex = 0;
            cmb_AgujaPuerta.SelectedValueChanged += cmb_AgujaPuerta_SelectedValueChanged;
            // 
            // btn_DefinirAgujaPuertaPerfil
            // 
            btn_DefinirAgujaPuertaPerfil.Image = (Image)resources.GetObject("btn_DefinirAgujaPuertaPerfil.Image");
            btn_DefinirAgujaPuertaPerfil.Location = new Point(459, 13);
            btn_DefinirAgujaPuertaPerfil.Name = "btn_DefinirAgujaPuertaPerfil";
            btn_DefinirAgujaPuertaPerfil.Size = new Size(48, 42);
            btn_DefinirAgujaPuertaPerfil.TabIndex = 7;
            btn_DefinirAgujaPuertaPerfil.UseVisualStyleBackColor = true;
            btn_DefinirAgujaPuertaPerfil.Click += btn_DefinirAgujaPuertaPerfil_Click;
            // 
            // rb_AgujaPuertaGenerica
            // 
            rb_AgujaPuertaGenerica.AutoSize = true;
            rb_AgujaPuertaGenerica.Location = new Point(23, 23);
            rb_AgujaPuertaGenerica.Name = "rb_AgujaPuertaGenerica";
            rb_AgujaPuertaGenerica.Size = new Size(56, 19);
            rb_AgujaPuertaGenerica.TabIndex = 5;
            rb_AgujaPuertaGenerica.TabStop = true;
            rb_AgujaPuertaGenerica.Text = "Todos";
            rb_AgujaPuertaGenerica.UseVisualStyleBackColor = true;
            rb_AgujaPuertaGenerica.CheckedChanged += rb_AgujaPuertaGenerica_CheckedChanged;
            // 
            // rb_AgujaPuertaPerfil
            // 
            rb_AgujaPuertaPerfil.AutoSize = true;
            rb_AgujaPuertaPerfil.Location = new Point(313, 23);
            rb_AgujaPuertaPerfil.Name = "rb_AgujaPuertaPerfil";
            rb_AgujaPuertaPerfil.Size = new Size(73, 19);
            rb_AgujaPuertaPerfil.TabIndex = 6;
            rb_AgujaPuertaPerfil.TabStop = true;
            rb_AgujaPuertaPerfil.Text = "Por perfil";
            rb_AgujaPuertaPerfil.UseVisualStyleBackColor = true;
            rb_AgujaPuertaPerfil.CheckedChanged += rb_AgujaPuertaPerfil_CheckedChanged;
            // 
            // group_Cerraduras
            // 
            group_Cerraduras.Controls.Add(dgvCerraduras);
            group_Cerraduras.Location = new Point(579, 231);
            group_Cerraduras.Name = "group_Cerraduras";
            group_Cerraduras.Size = new Size(289, 223);
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
            dgvCerraduras.Location = new Point(6, 22);
            dgvCerraduras.Name = "dgvCerraduras";
            dgvCerraduras.ReadOnly = true;
            dgvCerraduras.Size = new Size(277, 195);
            dgvCerraduras.TabIndex = 2;
            dgvCerraduras.CellMouseUp += dgvCerraduras_CellMouseUp;
            // 
            // group_Bisagras
            // 
            group_Bisagras.Controls.Add(dgvBisagras);
            group_Bisagras.Location = new Point(284, 231);
            group_Bisagras.Name = "group_Bisagras";
            group_Bisagras.Size = new Size(289, 223);
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
            dgvBisagras.Location = new Point(6, 22);
            dgvBisagras.Name = "dgvBisagras";
            dgvBisagras.ReadOnly = true;
            dgvBisagras.Size = new Size(277, 195);
            dgvBisagras.TabIndex = 2;
            dgvBisagras.CellMouseUp += dgvBisagras_CellMouseUp;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesPuertas);
            group_Comentarios.Location = new Point(25, 469);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(884, 104);
            group_Comentarios.TabIndex = 15;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesPuertas
            // 
            txt_ObservacionesPuertas.Location = new Point(17, 22);
            txt_ObservacionesPuertas.MaxLength = 1000;
            txt_ObservacionesPuertas.Multiline = true;
            txt_ObservacionesPuertas.Name = "txt_ObservacionesPuertas";
            txt_ObservacionesPuertas.Size = new Size(851, 66);
            txt_ObservacionesPuertas.TabIndex = 8;
            txt_ObservacionesPuertas.TextChanged += txt_ObservacionesPuertas_TextChanged;
            // 
            // PasoPuertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(group_Comentarios);
            Name = "PasoPuertas";
            Size = new Size(946, 604);
            Load += PasoPuertas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
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
        private GroupBox groupBox4;
        private RadioButton rb_CilindrosSi;
        private RadioButton rb_CilindrosNo;
        private GroupBox groupBox3;
        private RadioButton rb_PorteroSi;
        private RadioButton rb_PorteroNo;
        private Button btn_Cilindros;
    }
}
