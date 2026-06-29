namespace RotoGestionClientes
{
    partial class ClienteExportacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteExportacion));
            btn_Aceptar = new Button();
            group_Clientes = new GroupBox();
            dgvClientes = new DataGridView();
            lbl_Filtro = new Label();
            txt_Filtro = new TextBox();
            chkSeleccionarTodos = new CheckBox();
            lblSeleccionados = new Label();
            group_Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(554, 990);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(11, 0, 15, 0);
            btn_Aceptar.Size = new Size(155, 45);
            btn_Aceptar.TabIndex = 12;
            btn_Aceptar.Text = "Exportar";
            btn_Aceptar.TextAlign = ContentAlignment.MiddleRight;
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // group_Clientes
            // 
            group_Clientes.Controls.Add(dgvClientes);
            group_Clientes.Location = new Point(32, 85);
            group_Clientes.Margin = new Padding(3, 4, 3, 4);
            group_Clientes.Name = "group_Clientes";
            group_Clientes.Padding = new Padding(3, 4, 3, 4);
            group_Clientes.Size = new Size(677, 882);
            group_Clientes.TabIndex = 11;
            group_Clientes.TabStop = false;
            group_Clientes.Text = "Seleccionar clientes para exportar";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.ColumnHeadersVisible = false;
            dgvClientes.Location = new Point(7, 29);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(664, 845);
            dgvClientes.TabIndex = 2;
            dgvClientes.CellValueChanged += dgvClientes_CellValueChanged;
            dgvClientes.CurrentCellDirtyStateChanged += dgvClientes_CurrentCellDirtyStateChanged;
            // 
            // lbl_Filtro
            // 
            lbl_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Filtro.AutoSize = true;
            lbl_Filtro.BackColor = Color.Transparent;
            lbl_Filtro.Location = new Point(456, 54);
            lbl_Filtro.Name = "lbl_Filtro";
            lbl_Filtro.Size = new Size(52, 20);
            lbl_Filtro.TabIndex = 31;
            lbl_Filtro.Text = "Buscar";
            // 
            // txt_Filtro
            // 
            txt_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Filtro.Location = new Point(528, 50);
            txt_Filtro.Margin = new Padding(3, 4, 3, 4);
            txt_Filtro.Name = "txt_Filtro";
            txt_Filtro.Size = new Size(181, 27);
            txt_Filtro.TabIndex = 30;
            txt_Filtro.TextChanged += txt_Filtro_TextChanged;
            // 
            // chkSeleccionarTodos
            // 
            chkSeleccionarTodos.AutoSize = true;
            chkSeleccionarTodos.Location = new Point(39, 50);
            chkSeleccionarTodos.Name = "chkSeleccionarTodos";
            chkSeleccionarTodos.Size = new Size(149, 24);
            chkSeleccionarTodos.TabIndex = 32;
            chkSeleccionarTodos.Text = "Seleccionar todos";
            chkSeleccionarTodos.UseVisualStyleBackColor = true;
            chkSeleccionarTodos.CheckedChanged += chkSeleccionarTodos_CheckedChanged;
            // 
            // lblSeleccionados
            // 
            lblSeleccionados.AutoSize = true;
            lblSeleccionados.Location = new Point(217, 51);
            lblSeleccionados.Name = "lblSeleccionados";
            lblSeleccionados.Size = new Size(119, 20);
            lblSeleccionados.TabIndex = 33;
            lblSeleccionados.Text = "Seleccionados: 0";
            // 
            // ClienteExportacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(733, 1059);
            Controls.Add(lblSeleccionados);
            Controls.Add(chkSeleccionarTodos);
            Controls.Add(lbl_Filtro);
            Controls.Add(txt_Filtro);
            Controls.Add(btn_Aceptar);
            Controls.Add(group_Clientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClienteExportacion";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ClienteExportacion_Load;
            group_Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aceptar;
        private GroupBox group_Clientes;
        private DataGridView dgvClientes;
        private Label lbl_Filtro;
        private TextBox txt_Filtro;
        private CheckBox chkSeleccionarTodos;
        private Label lblSeleccionados;
    }
}