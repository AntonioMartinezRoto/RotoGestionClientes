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
            pictureBox1.Location = new Point(10, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesMaquinas);
            group_Comentarios.Location = new Point(25, 483);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(884, 104);
            group_Comentarios.TabIndex = 16;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesMaquinas
            // 
            txt_ObservacionesMaquinas.Location = new Point(17, 22);
            txt_ObservacionesMaquinas.MaxLength = 1000;
            txt_ObservacionesMaquinas.Multiline = true;
            txt_ObservacionesMaquinas.Name = "txt_ObservacionesMaquinas";
            txt_ObservacionesMaquinas.Size = new Size(851, 66);
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
            groupBox1.Location = new Point(25, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 474);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Máquinas";
            // 
            // groupSoporteMarco
            // 
            groupSoporteMarco.Controls.Add(radioButton5);
            groupSoporteMarco.Controls.Add(radioButton3);
            groupSoporteMarco.Controls.Add(radioButton4);
            groupSoporteMarco.Location = new Point(614, 336);
            groupSoporteMarco.Name = "groupSoporteMarco";
            groupSoporteMarco.Size = new Size(238, 111);
            groupSoporteMarco.TabIndex = 19;
            groupSoporteMarco.TabStop = false;
            groupSoporteMarco.Text = "Soporte de marco";
            groupSoporteMarco.Visible = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(17, 79);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(116, 19);
            radioButton5.TabIndex = 7;
            radioButton5.TabStop = true;
            radioButton5.Text = "Banco de marcos";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(144, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Centro de mecanizado";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 51);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 19);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Plantilla";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupCentroTripleTaladro
            // 
            groupCentroTripleTaladro.Controls.Add(radioButton1);
            groupCentroTripleTaladro.Controls.Add(radioButton2);
            groupCentroTripleTaladro.Location = new Point(312, 336);
            groupCentroTripleTaladro.Name = "groupCentroTripleTaladro";
            groupCentroTripleTaladro.Size = new Size(238, 111);
            groupCentroTripleTaladro.TabIndex = 18;
            groupCentroTripleTaladro.TabStop = false;
            groupCentroTripleTaladro.Text = "Triple taladro en centro mecanizado";
            groupCentroTripleTaladro.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sí";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupSoldadoraBisagras
            // 
            groupSoldadoraBisagras.Controls.Add(rb_BisagraSoldadoraSi);
            groupSoldadoraBisagras.Controls.Add(rb_BombilloNo);
            groupSoldadoraBisagras.Location = new Point(22, 336);
            groupSoldadoraBisagras.Name = "groupSoldadoraBisagras";
            groupSoldadoraBisagras.Size = new Size(238, 111);
            groupSoldadoraBisagras.TabIndex = 17;
            groupSoldadoraBisagras.TabStop = false;
            groupSoldadoraBisagras.Text = "Bisagras en soldadora";
            groupSoldadoraBisagras.Visible = false;
            // 
            // rb_BisagraSoldadoraSi
            // 
            rb_BisagraSoldadoraSi.AutoSize = true;
            rb_BisagraSoldadoraSi.Location = new Point(20, 33);
            rb_BisagraSoldadoraSi.Name = "rb_BisagraSoldadoraSi";
            rb_BisagraSoldadoraSi.Size = new Size(34, 19);
            rb_BisagraSoldadoraSi.TabIndex = 5;
            rb_BisagraSoldadoraSi.TabStop = true;
            rb_BisagraSoldadoraSi.Text = "Sí";
            rb_BisagraSoldadoraSi.UseVisualStyleBackColor = true;
            // 
            // rb_BombilloNo
            // 
            rb_BombilloNo.AutoSize = true;
            rb_BombilloNo.Location = new Point(20, 58);
            rb_BombilloNo.Name = "rb_BombilloNo";
            rb_BombilloNo.Size = new Size(41, 19);
            rb_BombilloNo.TabIndex = 6;
            rb_BombilloNo.TabStop = true;
            rb_BombilloNo.Text = "No";
            rb_BombilloNo.UseVisualStyleBackColor = true;
            // 
            // btn_AddMaquina
            // 
            btn_AddMaquina.Location = new Point(228, 22);
            btn_AddMaquina.Name = "btn_AddMaquina";
            btn_AddMaquina.Size = new Size(32, 32);
            btn_AddMaquina.TabIndex = 5;
            btn_AddMaquina.Text = " +";
            btn_AddMaquina.UseVisualStyleBackColor = true;
            // 
            // dgvMaquinas
            // 
            dgvMaquinas.AllowUserToAddRows = false;
            dgvMaquinas.AllowUserToDeleteRows = false;
            dgvMaquinas.AllowUserToOrderColumns = true;
            dgvMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMaquinas.BackgroundColor = Color.White;
            dgvMaquinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinas.Location = new Point(228, 60);
            dgvMaquinas.Name = "dgvMaquinas";
            dgvMaquinas.ReadOnly = true;
            dgvMaquinas.RowHeadersVisible = false;
            dgvMaquinas.Size = new Size(644, 236);
            dgvMaquinas.TabIndex = 4;
            // 
            // PasoMaquinas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(group_Comentarios);
            Name = "PasoMaquinas";
            Size = new Size(946, 604);
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
