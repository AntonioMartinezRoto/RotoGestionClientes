namespace RotoGestionClientes
{
    partial class ClientesEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesEditForm));
            dgvSeguridad = new DataGridView();
            group_Seguridad = new GroupBox();
            group_Pasivas = new GroupBox();
            dgvPasivas = new DataGridView();
            btn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).BeginInit();
            group_Seguridad.SuspendLayout();
            group_Pasivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).BeginInit();
            SuspendLayout();
            // 
            // dgvSeguridad
            // 
            dgvSeguridad.AllowUserToAddRows = false;
            dgvSeguridad.AllowUserToDeleteRows = false;
            dgvSeguridad.AllowUserToOrderColumns = true;
            dgvSeguridad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSeguridad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguridad.Location = new Point(17, 22);
            dgvSeguridad.Name = "dgvSeguridad";
            dgvSeguridad.ReadOnly = true;
            dgvSeguridad.Size = new Size(249, 102);
            dgvSeguridad.TabIndex = 2;
            dgvSeguridad.CellMouseUp += dgvSeguridad_CellMouseUp;
            // 
            // group_Seguridad
            // 
            group_Seguridad.Controls.Add(dgvSeguridad);
            group_Seguridad.Location = new Point(63, 79);
            group_Seguridad.Name = "group_Seguridad";
            group_Seguridad.Size = new Size(289, 142);
            group_Seguridad.TabIndex = 3;
            group_Seguridad.TabStop = false;
            group_Seguridad.Text = "Seguridad";
            // 
            // group_Pasivas
            // 
            group_Pasivas.Controls.Add(dgvPasivas);
            group_Pasivas.Location = new Point(374, 79);
            group_Pasivas.Name = "group_Pasivas";
            group_Pasivas.Size = new Size(289, 142);
            group_Pasivas.TabIndex = 4;
            group_Pasivas.TabStop = false;
            group_Pasivas.Text = "Cremona Pasiva";
            // 
            // dgvPasivas
            // 
            dgvPasivas.AllowUserToAddRows = false;
            dgvPasivas.AllowUserToDeleteRows = false;
            dgvPasivas.AllowUserToOrderColumns = true;
            dgvPasivas.Anchor = AnchorStyles.None;
            dgvPasivas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasivas.Location = new Point(17, 22);
            dgvPasivas.Name = "dgvPasivas";
            dgvPasivas.ReadOnly = true;
            dgvPasivas.Size = new Size(254, 102);
            dgvPasivas.TabIndex = 2;
            // 
            // btn_Save
            // 
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.Location = new Point(817, 704);
            btn_Save.Margin = new Padding(0);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(87, 41);
            btn_Save.TabIndex = 9;
            btn_Save.Text = "Guardar";
            btn_Save.TextAlign = ContentAlignment.MiddleRight;
            btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // ClientesEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(964, 788);
            Controls.Add(btn_Save);
            Controls.Add(group_Pasivas);
            Controls.Add(group_Seguridad);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClientesEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ClientesEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSeguridad).EndInit();
            group_Seguridad.ResumeLayout(false);
            group_Pasivas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPasivas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Seguridad;
        private DataGridView dgvSeguridad;
        private GroupBox group_Seguridad;
        private GroupBox group_Pasivas;
        private DataGridView dgvPasivas;
        private Button btn_Save;
    }
}