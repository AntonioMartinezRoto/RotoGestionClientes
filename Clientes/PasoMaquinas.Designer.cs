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
            groupBox1 = new GroupBox();
            groupSoporteMarco = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupCentroTripleTaladro = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupSoldadoraBisagras = new GroupBox();
            rb_BisagraSoldadoraSi = new RadioButton();
            rb_BombilloNo = new RadioButton();
            btn_AddMaquina = new Button();
            dgvMaquinas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Comentarios.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(groupSoporteMarco);
            groupBox1.Controls.Add(groupCentroTripleTaladro);
            groupBox1.Controls.Add(groupSoldadoraBisagras);
            groupBox1.Controls.Add(btn_AddMaquina);
            groupBox1.Controls.Add(dgvMaquinas);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(29, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1010, 632);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Máquinas";
            // 
            // groupSoporteMarco
            // 
            groupSoporteMarco.Controls.Add(radioButton5);
            groupSoporteMarco.Controls.Add(radioButton3);
            groupSoporteMarco.Controls.Add(radioButton4);
            groupSoporteMarco.Location = new Point(702, 448);
            groupSoporteMarco.Margin = new Padding(3, 4, 3, 4);
            groupSoporteMarco.Name = "groupSoporteMarco";
            groupSoporteMarco.Padding = new Padding(3, 4, 3, 4);
            groupSoporteMarco.Size = new Size(272, 148);
            groupSoporteMarco.TabIndex = 19;
            groupSoporteMarco.TabStop = false;
            groupSoporteMarco.Text = "Soporte de marco";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(19, 105);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(144, 24);
            radioButton5.TabIndex = 7;
            radioButton5.TabStop = true;
            radioButton5.Text = "Banco de marcos";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 29);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(180, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Centro de mecanizado";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(19, 68);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(83, 24);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Plantilla";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupCentroTripleTaladro
            // 
            groupCentroTripleTaladro.Controls.Add(radioButton1);
            groupCentroTripleTaladro.Controls.Add(radioButton2);
            groupCentroTripleTaladro.Location = new Point(357, 448);
            groupCentroTripleTaladro.Margin = new Padding(3, 4, 3, 4);
            groupCentroTripleTaladro.Name = "groupCentroTripleTaladro";
            groupCentroTripleTaladro.Padding = new Padding(3, 4, 3, 4);
            groupCentroTripleTaladro.Size = new Size(272, 148);
            groupCentroTripleTaladro.TabIndex = 18;
            groupCentroTripleTaladro.TabStop = false;
            groupCentroTripleTaladro.Text = "Triple taladro en centro mecanizado";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 44);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sí";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 77);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupSoldadoraBisagras
            // 
            groupSoldadoraBisagras.Controls.Add(rb_BisagraSoldadoraSi);
            groupSoldadoraBisagras.Controls.Add(rb_BombilloNo);
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
            // 
            // rb_BombilloNo
            // 
            rb_BombilloNo.AutoSize = true;
            rb_BombilloNo.Location = new Point(23, 77);
            rb_BombilloNo.Margin = new Padding(3, 4, 3, 4);
            rb_BombilloNo.Name = "rb_BombilloNo";
            rb_BombilloNo.Size = new Size(50, 24);
            rb_BombilloNo.TabIndex = 6;
            rb_BombilloNo.TabStop = true;
            rb_BombilloNo.Text = "No";
            rb_BombilloNo.UseVisualStyleBackColor = true;
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
            Controls.Add(groupBox1);
            Controls.Add(group_Comentarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PasoMaquinas";
            Size = new Size(1081, 805);
            Load += PasoMaquinas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private DataGridView dgvMaquinas;
        private Button btn_AddMaquina;
        private GroupBox groupCentroTripleTaladro;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupSoldadoraBisagras;
        private RadioButton rb_BisagraSoldadoraSi;
        private RadioButton rb_BombilloNo;
        private GroupBox groupSoporteMarco;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
    }
}
