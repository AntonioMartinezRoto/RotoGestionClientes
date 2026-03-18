namespace RotoGestionClientes
{
    partial class PasoParalelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasoParalelas));
            pictureBox1 = new PictureBox();
            group_Comentarios = new GroupBox();
            txt_ObservacionesParalelas = new TextBox();
            groupBox1 = new GroupBox();
            groupPSAir = new GroupBox();
            rb_PSAirCV = new RadioButton();
            rb_PSAirCF = new RadioButton();
            groupPS = new GroupBox();
            rb_PSCV = new RadioButton();
            rb_PSCF = new RadioButton();
            groupAlversaKS = new GroupBox();
            rb_KSCV = new RadioButton();
            rb_KSCF = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Comentarios.SuspendLayout();
            groupBox1.SuspendLayout();
            groupPSAir.SuspendLayout();
            groupPS.SuspendLayout();
            groupAlversaKS.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesParalelas);
            group_Comentarios.Location = new Point(32, 471);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(884, 104);
            group_Comentarios.TabIndex = 16;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesParalelas
            // 
            txt_ObservacionesParalelas.Location = new Point(17, 22);
            txt_ObservacionesParalelas.MaxLength = 1000;
            txt_ObservacionesParalelas.Multiline = true;
            txt_ObservacionesParalelas.Name = "txt_ObservacionesParalelas";
            txt_ObservacionesParalelas.Size = new Size(851, 66);
            txt_ObservacionesParalelas.TabIndex = 8;
            txt_ObservacionesParalelas.TextChanged += txt_ObservacionesParalelas_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupPSAir);
            groupBox1.Controls.Add(groupPS);
            groupBox1.Controls.Add(groupAlversaKS);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(32, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(868, 434);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paralelas";
            // 
            // groupPSAir
            // 
            groupPSAir.Controls.Add(rb_PSAirCV);
            groupPSAir.Controls.Add(rb_PSAirCF);
            groupPSAir.Location = new Point(393, 302);
            groupPSAir.Name = "groupPSAir";
            groupPSAir.Size = new Size(426, 59);
            groupPSAir.TabIndex = 18;
            groupPSAir.TabStop = false;
            groupPSAir.Text = "Alversa PS Air Com";
            // 
            // rb_PSAirCV
            // 
            rb_PSAirCV.AutoSize = true;
            rb_PSAirCV.Location = new Point(23, 23);
            rb_PSAirCV.Name = "rb_PSAirCV";
            rb_PSAirCV.Size = new Size(94, 19);
            rb_PSAirCV.TabIndex = 5;
            rb_PSAirCV.TabStop = true;
            rb_PSAirCV.Text = "Cota variable";
            rb_PSAirCV.UseVisualStyleBackColor = true;
            // 
            // rb_PSAirCF
            // 
            rb_PSAirCF.AutoSize = true;
            rb_PSAirCF.Location = new Point(313, 23);
            rb_PSAirCF.Name = "rb_PSAirCF";
            rb_PSAirCF.Size = new Size(69, 19);
            rb_PSAirCF.TabIndex = 6;
            rb_PSAirCF.TabStop = true;
            rb_PSAirCF.Text = "Cota fija";
            rb_PSAirCF.UseVisualStyleBackColor = true;
            // 
            // groupPS
            // 
            groupPS.Controls.Add(rb_PSCV);
            groupPS.Controls.Add(rb_PSCF);
            groupPS.Location = new Point(393, 196);
            groupPS.Name = "groupPS";
            groupPS.Size = new Size(426, 59);
            groupPS.TabIndex = 17;
            groupPS.TabStop = false;
            groupPS.Text = "Alversa PS";
            // 
            // rb_PSCV
            // 
            rb_PSCV.AutoSize = true;
            rb_PSCV.Location = new Point(23, 23);
            rb_PSCV.Name = "rb_PSCV";
            rb_PSCV.Size = new Size(94, 19);
            rb_PSCV.TabIndex = 5;
            rb_PSCV.TabStop = true;
            rb_PSCV.Text = "Cota variable";
            rb_PSCV.UseVisualStyleBackColor = true;
            // 
            // rb_PSCF
            // 
            rb_PSCF.AutoSize = true;
            rb_PSCF.Location = new Point(313, 23);
            rb_PSCF.Name = "rb_PSCF";
            rb_PSCF.Size = new Size(69, 19);
            rb_PSCF.TabIndex = 6;
            rb_PSCF.TabStop = true;
            rb_PSCF.Text = "Cota fija";
            rb_PSCF.UseVisualStyleBackColor = true;
            // 
            // groupAlversaKS
            // 
            groupAlversaKS.Controls.Add(rb_KSCV);
            groupAlversaKS.Controls.Add(rb_KSCF);
            groupAlversaKS.Location = new Point(393, 86);
            groupAlversaKS.Name = "groupAlversaKS";
            groupAlversaKS.Size = new Size(426, 59);
            groupAlversaKS.TabIndex = 16;
            groupAlversaKS.TabStop = false;
            groupAlversaKS.Text = "Alversa KS";
            // 
            // rb_KSCV
            // 
            rb_KSCV.AutoSize = true;
            rb_KSCV.Location = new Point(23, 23);
            rb_KSCV.Name = "rb_KSCV";
            rb_KSCV.Size = new Size(94, 19);
            rb_KSCV.TabIndex = 5;
            rb_KSCV.TabStop = true;
            rb_KSCV.Text = "Cota variable";
            rb_KSCV.UseVisualStyleBackColor = true;
            // 
            // rb_KSCF
            // 
            rb_KSCF.AutoSize = true;
            rb_KSCF.Location = new Point(313, 23);
            rb_KSCF.Name = "rb_KSCF";
            rb_KSCF.Size = new Size(69, 19);
            rb_KSCF.TabIndex = 6;
            rb_KSCF.TabStop = true;
            rb_KSCF.Text = "Cota fija";
            rb_KSCF.UseVisualStyleBackColor = true;
            // 
            // PasoParalelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(group_Comentarios);
            Name = "PasoParalelas";
            Size = new Size(946, 604);
            Load += PasoParalelas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupPSAir.ResumeLayout(false);
            groupPSAir.PerformLayout();
            groupPS.ResumeLayout(false);
            groupPS.PerformLayout();
            groupAlversaKS.ResumeLayout(false);
            groupAlversaKS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox group_Comentarios;
        private TextBox txt_ObservacionesParalelas;
        private GroupBox groupBox1;
        private GroupBox groupPSAir;
        private RadioButton rb_KSCV;
        private RadioButton rb_KSCF;
        private GroupBox groupAlversaKS;
        private RadioButton rb_PSAirCV;
        private RadioButton rb_PSAirCF;
        private GroupBox groupPS;
        private RadioButton rb_PSCV;
        private RadioButton rb_PSCF;
    }
}
