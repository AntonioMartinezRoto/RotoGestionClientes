namespace RotoGestionClientes
{
    partial class InformesMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformesMain));
            dgvResultados = new DataGridView();
            lbl_Filtro = new Label();
            txt_Filtro = new TextBox();
            lbl_Total = new Label();
            panel_Header = new Panel();
            label1 = new Label();
            panel_Sidebar = new Panel();
            flowLayoutPanel_Sidebar = new FlowLayoutPanel();
            btn_ExportExcel = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            panel_Header.SuspendLayout();
            panel_Sidebar.SuspendLayout();
            flowLayoutPanel_Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AllowUserToOrderColumns = true;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados.BackgroundColor = SystemColors.ActiveCaption;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(346, 299);
            dgvResultados.Margin = new Padding(3, 4, 3, 4);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(1011, 695);
            dgvResultados.TabIndex = 1;
            // 
            // lbl_Filtro
            // 
            lbl_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Filtro.AutoSize = true;
            lbl_Filtro.BackColor = Color.Transparent;
            lbl_Filtro.Location = new Point(1121, 268);
            lbl_Filtro.Name = "lbl_Filtro";
            lbl_Filtro.Size = new Size(52, 20);
            lbl_Filtro.TabIndex = 29;
            lbl_Filtro.Text = "Buscar";
            // 
            // txt_Filtro
            // 
            txt_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Filtro.Location = new Point(1176, 264);
            txt_Filtro.Margin = new Padding(3, 4, 3, 4);
            txt_Filtro.Name = "txt_Filtro";
            txt_Filtro.Size = new Size(181, 27);
            txt_Filtro.TabIndex = 28;
            txt_Filtro.TextChanged += txt_Filtro_TextChanged;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.BackColor = Color.Transparent;
            lbl_Total.Location = new Point(346, 268);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(57, 20);
            lbl_Total.TabIndex = 32;
            lbl_Total.Text = "Total: 0";
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
            label1.Size = new Size(117, 32);
            label1.TabIndex = 0;
            label1.Text = "Informes";
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
            flowLayoutPanel_Sidebar.Controls.Add(btn_ExportExcel);
            flowLayoutPanel_Sidebar.Dock = DockStyle.Fill;
            flowLayoutPanel_Sidebar.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Sidebar.Location = new Point(11, 13);
            flowLayoutPanel_Sidebar.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel_Sidebar.Name = "flowLayoutPanel_Sidebar";
            flowLayoutPanel_Sidebar.Size = new Size(264, 926);
            flowLayoutPanel_Sidebar.TabIndex = 0;
            flowLayoutPanel_Sidebar.WrapContents = false;
            // 
            // btn_ExportExcel
            // 
            btn_ExportExcel.Font = new Font("Calibri", 9F);
            btn_ExportExcel.Image = (Image)resources.GetObject("btn_ExportExcel.Image");
            btn_ExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ExportExcel.Location = new Point(3, 4);
            btn_ExportExcel.Margin = new Padding(3, 4, 3, 4);
            btn_ExportExcel.Name = "btn_ExportExcel";
            btn_ExportExcel.Padding = new Padding(11, 0, 0, 0);
            btn_ExportExcel.Size = new Size(256, 75);
            btn_ExportExcel.TabIndex = 32;
            btn_ExportExcel.Text = "Exportar a Excel";
            btn_ExportExcel.UseVisualStyleBackColor = true;
            btn_ExportExcel.Click += btn_ExportExcel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(286, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 151);
            panel1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 0;
            label2.Text = "Filtros";
            // 
            // InformesMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1424, 1032);
            Controls.Add(panel1);
            Controls.Add(panel_Sidebar);
            Controls.Add(panel_Header);
            Controls.Add(lbl_Total);
            Controls.Add(lbl_Filtro);
            Controls.Add(txt_Filtro);
            Controls.Add(dgvResultados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "InformesMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Infomes";
            Load += InformesMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            panel_Sidebar.ResumeLayout(false);
            flowLayoutPanel_Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResultados;
        private Label lbl_Filtro;
        private TextBox txt_Filtro;
        private Label lbl_Total;
        private Panel panel_Header;
        private Label label1;
        private Panel panel_Sidebar;
        private FlowLayoutPanel flowLayoutPanel_Sidebar;
        private Button btn_ExportExcel;
        private Panel panel1;
        private Label label2;
    }
}