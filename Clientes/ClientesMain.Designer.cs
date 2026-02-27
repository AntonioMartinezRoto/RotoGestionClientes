namespace RotoGestionClientes
{
    partial class ClientesMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesMain));
            dgvClientes = new DataGridView();
            lbl_Filtro = new Label();
            txt_Filtro = new TextBox();
            btn_Add = new Button();
            lbl_Total = new Label();
            panel_Header = new Panel();
            label1 = new Label();
            panel_Sidebar = new Panel();
            flowLayoutPanel_Sidebar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel_Header.SuspendLayout();
            panel_Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = SystemColors.ActiveCaption;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(163, 112);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(1025, 634);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // lbl_Filtro
            // 
            lbl_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Filtro.AutoSize = true;
            lbl_Filtro.BackColor = Color.Transparent;
            lbl_Filtro.Location = new Point(981, 86);
            lbl_Filtro.Name = "lbl_Filtro";
            lbl_Filtro.Size = new Size(42, 15);
            lbl_Filtro.TabIndex = 29;
            lbl_Filtro.Text = "Buscar";
            // 
            // txt_Filtro
            // 
            txt_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Filtro.Location = new Point(1029, 83);
            txt_Filtro.Name = "txt_Filtro";
            txt_Filtro.Size = new Size(159, 23);
            txt_Filtro.TabIndex = 28;
            txt_Filtro.TextChanged += txt_Filtro_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.BackgroundImage = (Image)resources.GetObject("btn_Add.BackgroundImage");
            btn_Add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Add.Location = new Point(163, 81);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(26, 25);
            btn_Add.TabIndex = 31;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // lbl_Total
            // 
            lbl_Total.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Total.AutoSize = true;
            lbl_Total.BackColor = Color.Transparent;
            lbl_Total.Location = new Point(163, 749);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(44, 15);
            lbl_Total.TabIndex = 32;
            lbl_Total.Text = "Total: 0";
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.White;
            panel_Header.Controls.Add(label1);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1246, 60);
            panel_Header.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 0;
            label1.Text = "Listado de clientes";
            // 
            // panel_Sidebar
            // 
            panel_Sidebar.AutoScroll = true;
            panel_Sidebar.BackColor = Color.White;
            panel_Sidebar.Controls.Add(flowLayoutPanel_Sidebar);
            panel_Sidebar.Dock = DockStyle.Left;
            panel_Sidebar.Location = new Point(0, 60);
            panel_Sidebar.Name = "panel_Sidebar";
            panel_Sidebar.Padding = new Padding(10);
            panel_Sidebar.Size = new Size(106, 714);
            panel_Sidebar.TabIndex = 34;
            // 
            // flowLayoutPanel_Sidebar
            // 
            flowLayoutPanel_Sidebar.AutoScroll = true;
            flowLayoutPanel_Sidebar.Dock = DockStyle.Fill;
            flowLayoutPanel_Sidebar.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Sidebar.Location = new Point(10, 10);
            flowLayoutPanel_Sidebar.Name = "flowLayoutPanel_Sidebar";
            flowLayoutPanel_Sidebar.Size = new Size(86, 694);
            flowLayoutPanel_Sidebar.TabIndex = 0;
            flowLayoutPanel_Sidebar.WrapContents = false;
            // 
            // ClientesMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1246, 774);
            Controls.Add(panel_Sidebar);
            Controls.Add(panel_Header);
            Controls.Add(lbl_Total);
            Controls.Add(btn_Add);
            Controls.Add(lbl_Filtro);
            Controls.Add(txt_Filtro);
            Controls.Add(dgvClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClientesMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += ClientesMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            panel_Sidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label lbl_Filtro;
        private TextBox txt_Filtro;
        private Button btn_Add;
        private Label lbl_Total;
        private Panel panel_Header;
        private Label label1;
        private Panel panel_Sidebar;
        private FlowLayoutPanel flowLayoutPanel_Sidebar;
    }
}