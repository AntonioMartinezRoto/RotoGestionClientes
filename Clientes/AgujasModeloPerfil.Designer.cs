namespace RotoGestionClientes
{
    partial class AgujasModeloPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgujasModeloPerfil));
            group_Agujas = new GroupBox();
            dgvAgujas = new DataGridView();
            btn_Aceptar = new Button();
            group_Agujas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgujas).BeginInit();
            SuspendLayout();
            // 
            // group_Agujas
            // 
            group_Agujas.Controls.Add(dgvAgujas);
            group_Agujas.Location = new Point(37, 30);
            group_Agujas.Name = "group_Agujas";
            group_Agujas.Size = new Size(386, 171);
            group_Agujas.TabIndex = 7;
            group_Agujas.TabStop = false;
            group_Agujas.Text = "Seguridad";
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
            dgvAgujas.Size = new Size(374, 143);
            dgvAgujas.TabIndex = 2;
            dgvAgujas.CellClick += dgvAgujas_CellClick;
            dgvAgujas.CellMouseUp += dgvAgujas_CellMouseUp;
            dgvAgujas.EditingControlShowing += dgvAgujas_EditingControlShowing;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(313, 225);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(10, 0, 0, 0);
            btn_Aceptar.Size = new Size(110, 34);
            btn_Aceptar.TabIndex = 8;
            btn_Aceptar.Text = "Guardar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // AgujasModeloPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(471, 289);
            Controls.Add(btn_Aceptar);
            Controls.Add(group_Agujas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AgujasModeloPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Definir agujas por perfil";
            group_Agujas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAgujas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox group_Agujas;
        private DataGridView dgvAgujas;
        private Button btn_Aceptar;
    }
}