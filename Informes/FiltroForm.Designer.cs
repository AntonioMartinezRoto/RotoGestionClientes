namespace RotoGestionClientes
{
    partial class FiltroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroForm));
            btn_Aceptar = new Button();
            group_Filtro = new GroupBox();
            dgvItems = new DataGridView();
            group_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(362, 437);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(11, 0, 0, 0);
            btn_Aceptar.Size = new Size(126, 45);
            btn_Aceptar.TabIndex = 10;
            btn_Aceptar.Text = "Guardar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // group_Filtro
            // 
            group_Filtro.Controls.Add(dgvItems);
            group_Filtro.Location = new Point(47, 48);
            group_Filtro.Margin = new Padding(3, 4, 3, 4);
            group_Filtro.Name = "group_Filtro";
            group_Filtro.Padding = new Padding(3, 4, 3, 4);
            group_Filtro.Size = new Size(441, 361);
            group_Filtro.TabIndex = 9;
            group_Filtro.TabStop = false;
            group_Filtro.Text = "Seleccionar";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToOrderColumns = true;
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.ColumnHeadersVisible = false;
            dgvItems.Location = new Point(7, 28);
            dgvItems.Margin = new Padding(3, 4, 3, 4);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(428, 325);
            dgvItems.TabIndex = 2;
            // 
            // FiltroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(556, 516);
            Controls.Add(btn_Aceptar);
            Controls.Add(group_Filtro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FiltroForm";
            StartPosition = FormStartPosition.CenterScreen;
            group_Filtro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Aceptar;
        private GroupBox group_Filtro;
        private DataGridView dgvItems;
    }
}