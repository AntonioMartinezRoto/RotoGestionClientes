namespace RotoGestionClientes
{
    partial class PasoMaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasoMaquinas));
            pictureBox1 = new PictureBox();
            group_Comentarios = new GroupBox();
            txt_ObservacionesMaquinas = new TextBox();
            group_Maquinas = new GroupBox();
            groupSoporteMarco = new GroupBox();
            rb_SoporteBanco = new RadioButton();
            rb_SoporteCentro = new RadioButton();
            rb_SoportePlantilla = new RadioButton();
            groupCentroTripleTaladro = new GroupBox();
            rb_TripleTaladroCentroSi = new RadioButton();
            rb_TripleTaladroCentroNo = new RadioButton();
            groupSoldadoraBisagras = new GroupBox();
            rb_BisagraSoldadoraSi = new RadioButton();
            rb_BisagraSoldadoraNo = new RadioButton();
            btn_AddMaquina = new Button();
            dgvMaquinas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Comentarios.SuspendLayout();
            group_Maquinas.SuspendLayout();
            groupSoporteMarco.SuspendLayout();
            groupCentroTripleTaladro.SuspendLayout();
            groupSoldadoraBisagras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 107);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesMaquinas);
            group_Comentarios.Location = new Point(29, 644);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(1010, 139);
            group_Comentarios.TabIndex = 16;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesMaquinas
            // 
            txt_ObservacionesMaquinas.Location = new Point(19, 29);
            txt_ObservacionesMaquinas.Margin = new Padding(3, 4, 3, 4);
            txt_ObservacionesMaquinas.MaxLength = 1000;
            txt_ObservacionesMaquinas.Multiline = true;
            txt_ObservacionesMaquinas.Name = "txt_ObservacionesMaquinas";
            txt_ObservacionesMaquinas.Size = new Size(972, 87);
            txt_ObservacionesMaquinas.TabIndex = 8;
            txt_ObservacionesMaquinas.TextChanged += txt_ObservacionesMaquinas_TextChanged;
            // 
            // group_Maquinas
            // 
            group_Maquinas.Controls.Add(groupSoporteMarco);
            group_Maquinas.Controls.Add(groupCentroTripleTaladro);
            group_Maquinas.Controls.Add(groupSoldadoraBisagras);
            group_Maquinas.Controls.Add(btn_AddMaquina);
            group_Maquinas.Controls.Add(dgvMaquinas);
            group_Maquinas.Controls.Add(pictureBox1);
            group_Maquinas.Location = new Point(29, 4);
            group_Maquinas.Margin = new Padding(3, 4, 3, 4);
            group_Maquinas.Name = "group_Maquinas";
            group_Maquinas.Padding = new Padding(3, 4, 3, 4);
            group_Maquinas.Size = new Size(1010, 632);
            group_Maquinas.TabIndex = 17;
            group_Maquinas.TabStop = false;
            group_Maquinas.Text = "Máquinas";
            // 
            // groupSoporteMarco
            // 
            groupSoporteMarco.Controls.Add(rb_SoporteBanco);
            groupSoporteMarco.Controls.Add(rb_SoporteCentro);
            groupSoporteMarco.Controls.Add(rb_SoportePlantilla);
            groupSoporteMarco.Location = new Point(702, 448);
            groupSoporteMarco.Margin = new Padding(3, 4, 3, 4);
            groupSoporteMarco.Name = "groupSoporteMarco";
            groupSoporteMarco.Padding = new Padding(3, 4, 3, 4);
            groupSoporteMarco.Size = new Size(272, 148);
            groupSoporteMarco.TabIndex = 19;
            groupSoporteMarco.TabStop = false;
            groupSoporteMarco.Text = "Soporte de marco";
            // 
            // rb_SoporteBanco
            // 
            rb_SoporteBanco.AutoSize = true;
            rb_SoporteBanco.Location = new Point(19, 105);
            rb_SoporteBanco.Margin = new Padding(3, 4, 3, 4);
            rb_SoporteBanco.Name = "rb_SoporteBanco";
            rb_SoporteBanco.Size = new Size(144, 24);
            rb_SoporteBanco.TabIndex = 7;
            rb_SoporteBanco.TabStop = true;
            rb_SoporteBanco.Text = "Banco de marcos";
            rb_SoporteBanco.UseVisualStyleBackColor = true;
            rb_SoporteBanco.CheckedChanged += rb_SoporteBanco_CheckedChanged;
            // 
            // rb_SoporteCentro
            // 
            rb_SoporteCentro.AutoSize = true;
            rb_SoporteCentro.Location = new Point(19, 29);
            rb_SoporteCentro.Margin = new Padding(3, 4, 3, 4);
            rb_SoporteCentro.Name = "rb_SoporteCentro";
            rb_SoporteCentro.Size = new Size(180, 24);
            rb_SoporteCentro.TabIndex = 5;
            rb_SoporteCentro.TabStop = true;
            rb_SoporteCentro.Text = "Centro de mecanizado";
            rb_SoporteCentro.UseVisualStyleBackColor = true;
            rb_SoporteCentro.CheckedChanged += rb_SoporteCentro_CheckedChanged;
            // 
            // rb_SoportePlantilla
            // 
            rb_SoportePlantilla.AutoSize = true;
            rb_SoportePlantilla.Location = new Point(19, 68);
            rb_SoportePlantilla.Margin = new Padding(3, 4, 3, 4);
            rb_SoportePlantilla.Name = "rb_SoportePlantilla";
            rb_SoportePlantilla.Size = new Size(83, 24);
            rb_SoportePlantilla.TabIndex = 6;
            rb_SoportePlantilla.TabStop = true;
            rb_SoportePlantilla.Text = "Plantilla";
            rb_SoportePlantilla.UseVisualStyleBackColor = true;
            rb_SoportePlantilla.CheckedChanged += rb_SoportePlantilla_CheckedChanged;
            // 
            // groupCentroTripleTaladro
            // 
            groupCentroTripleTaladro.Controls.Add(rb_TripleTaladroCentroSi);
            groupCentroTripleTaladro.Controls.Add(rb_TripleTaladroCentroNo);
            groupCentroTripleTaladro.Location = new Point(357, 448);
            groupCentroTripleTaladro.Margin = new Padding(3, 4, 3, 4);
            groupCentroTripleTaladro.Name = "groupCentroTripleTaladro";
            groupCentroTripleTaladro.Padding = new Padding(3, 4, 3, 4);
            groupCentroTripleTaladro.Size = new Size(272, 148);
            groupCentroTripleTaladro.TabIndex = 18;
            groupCentroTripleTaladro.TabStop = false;
            groupCentroTripleTaladro.Text = "Triple taladro en centro mecanizado";
            // 
            // rb_TripleTaladroCentroSi
            // 
            rb_TripleTaladroCentroSi.AutoSize = true;
            rb_TripleTaladroCentroSi.Location = new Point(19, 44);
            rb_TripleTaladroCentroSi.Margin = new Padding(3, 4, 3, 4);
            rb_TripleTaladroCentroSi.Name = "rb_TripleTaladroCentroSi";
            rb_TripleTaladroCentroSi.Size = new Size(42, 24);
            rb_TripleTaladroCentroSi.TabIndex = 5;
            rb_TripleTaladroCentroSi.TabStop = true;
            rb_TripleTaladroCentroSi.Text = "Sí";
            rb_TripleTaladroCentroSi.UseVisualStyleBackColor = true;
            rb_TripleTaladroCentroSi.CheckedChanged += rb_TripleTaladroCentroSi_CheckedChanged;
            // 
            // rb_TripleTaladroCentroNo
            // 
            rb_TripleTaladroCentroNo.AutoSize = true;
            rb_TripleTaladroCentroNo.Location = new Point(19, 77);
            rb_TripleTaladroCentroNo.Margin = new Padding(3, 4, 3, 4);
            rb_TripleTaladroCentroNo.Name = "rb_TripleTaladroCentroNo";
            rb_TripleTaladroCentroNo.Size = new Size(50, 24);
            rb_TripleTaladroCentroNo.TabIndex = 6;
            rb_TripleTaladroCentroNo.TabStop = true;
            rb_TripleTaladroCentroNo.Text = "No";
            rb_TripleTaladroCentroNo.UseVisualStyleBackColor = true;
            rb_TripleTaladroCentroNo.CheckedChanged += rb_TripleTaladroCentroNo_CheckedChanged;
            // 
            // groupSoldadoraBisagras
            // 
            groupSoldadoraBisagras.Controls.Add(rb_BisagraSoldadoraSi);
            groupSoldadoraBisagras.Controls.Add(rb_BisagraSoldadoraNo);
            groupSoldadoraBisagras.Location = new Point(25, 448);
            groupSoldadoraBisagras.Margin = new Padding(3, 4, 3, 4);
            groupSoldadoraBisagras.Name = "groupSoldadoraBisagras";
            groupSoldadoraBisagras.Padding = new Padding(3, 4, 3, 4);
            groupSoldadoraBisagras.Size = new Size(272, 148);
            groupSoldadoraBisagras.TabIndex = 17;
            groupSoldadoraBisagras.TabStop = false;
            groupSoldadoraBisagras.Text = "Bisagras en soldadora";
            // 
            // rb_BisagraSoldadoraSi
            // 
            rb_BisagraSoldadoraSi.AutoSize = true;
            rb_BisagraSoldadoraSi.Location = new Point(23, 44);
            rb_BisagraSoldadoraSi.Margin = new Padding(3, 4, 3, 4);
            rb_BisagraSoldadoraSi.Name = "rb_BisagraSoldadoraSi";
            rb_BisagraSoldadoraSi.Size = new Size(42, 24);
            rb_BisagraSoldadoraSi.TabIndex = 5;
            rb_BisagraSoldadoraSi.TabStop = true;
            rb_BisagraSoldadoraSi.Text = "Sí";
            rb_BisagraSoldadoraSi.UseVisualStyleBackColor = true;
            rb_BisagraSoldadoraSi.CheckedChanged += rb_BisagraSoldadoraSi_CheckedChanged;
            // 
            // rb_BisagraSoldadoraNo
            // 
            rb_BisagraSoldadoraNo.AutoSize = true;
            rb_BisagraSoldadoraNo.Location = new Point(23, 77);
            rb_BisagraSoldadoraNo.Margin = new Padding(3, 4, 3, 4);
            rb_BisagraSoldadoraNo.Name = "rb_BisagraSoldadoraNo";
            rb_BisagraSoldadoraNo.Size = new Size(50, 24);
            rb_BisagraSoldadoraNo.TabIndex = 6;
            rb_BisagraSoldadoraNo.TabStop = true;
            rb_BisagraSoldadoraNo.Text = "No";
            rb_BisagraSoldadoraNo.UseVisualStyleBackColor = true;
            rb_BisagraSoldadoraNo.CheckedChanged += rb_BisagraSoldadoraNo_CheckedChanged;
            // 
            // btn_AddMaquina
            // 
            btn_AddMaquina.Location = new Point(261, 29);
            btn_AddMaquina.Margin = new Padding(3, 4, 3, 4);
            btn_AddMaquina.Name = "btn_AddMaquina";
            btn_AddMaquina.Size = new Size(37, 43);
            btn_AddMaquina.TabIndex = 5;
            btn_AddMaquina.Text = " +";
            btn_AddMaquina.UseVisualStyleBackColor = true;
            btn_AddMaquina.Click += btn_AddMaquina_Click;
            // 
            // dgvMaquinas
            // 
            dgvMaquinas.AllowUserToAddRows = false;
            dgvMaquinas.AllowUserToDeleteRows = false;
            dgvMaquinas.AllowUserToOrderColumns = true;
            dgvMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMaquinas.BackgroundColor = Color.White;
            dgvMaquinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinas.Location = new Point(261, 80);
            dgvMaquinas.Margin = new Padding(3, 4, 3, 4);
            dgvMaquinas.Name = "dgvMaquinas";
            dgvMaquinas.ReadOnly = true;
            dgvMaquinas.RowHeadersVisible = false;
            dgvMaquinas.RowHeadersWidth = 51;
            dgvMaquinas.Size = new Size(736, 315);
            dgvMaquinas.TabIndex = 4;
            dgvMaquinas.CellClick += dgvMaquinas_CellClick;
            // 
            // PasoMaquinas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(group_Maquinas);
            Controls.Add(group_Comentarios);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1081, 805);
            Name = "PasoMaquinas";
            Size = new Size(1081, 805);
            Load += PasoMaquinas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            group_Maquinas.ResumeLayout(false);
            groupSoporteMarco.ResumeLayout(false);
            groupSoporteMarco.PerformLayout();
            groupCentroTripleTaladro.ResumeLayout(false);
            groupCentroTripleTaladro.PerformLayout();
            groupSoldadoraBisagras.ResumeLayout(false);
            groupSoldadoraBisagras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox group_Comentarios;
        private TextBox txt_ObservacionesMaquinas;
        private GroupBox group_Maquinas;
        private DataGridView dgvMaquinas;
        private Button btn_AddMaquina;
        private GroupBox groupCentroTripleTaladro;
        private RadioButton rb_TripleTaladroCentroSi;
        private RadioButton rb_TripleTaladroCentroNo;
        private GroupBox groupSoldadoraBisagras;
        private RadioButton rb_BisagraSoldadoraSi;
        private RadioButton rb_BisagraSoldadoraNo;
        private GroupBox groupSoporteMarco;
        private RadioButton rb_SoporteCentro;
        private RadioButton rb_SoportePlantilla;
        private RadioButton rb_SoporteBanco;
    }
}
