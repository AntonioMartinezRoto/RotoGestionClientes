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
            group_Agujas = new GroupBox();
            dgvAgujas = new DataGridView();
            groupBombillo = new GroupBox();
            rb_BombilloSi = new RadioButton();
            rb_BombilloNo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            group_Comentarios.SuspendLayout();
            groupBox1.SuspendLayout();
            group_Agujas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgujas).BeginInit();
            groupBombillo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 108);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesCorrederas);
            group_Comentarios.Location = new Point(33, 641);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(1010, 139);
            group_Comentarios.TabIndex = 17;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesCorrederas
            // 
            txt_ObservacionesCorrederas.Location = new Point(19, 29);
            txt_ObservacionesCorrederas.Margin = new Padding(3, 4, 3, 4);
            txt_ObservacionesCorrederas.MaxLength = 1000;
            txt_ObservacionesCorrederas.Multiline = true;
            txt_ObservacionesCorrederas.Name = "txt_ObservacionesCorrederas";
            txt_ObservacionesCorrederas.Size = new Size(972, 87);
            txt_ObservacionesCorrederas.TabIndex = 8;
            txt_ObservacionesCorrederas.TextChanged += txt_ObservacionesCorrederas_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBombillo);
            groupBox1.Controls.Add(group_Agujas);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(33, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1010, 599);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Correderas";
            // 
            // group_Agujas
            // 
            group_Agujas.Controls.Add(dgvAgujas);
            group_Agujas.Location = new Point(537, 219);
            group_Agujas.Margin = new Padding(3, 4, 3, 4);
            group_Agujas.Name = "group_Agujas";
            group_Agujas.Padding = new Padding(3, 4, 3, 4);
            group_Agujas.Size = new Size(134, 148);
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
            dgvAgujas.Location = new Point(7, 29);
            dgvAgujas.Margin = new Padding(3, 4, 3, 4);
            dgvAgujas.Name = "dgvAgujas";
            dgvAgujas.ReadOnly = true;
            dgvAgujas.RowHeadersWidth = 51;
            dgvAgujas.Size = new Size(120, 111);
            dgvAgujas.TabIndex = 2;
            dgvAgujas.CellMouseUp += dgvAgujas_CellMouseUp;
            // 
            // groupBombillo
            // 
            groupBombillo.Controls.Add(rb_BombilloSi);
            groupBombillo.Controls.Add(rb_BombilloNo);
            groupBombillo.Location = new Point(700, 219);
            groupBombillo.Margin = new Padding(3, 4, 3, 4);
            groupBombillo.Name = "groupBombillo";
            groupBombillo.Padding = new Padding(3, 4, 3, 4);
            groupBombillo.Size = new Size(138, 148);
            groupBombillo.TabIndex = 16;
            groupBombillo.TabStop = false;
            groupBombillo.Text = "Bombillo";
            groupBombillo.Visible = false;
            // 
            // rb_BombilloSi
            // 
            rb_BombilloSi.AutoSize = true;
            rb_BombilloSi.Location = new Point(19, 45);
            rb_BombilloSi.Margin = new Padding(3, 4, 3, 4);
            rb_BombilloSi.Name = "rb_BombilloSi";
            rb_BombilloSi.Size = new Size(42, 24);
            rb_BombilloSi.TabIndex = 5;
            rb_BombilloSi.TabStop = true;
            rb_BombilloSi.Text = "Sí";
            rb_BombilloSi.UseVisualStyleBackColor = true;
            // 
            // rb_BombilloNo
            // 
            rb_BombilloNo.AutoSize = true;
            rb_BombilloNo.Location = new Point(19, 95);
            rb_BombilloNo.Margin = new Padding(3, 4, 3, 4);
            rb_BombilloNo.Name = "rb_BombilloNo";
            rb_BombilloNo.Size = new Size(50, 24);
            rb_BombilloNo.TabIndex = 6;
            rb_BombilloNo.TabStop = true;
            rb_BombilloNo.Text = "No";
            rb_BombilloNo.UseVisualStyleBackColor = true;
            // 
            // PasoCorrederas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(group_Comentarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PasoCorrederas";
            Size = new Size(1081, 805);
            Load += PasoCorrederas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            groupBox1.ResumeLayout(false);
            group_Agujas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAgujas).EndInit();
            groupBombillo.ResumeLayout(false);
            groupBombillo.PerformLayout();
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
