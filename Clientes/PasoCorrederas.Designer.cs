namespace RotoGestionClientes
{
    partial class PasoCorrederas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasoCorrederas));
            pictureBox1 = new PictureBox();
            group_Comentarios = new GroupBox();
            txt_ObservacionesCorrederas = new TextBox();
            groupBox1 = new GroupBox();
            groupBombillo = new GroupBox();
            rb_BombilloSi = new RadioButton();
            rb_BombilloNo = new RadioButton();
            group_Agujas = new GroupBox();
            dgvAgujas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Comentarios.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBombillo.SuspendLayout();
            group_Agujas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgujas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesCorrederas);
            group_Comentarios.Location = new Point(29, 481);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(884, 104);
            group_Comentarios.TabIndex = 17;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesCorrederas
            // 
            txt_ObservacionesCorrederas.Location = new Point(17, 22);
            txt_ObservacionesCorrederas.MaxLength = 1000;
            txt_ObservacionesCorrederas.Multiline = true;
            txt_ObservacionesCorrederas.Name = "txt_ObservacionesCorrederas";
            txt_ObservacionesCorrederas.Size = new Size(851, 66);
            txt_ObservacionesCorrederas.TabIndex = 8;
            txt_ObservacionesCorrederas.TextChanged += txt_ObservacionesCorrederas_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBombillo);
            groupBox1.Controls.Add(group_Agujas);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(29, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 449);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Correderas";
            // 
            // groupBombillo
            // 
            groupBombillo.Controls.Add(rb_BombilloSi);
            groupBombillo.Controls.Add(rb_BombilloNo);
            groupBombillo.Location = new Point(612, 164);
            groupBombillo.Name = "groupBombillo";
            groupBombillo.Size = new Size(121, 111);
            groupBombillo.TabIndex = 16;
            groupBombillo.TabStop = false;
            groupBombillo.Text = "Bombillo";
            groupBombillo.Visible = false;
            // 
            // rb_BombilloSi
            // 
            rb_BombilloSi.AutoSize = true;
            rb_BombilloSi.Location = new Point(17, 34);
            rb_BombilloSi.Name = "rb_BombilloSi";
            rb_BombilloSi.Size = new Size(34, 19);
            rb_BombilloSi.TabIndex = 5;
            rb_BombilloSi.TabStop = true;
            rb_BombilloSi.Text = "Sí";
            rb_BombilloSi.UseVisualStyleBackColor = true;
            rb_BombilloSi.CheckedChanged += rb_BombilloSi_CheckedChanged;
            // 
            // rb_BombilloNo
            // 
            rb_BombilloNo.AutoSize = true;
            rb_BombilloNo.Location = new Point(17, 71);
            rb_BombilloNo.Name = "rb_BombilloNo";
            rb_BombilloNo.Size = new Size(41, 19);
            rb_BombilloNo.TabIndex = 6;
            rb_BombilloNo.TabStop = true;
            rb_BombilloNo.Text = "No";
            rb_BombilloNo.UseVisualStyleBackColor = true;
            rb_BombilloNo.CheckedChanged += rb_BombilloNo_CheckedChanged;
            // 
            // group_Agujas
            // 
            group_Agujas.Controls.Add(dgvAgujas);
            group_Agujas.Location = new Point(470, 164);
            group_Agujas.Name = "group_Agujas";
            group_Agujas.Size = new Size(117, 111);
            group_Agujas.TabIndex = 7;
            group_Agujas.TabStop = false;
            group_Agujas.Text = "Agujas";
            // 
            // dgvAgujas
            // 
            dgvAgujas.AllowUserToAddRows = false;
            dgvAgujas.AllowUserToDeleteRows = false;
            dgvAgujas.AllowUserToOrderColumns = true;
            dgvAgujas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAgujas.BackgroundColor = Color.White;
            dgvAgujas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgujas.Location = new Point(6, 22);
            dgvAgujas.Name = "dgvAgujas";
            dgvAgujas.ReadOnly = true;
            dgvAgujas.RowHeadersWidth = 51;
            dgvAgujas.Size = new Size(105, 83);
            dgvAgujas.TabIndex = 2;
            dgvAgujas.CellMouseUp += dgvAgujas_CellMouseUp;
            // 
            // PasoCorrederas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(group_Comentarios);
            Name = "PasoCorrederas";
            Size = new Size(946, 604);
            Load += PasoCorrederas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBombillo.ResumeLayout(false);
            groupBombillo.PerformLayout();
            group_Agujas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAgujas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox group_Comentarios;
        private TextBox txt_ObservacionesCorrederas;
        private GroupBox groupBox1;
        private GroupBox group_Agujas;
        private DataGridView dgvAgujas;
        private GroupBox groupBombillo;
        private RadioButton rb_BombilloSi;
        private RadioButton rb_BombilloNo;
    }
}
