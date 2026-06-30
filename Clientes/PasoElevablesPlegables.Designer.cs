namespace RotoGestionClientes
{
    partial class PasoElevablesPlegables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasoElevablesPlegables));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            group_Plegables = new GroupBox();
            groupConsumoPlegable = new GroupBox();
            rb_ConsumoSi = new RadioButton();
            rb_ConsumoNo = new RadioButton();
            group_ObservacionesPlegables = new GroupBox();
            txt_ObservacionesPlegables = new TextBox();
            group_Elevables = new GroupBox();
            group_Estandar = new GroupBox();
            rb_EstandarSi = new RadioButton();
            rb_EstandarNo = new RadioButton();
            groupDLO = new GroupBox();
            rb_DloSi = new RadioButton();
            rb_DloNo = new RadioButton();
            group_Comentarios = new GroupBox();
            txt_ObservacionesElevables = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            group_Plegables.SuspendLayout();
            groupConsumoPlegable.SuspendLayout();
            group_ObservacionesPlegables.SuspendLayout();
            group_Elevables.SuspendLayout();
            group_Estandar.SuspendLayout();
            groupDLO.SuspendLayout();
            group_Comentarios.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 29);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(391, 320);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // group_Plegables
            // 
            group_Plegables.Controls.Add(groupConsumoPlegable);
            group_Plegables.Controls.Add(group_ObservacionesPlegables);
            group_Plegables.Controls.Add(pictureBox2);
            group_Plegables.Location = new Point(25, 419);
            group_Plegables.Margin = new Padding(3, 4, 3, 4);
            group_Plegables.Name = "group_Plegables";
            group_Plegables.Padding = new Padding(3, 4, 3, 4);
            group_Plegables.Size = new Size(1032, 367);
            group_Plegables.TabIndex = 3;
            group_Plegables.TabStop = false;
            group_Plegables.Text = "Plegables";
            // 
            // groupConsumoPlegable
            // 
            groupConsumoPlegable.Controls.Add(rb_ConsumoSi);
            groupConsumoPlegable.Controls.Add(rb_ConsumoNo);
            groupConsumoPlegable.Location = new Point(453, 40);
            groupConsumoPlegable.Margin = new Padding(3, 4, 3, 4);
            groupConsumoPlegable.Name = "groupConsumoPlegable";
            groupConsumoPlegable.Padding = new Padding(3, 4, 3, 4);
            groupConsumoPlegable.Size = new Size(138, 148);
            groupConsumoPlegable.TabIndex = 18;
            groupConsumoPlegable.TabStop = false;
            groupConsumoPlegable.Text = "Consumen";
            // 
            // rb_ConsumoSi
            // 
            rb_ConsumoSi.AutoSize = true;
            rb_ConsumoSi.Location = new Point(19, 45);
            rb_ConsumoSi.Margin = new Padding(3, 4, 3, 4);
            rb_ConsumoSi.Name = "rb_ConsumoSi";
            rb_ConsumoSi.Size = new Size(42, 24);
            rb_ConsumoSi.TabIndex = 5;
            rb_ConsumoSi.TabStop = true;
            rb_ConsumoSi.Text = "Sí";
            rb_ConsumoSi.UseVisualStyleBackColor = true;
            rb_ConsumoSi.CheckedChanged += rb_ConsumoSi_CheckedChanged;
            // 
            // rb_ConsumoNo
            // 
            rb_ConsumoNo.AutoSize = true;
            rb_ConsumoNo.Location = new Point(19, 96);
            rb_ConsumoNo.Margin = new Padding(3, 4, 3, 4);
            rb_ConsumoNo.Name = "rb_ConsumoNo";
            rb_ConsumoNo.Size = new Size(50, 24);
            rb_ConsumoNo.TabIndex = 6;
            rb_ConsumoNo.TabStop = true;
            rb_ConsumoNo.Text = "No";
            rb_ConsumoNo.UseVisualStyleBackColor = true;
            rb_ConsumoNo.CheckedChanged += rb_ConsumoNo_CheckedChanged;
            // 
            // group_ObservacionesPlegables
            // 
            group_ObservacionesPlegables.Controls.Add(txt_ObservacionesPlegables);
            group_ObservacionesPlegables.Location = new Point(453, 196);
            group_ObservacionesPlegables.Margin = new Padding(3, 4, 3, 4);
            group_ObservacionesPlegables.Name = "group_ObservacionesPlegables";
            group_ObservacionesPlegables.Padding = new Padding(3, 4, 3, 4);
            group_ObservacionesPlegables.Size = new Size(561, 139);
            group_ObservacionesPlegables.TabIndex = 17;
            group_ObservacionesPlegables.TabStop = false;
            group_ObservacionesPlegables.Text = "Observaciones";
            // 
            // txt_ObservacionesPlegables
            // 
            txt_ObservacionesPlegables.Location = new Point(10, 35);
            txt_ObservacionesPlegables.Margin = new Padding(3, 4, 3, 4);
            txt_ObservacionesPlegables.MaxLength = 1000;
            txt_ObservacionesPlegables.Multiline = true;
            txt_ObservacionesPlegables.Name = "txt_ObservacionesPlegables";
            txt_ObservacionesPlegables.Size = new Size(539, 87);
            txt_ObservacionesPlegables.TabIndex = 8;
            txt_ObservacionesPlegables.TextChanged += txt_ObservacionesPlegables_TextChanged;
            // 
            // group_Elevables
            // 
            group_Elevables.Controls.Add(group_Estandar);
            group_Elevables.Controls.Add(groupDLO);
            group_Elevables.Controls.Add(group_Comentarios);
            group_Elevables.Controls.Add(pictureBox1);
            group_Elevables.Location = new Point(25, 25);
            group_Elevables.Margin = new Padding(3, 4, 3, 4);
            group_Elevables.Name = "group_Elevables";
            group_Elevables.Padding = new Padding(3, 4, 3, 4);
            group_Elevables.Size = new Size(1032, 367);
            group_Elevables.TabIndex = 4;
            group_Elevables.TabStop = false;
            group_Elevables.Text = "Elevables";
            // 
            // group_Estandar
            // 
            group_Estandar.Controls.Add(rb_EstandarSi);
            group_Estandar.Controls.Add(rb_EstandarNo);
            group_Estandar.Location = new Point(453, 45);
            group_Estandar.Margin = new Padding(3, 4, 3, 4);
            group_Estandar.Name = "group_Estandar";
            group_Estandar.Padding = new Padding(3, 4, 3, 4);
            group_Estandar.Size = new Size(138, 148);
            group_Estandar.TabIndex = 18;
            group_Estandar.TabStop = false;
            group_Estandar.Text = "Estándar";
            // 
            // rb_EstandarSi
            // 
            rb_EstandarSi.AutoSize = true;
            rb_EstandarSi.Location = new Point(19, 45);
            rb_EstandarSi.Margin = new Padding(3, 4, 3, 4);
            rb_EstandarSi.Name = "rb_EstandarSi";
            rb_EstandarSi.Size = new Size(42, 24);
            rb_EstandarSi.TabIndex = 5;
            rb_EstandarSi.TabStop = true;
            rb_EstandarSi.Text = "Sí";
            rb_EstandarSi.UseVisualStyleBackColor = true;
            rb_EstandarSi.CheckedChanged += rb_EstandarSi_CheckedChanged;
            // 
            // rb_EstandarNo
            // 
            rb_EstandarNo.AutoSize = true;
            rb_EstandarNo.Location = new Point(19, 96);
            rb_EstandarNo.Margin = new Padding(3, 4, 3, 4);
            rb_EstandarNo.Name = "rb_EstandarNo";
            rb_EstandarNo.Size = new Size(50, 24);
            rb_EstandarNo.TabIndex = 6;
            rb_EstandarNo.TabStop = true;
            rb_EstandarNo.Text = "No";
            rb_EstandarNo.UseVisualStyleBackColor = true;
            rb_EstandarNo.CheckedChanged += rb_EstandarNo_CheckedChanged;
            // 
            // groupDLO
            // 
            groupDLO.Controls.Add(rb_DloSi);
            groupDLO.Controls.Add(rb_DloNo);
            groupDLO.Location = new Point(626, 45);
            groupDLO.Margin = new Padding(3, 4, 3, 4);
            groupDLO.Name = "groupDLO";
            groupDLO.Padding = new Padding(3, 4, 3, 4);
            groupDLO.Size = new Size(138, 148);
            groupDLO.TabIndex = 17;
            groupDLO.TabStop = false;
            groupDLO.Text = "DLO";
            // 
            // rb_DloSi
            // 
            rb_DloSi.AutoSize = true;
            rb_DloSi.Location = new Point(19, 45);
            rb_DloSi.Margin = new Padding(3, 4, 3, 4);
            rb_DloSi.Name = "rb_DloSi";
            rb_DloSi.Size = new Size(42, 24);
            rb_DloSi.TabIndex = 5;
            rb_DloSi.TabStop = true;
            rb_DloSi.Text = "Sí";
            rb_DloSi.UseVisualStyleBackColor = true;
            rb_DloSi.CheckedChanged += rb_DloSi_CheckedChanged;
            // 
            // rb_DloNo
            // 
            rb_DloNo.AutoSize = true;
            rb_DloNo.Location = new Point(19, 96);
            rb_DloNo.Margin = new Padding(3, 4, 3, 4);
            rb_DloNo.Name = "rb_DloNo";
            rb_DloNo.Size = new Size(50, 24);
            rb_DloNo.TabIndex = 6;
            rb_DloNo.TabStop = true;
            rb_DloNo.Text = "No";
            rb_DloNo.UseVisualStyleBackColor = true;
            rb_DloNo.CheckedChanged += rb_DloNo_CheckedChanged;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesElevables);
            group_Comentarios.Location = new Point(453, 201);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(561, 139);
            group_Comentarios.TabIndex = 16;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesElevables
            // 
            txt_ObservacionesElevables.Location = new Point(10, 35);
            txt_ObservacionesElevables.Margin = new Padding(3, 4, 3, 4);
            txt_ObservacionesElevables.MaxLength = 1000;
            txt_ObservacionesElevables.Multiline = true;
            txt_ObservacionesElevables.Name = "txt_ObservacionesElevables";
            txt_ObservacionesElevables.Size = new Size(539, 87);
            txt_ObservacionesElevables.TabIndex = 8;
            txt_ObservacionesElevables.TextChanged += txt_ObservacionesElevables_TextChanged;
            // 
            // PasoElevablesPlegables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(group_Elevables);
            Controls.Add(group_Plegables);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1081, 805);
            Name = "PasoElevablesPlegables";
            Size = new Size(1081, 805);
            Load += PasoElevablesPlegables_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            group_Plegables.ResumeLayout(false);
            groupConsumoPlegable.ResumeLayout(false);
            groupConsumoPlegable.PerformLayout();
            group_ObservacionesPlegables.ResumeLayout(false);
            group_ObservacionesPlegables.PerformLayout();
            group_Elevables.ResumeLayout(false);
            group_Estandar.ResumeLayout(false);
            group_Estandar.PerformLayout();
            groupDLO.ResumeLayout(false);
            groupDLO.PerformLayout();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox group_Plegables;
        private GroupBox group_Elevables;
        private GroupBox group_Comentarios;
        private TextBox txt_ObservacionesElevables;
        private GroupBox group_ObservacionesPlegables;
        private TextBox txt_ObservacionesPlegables;
        private GroupBox groupDLO;
        private RadioButton rb_DloSi;
        private RadioButton rb_DloNo;
        private GroupBox groupConsumoPlegable;
        private RadioButton rb_ConsumoSi;
        private RadioButton rb_ConsumoNo;
        private GroupBox group_Estandar;
        private RadioButton rb_EstandarSi;
        private RadioButton rb_EstandarNo;
    }
}
