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
            group_Agujas = new GroupBox();
            dgvCilindros = new DataGridView();
            group_Agujas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCilindros).BeginInit();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(317, 646);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(10, 0, 0, 0);
            btn_Aceptar.Size = new Size(110, 34);
            btn_Aceptar.TabIndex = 10;
            btn_Aceptar.Text = "Guardar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // group_Agujas
            // 
            group_Agujas.Controls.Add(dgvCilindros);
            group_Agujas.Location = new Point(41, 21);
            group_Agujas.Name = "group_Agujas";
            group_Agujas.Size = new Size(386, 610);
            group_Agujas.TabIndex = 9;
            group_Agujas.TabStop = false;
            group_Agujas.Text = "Cilindros";
            // 
            // dgvCilindros
            // 
            dgvCilindros.AllowUserToAddRows = false;
            dgvCilindros.AllowUserToDeleteRows = false;
            dgvCilindros.AllowUserToOrderColumns = true;
            dgvCilindros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCilindros.BackgroundColor = Color.White;
            dgvCilindros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCilindros.Location = new Point(6, 22);
            dgvCilindros.Name = "dgvCilindros";
            dgvCilindros.Size = new Size(363, 573);
            dgvCilindros.TabIndex = 2;
            dgvCilindros.CellMouseUp += dgvCilindros_CellMouseUp;
            // 
            // Cilindros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(471, 689);
            Controls.Add(btn_Aceptar);
            Controls.Add(group_Agujas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Cilindros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar cilindros";
            group_Agujas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCilindros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Aceptar;
        private GroupBox group_Agujas;
        private DataGridView dgvCilindros;
    }
}