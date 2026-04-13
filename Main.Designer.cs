namespace RotoGestionClientes
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btn_Clientes = new Button();
            btn_Mantenimiento = new Button();
            panel_Header = new Panel();
            label1 = new Label();
            panel_Sidebar = new Panel();
            flowLayoutPanel_Sidebar = new FlowLayoutPanel();
            btn_Informes = new Button();
            panel_Header.SuspendLayout();
            panel_Sidebar.SuspendLayout();
            flowLayoutPanel_Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Clientes
            // 
            btn_Clientes.Font = new Font("Calibri", 9F);
            btn_Clientes.Image = (Image)resources.GetObject("btn_Clientes.Image");
            btn_Clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clientes.Location = new Point(3, 3);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Padding = new Padding(10, 0, 0, 0);
            btn_Clientes.Size = new Size(224, 56);
            btn_Clientes.TabIndex = 0;
            btn_Clientes.Text = "Clientes";
            btn_Clientes.UseVisualStyleBackColor = true;
            btn_Clientes.Click += btn_Clientes_Click;
            // 
            // btn_Mantenimiento
            // 
            btn_Mantenimiento.Font = new Font("Calibri", 9F);
            btn_Mantenimiento.Image = (Image)resources.GetObject("btn_Mantenimiento.Image");
            btn_Mantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Mantenimiento.Location = new Point(3, 65);
            btn_Mantenimiento.Name = "btn_Mantenimiento";
            btn_Mantenimiento.Padding = new Padding(10, 0, 0, 0);
            btn_Mantenimiento.Size = new Size(224, 56);
            btn_Mantenimiento.TabIndex = 1;
            btn_Mantenimiento.Text = "Mantenimiento";
            btn_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.White;
            panel_Header.Controls.Add(label1);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1246, 60);
            panel_Header.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Menú principal";
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
            panel_Sidebar.Size = new Size(250, 714);
            panel_Sidebar.TabIndex = 35;
            // 
            // flowLayoutPanel_Sidebar
            // 
            flowLayoutPanel_Sidebar.AutoScroll = true;
            flowLayoutPanel_Sidebar.Controls.Add(btn_Clientes);
            flowLayoutPanel_Sidebar.Controls.Add(btn_Mantenimiento);
            flowLayoutPanel_Sidebar.Controls.Add(btn_Informes);
            flowLayoutPanel_Sidebar.Dock = DockStyle.Fill;
            flowLayoutPanel_Sidebar.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Sidebar.Location = new Point(10, 10);
            flowLayoutPanel_Sidebar.Name = "flowLayoutPanel_Sidebar";
            flowLayoutPanel_Sidebar.Size = new Size(230, 694);
            flowLayoutPanel_Sidebar.TabIndex = 0;
            flowLayoutPanel_Sidebar.WrapContents = false;
            // 
            // btn_Informes
            // 
            btn_Informes.Font = new Font("Calibri", 9F);
            btn_Informes.Image = (Image)resources.GetObject("btn_Informes.Image");
            btn_Informes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Informes.Location = new Point(3, 127);
            btn_Informes.Name = "btn_Informes";
            btn_Informes.Padding = new Padding(10, 0, 0, 0);
            btn_Informes.Size = new Size(224, 56);
            btn_Informes.TabIndex = 2;
            btn_Informes.Text = "Informes";
            btn_Informes.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1246, 774);
            Controls.Add(panel_Sidebar);
            Controls.Add(panel_Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RotoGestionClientes";
            Load += Main_Load;
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            panel_Sidebar.ResumeLayout(false);
            flowLayoutPanel_Sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Clientes;
        private Button btn_Mantenimiento;
        private Panel panel_Header;
        private Label label1;
        private Panel panel_Sidebar;
        private FlowLayoutPanel flowLayoutPanel_Sidebar;
        private Button btn_Informes;
    }
}
