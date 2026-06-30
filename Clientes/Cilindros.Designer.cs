namespace RotoGestionClientes
{
    partial class Cilindros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cilindros));
            btn_Aceptar = new Button();
            group_Cilindros = new GroupBox();
            dgvCilindros = new DataGridView();
            group_Cilindros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCilindros).BeginInit();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(362, 861);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(11, 0, 0, 0);
            btn_Aceptar.Size = new Size(126, 45);
            btn_Aceptar.TabIndex = 10;
            btn_Aceptar.Text = "Guardar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // group_Cilindros
            // 
            group_Cilindros.Controls.Add(dgvCilindros);
            group_Cilindros.Location = new Point(47, 28);
            group_Cilindros.Margin = new Padding(3, 4, 3, 4);
            group_Cilindros.Name = "group_Cilindros";
            group_Cilindros.Padding = new Padding(3, 4, 3, 4);
            group_Cilindros.Size = new Size(441, 813);
            group_Cilindros.TabIndex = 9;
            group_Cilindros.TabStop = false;
            group_Cilindros.Text = "Cilindros";
            // 
            // dgvCilindros
            // 
            dgvCilindros.AllowUserToAddRows = false;
            dgvCilindros.AllowUserToDeleteRows = false;
            dgvCilindros.AllowUserToOrderColumns = true;
            dgvCilindros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCilindros.BackgroundColor = Color.White;
            dgvCilindros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCilindros.Location = new Point(7, 29);
            dgvCilindros.Margin = new Padding(3, 4, 3, 4);
            dgvCilindros.Name = "dgvCilindros";
            dgvCilindros.RowHeadersWidth = 51;
            dgvCilindros.Size = new Size(415, 764);
            dgvCilindros.TabIndex = 2;
            dgvCilindros.CellMouseUp += dgvCilindros_CellMouseUp;
            // 
            // Cilindros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(538, 919);
            Controls.Add(btn_Aceptar);
            Controls.Add(group_Cilindros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Cilindros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar cilindros";
            group_Cilindros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCilindros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Aceptar;
        private GroupBox group_Cilindros;
        private DataGridView dgvCilindros;
    }
}