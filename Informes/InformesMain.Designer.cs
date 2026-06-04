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
            btn_MaquinasTipo = new Button();
            btn_Bisagras = new Button();
            btn_LimpiarFiltros = new Button();
            btn_Buscar = new Button();
            btn_Manillas = new Button();
            btn_Software = new Button();
            label2 = new Label();
            btn_Cerraduras = new Button();
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
            panel1.Controls.Add(btn_Cerraduras);
            panel1.Controls.Add(btn_MaquinasTipo);
            panel1.Controls.Add(btn_Bisagras);
            panel1.Controls.Add(btn_LimpiarFiltros);
            panel1.Controls.Add(btn_Buscar);
            panel1.Controls.Add(btn_Manillas);
            panel1.Controls.Add(btn_Software);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(286, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 146);
            panel1.TabIndex = 35;
            // 
            // btn_MaquinasTipo
            // 
            btn_MaquinasTipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_MaquinasTipo.FlatStyle = FlatStyle.Flat;
            btn_MaquinasTipo.Image = (Image)resources.GetObject("btn_MaquinasTipo.Image");
            btn_MaquinasTipo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_MaquinasTipo.Location = new Point(731, 51);
            btn_MaquinasTipo.Margin = new Padding(3, 4, 3, 4);
            btn_MaquinasTipo.Name = "btn_MaquinasTipo";
            btn_MaquinasTipo.Padding = new Padding(11, 0, 0, 0);
            btn_MaquinasTipo.Size = new Size(137, 41);
            btn_MaquinasTipo.TabIndex = 16;
            btn_MaquinasTipo.Text = "Máquinas";
            btn_MaquinasTipo.UseVisualStyleBackColor = true;
            btn_MaquinasTipo.Click += btn_MaquinasTipo_Click;
            // 
            // btn_Bisagras
            // 
            btn_Bisagras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Bisagras.FlatStyle = FlatStyle.Flat;
            btn_Bisagras.Image = (Image)resources.GetObject("btn_Bisagras.Image");
            btn_Bisagras.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Bisagras.Location = new Point(233, 51);
            btn_Bisagras.Margin = new Padding(3, 4, 3, 4);
            btn_Bisagras.Name = "btn_Bisagras";
            btn_Bisagras.Padding = new Padding(11, 0, 0, 0);
            btn_Bisagras.Size = new Size(137, 41);
            btn_Bisagras.TabIndex = 15;
            btn_Bisagras.Text = "Bisagras";
            btn_Bisagras.UseVisualStyleBackColor = true;
            btn_Bisagras.Click += btn_Bisagras_Click;
            // 
            // btn_LimpiarFiltros
            // 
            btn_LimpiarFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_LimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btn_LimpiarFiltros.Image = (Image)resources.GetObject("btn_LimpiarFiltros.Image");
            btn_LimpiarFiltros.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LimpiarFiltros.Location = new Point(910, 29);
            btn_LimpiarFiltros.Margin = new Padding(3, 4, 3, 4);
            btn_LimpiarFiltros.Name = "btn_LimpiarFiltros";
            btn_LimpiarFiltros.Padding = new Padding(11, 0, 0, 0);
            btn_LimpiarFiltros.Size = new Size(161, 41);
            btn_LimpiarFiltros.TabIndex = 14;
            btn_LimpiarFiltros.Text = "Limpiar Filtros";
            btn_LimpiarFiltros.UseVisualStyleBackColor = true;
            btn_LimpiarFiltros.Click += btn_LimpiarFiltros_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Image = (Image)resources.GetObject("btn_Buscar.Image");
            btn_Buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Buscar.Location = new Point(910, 89);
            btn_Buscar.Margin = new Padding(3, 4, 3, 4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Padding = new Padding(11, 0, 0, 0);
            btn_Buscar.Size = new Size(161, 41);
            btn_Buscar.TabIndex = 13;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Manillas
            // 
            btn_Manillas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Manillas.FlatStyle = FlatStyle.Flat;
            btn_Manillas.Image = (Image)resources.GetObject("btn_Manillas.Image");
            btn_Manillas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Manillas.Location = new Point(60, 51);
            btn_Manillas.Margin = new Padding(3, 4, 3, 4);
            btn_Manillas.Name = "btn_Manillas";
            btn_Manillas.Padding = new Padding(11, 0, 0, 0);
            btn_Manillas.Size = new Size(137, 41);
            btn_Manillas.TabIndex = 12;
            btn_Manillas.Text = "Manillas";
            btn_Manillas.UseVisualStyleBackColor = true;
            btn_Manillas.Click += btn_Manillas_Click;
            // 
            // btn_Software
            // 
            btn_Software.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Software.FlatStyle = FlatStyle.Flat;
            btn_Software.Image = (Image)resources.GetObject("btn_Software.Image");
            btn_Software.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Software.Location = new Point(566, 51);
            btn_Software.Margin = new Padding(3, 4, 3, 4);
            btn_Software.Name = "btn_Software";
            btn_Software.Padding = new Padding(11, 0, 0, 0);
            btn_Software.Size = new Size(137, 41);
            btn_Software.TabIndex = 11;
            btn_Software.Text = "Sofware";
            btn_Software.UseVisualStyleBackColor = true;
            btn_Software.Click += btn_Software_Click;
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
            // btn_Cerraduras
            // 
            btn_Cerraduras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerraduras.FlatStyle = FlatStyle.Flat;
            btn_Cerraduras.Image = (Image)resources.GetObject("btn_Cerraduras.Image");
            btn_Cerraduras.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cerraduras.Location = new Point(402, 51);
            btn_Cerraduras.Margin = new Padding(3, 4, 3, 4);
            btn_Cerraduras.Name = "btn_Cerraduras";
            btn_Cerraduras.Padding = new Padding(11, 0, 0, 0);
            btn_Cerraduras.Size = new Size(137, 41);
            btn_Cerraduras.TabIndex = 17;
            btn_Cerraduras.Text = "Cerraduras";
            btn_Cerraduras.UseVisualStyleBackColor = true;
            btn_Cerraduras.Click += btn_Cerraduras_Click;
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
        private Button btn_Manillas;
        private Button btn_Software;
        private Button btn_Buscar;
        private Button btn_LimpiarFiltros;
        private Button btn_Bisagras;
        private Button btn_MaquinasTipo;
        private Button btn_Cerraduras;
    }
}