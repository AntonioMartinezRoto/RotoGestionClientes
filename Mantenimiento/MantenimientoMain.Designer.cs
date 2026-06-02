namespace RotoGestionClientes
{
    partial class MantenimientoMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoMain));
            panel_Header = new Panel();
            label1 = new Label();
            panel_Sidebar = new Panel();
            flowLayoutPanel_Sidebar = new FlowLayoutPanel();
            btn_Perfiles = new Button();
            dgvMaestros = new DataGridView();
            btn_Add = new Button();
            btn_Software = new Button();
            panel_Header.SuspendLayout();
            panel_Sidebar.SuspendLayout();
            flowLayoutPanel_Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).BeginInit();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.White;
            panel_Header.Controls.Add(label1);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Margin = new Padding(3, 4, 3, 4);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1424, 80);
            panel_Header.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de datos";
            // 
            // panel_Sidebar
            // 
            panel_Sidebar.AutoScroll = true;
            panel_Sidebar.BackColor = Color.White;
            panel_Sidebar.Controls.Add(flowLayoutPanel_Sidebar);
            panel_Sidebar.Dock = DockStyle.Left;
            panel_Sidebar.Location = new Point(0, 80);
            panel_Sidebar.Margin = new Padding(3, 4, 3, 4);
            panel_Sidebar.Name = "panel_Sidebar";
            panel_Sidebar.Padding = new Padding(11, 13, 11, 13);
            panel_Sidebar.Size = new Size(286, 952);
            panel_Sidebar.TabIndex = 34;
            // 
            // flowLayoutPanel_Sidebar
            // 
            flowLayoutPanel_Sidebar.AutoScroll = true;
            flowLayoutPanel_Sidebar.Controls.Add(btn_Perfiles);
            flowLayoutPanel_Sidebar.Controls.Add(btn_Software);
            flowLayoutPanel_Sidebar.Dock = DockStyle.Fill;
            flowLayoutPanel_Sidebar.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Sidebar.Location = new Point(11, 13);
            flowLayoutPanel_Sidebar.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel_Sidebar.Name = "flowLayoutPanel_Sidebar";
            flowLayoutPanel_Sidebar.Size = new Size(264, 926);
            flowLayoutPanel_Sidebar.TabIndex = 0;
            flowLayoutPanel_Sidebar.WrapContents = false;
            // 
            // btn_Perfiles
            // 
            btn_Perfiles.Font = new Font("Calibri", 9F);
            btn_Perfiles.Image = (Image)resources.GetObject("btn_Perfiles.Image");
            btn_Perfiles.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Perfiles.Location = new Point(3, 4);
            btn_Perfiles.Margin = new Padding(3, 4, 3, 4);
            btn_Perfiles.Name = "btn_Perfiles";
            btn_Perfiles.Padding = new Padding(11, 0, 0, 0);
            btn_Perfiles.Size = new Size(256, 75);
            btn_Perfiles.TabIndex = 32;
            btn_Perfiles.Text = "Perfiles";
            btn_Perfiles.UseVisualStyleBackColor = true;
            btn_Perfiles.Click += btn_Perfiles_Click;
            // 
            // dgvMaestros
            // 
            dgvMaestros.AllowUserToAddRows = false;
            dgvMaestros.AllowUserToDeleteRows = false;
            dgvMaestros.AllowUserToOrderColumns = true;
            dgvMaestros.AllowUserToResizeRows = false;
            dgvMaestros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMaestros.BackgroundColor = SystemColors.ActiveCaption;
            dgvMaestros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaestros.Location = new Point(328, 150);
            dgvMaestros.Margin = new Padding(3, 4, 3, 4);
            dgvMaestros.Name = "dgvMaestros";
            dgvMaestros.ReadOnly = true;
            dgvMaestros.RowHeadersVisible = false;
            dgvMaestros.RowHeadersWidth = 51;
            dgvMaestros.Size = new Size(1011, 845);
            dgvMaestros.TabIndex = 35;
            dgvMaestros.CellClick += dgvMaestros_CellClick;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(328, 99);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(37, 43);
            btn_Add.TabIndex = 36;
            btn_Add.Text = " +";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Software
            // 
            btn_Software.Font = new Font("Calibri", 9F);
            btn_Software.Image = (Image)resources.GetObject("btn_Software.Image");
            btn_Software.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Software.Location = new Point(3, 87);
            btn_Software.Margin = new Padding(3, 4, 3, 4);
            btn_Software.Name = "btn_Software";
            btn_Software.Padding = new Padding(11, 0, 0, 0);
            btn_Software.Size = new Size(256, 75);
            btn_Software.TabIndex = 33;
            btn_Software.Text = "Softwares";
            btn_Software.UseVisualStyleBackColor = true;
            btn_Software.Click += btn_Software_Click;
            // 
            // MantenimientoMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1424, 1032);
            Controls.Add(btn_Add);
            Controls.Add(dgvMaestros);
            Controls.Add(panel_Sidebar);
            Controls.Add(panel_Header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantenimientoMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento";
            Load += ClientesMain_Load;
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            panel_Sidebar.ResumeLayout(false);
            flowLayoutPanel_Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Header;
        private Label label1;
        private Panel panel_Sidebar;
        private FlowLayoutPanel flowLayoutPanel_Sidebar;
        private Button btn_Perfiles;
        private DataGridView dgvMaestros;
        private Button btn_Add;
        private Button btn_Software;
    }
}