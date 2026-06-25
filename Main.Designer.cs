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
            btn_GenerarActualizacion = new Button();
            btn_UpdateRotoData = new Button();
            btn_Salir = new Button();
            picture_Main = new PictureBox();
            pictureBox1 = new PictureBox();
            panel_Inferior = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel_dataVersion = new ToolStripStatusLabel();
            panel_Central = new Panel();
            panel_Header.SuspendLayout();
            panel_Sidebar.SuspendLayout();
            flowLayoutPanel_Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Inferior.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel_Central.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Clientes
            // 
            btn_Clientes.Font = new Font("Calibri", 9F);
            btn_Clientes.Image = (Image)resources.GetObject("btn_Clientes.Image");
            btn_Clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clientes.Location = new Point(3, 4);
            btn_Clientes.Margin = new Padding(3, 4, 3, 4);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Padding = new Padding(11, 0, 0, 0);
            btn_Clientes.Size = new Size(256, 75);
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
            btn_Mantenimiento.Location = new Point(3, 87);
            btn_Mantenimiento.Margin = new Padding(3, 4, 3, 4);
            btn_Mantenimiento.Name = "btn_Mantenimiento";
            btn_Mantenimiento.Padding = new Padding(11, 0, 0, 0);
            btn_Mantenimiento.Size = new Size(256, 75);
            btn_Mantenimiento.TabIndex = 1;
            btn_Mantenimiento.Text = "Mantenimiento";
            btn_Mantenimiento.UseVisualStyleBackColor = true;
            btn_Mantenimiento.Click += btn_Mantenimiento_Click;
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
            panel_Header.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 0;
            label1.Text = "Menú principal";
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
            panel_Sidebar.TabIndex = 35;
            // 
            // flowLayoutPanel_Sidebar
            // 
            flowLayoutPanel_Sidebar.AutoScroll = true;
            flowLayoutPanel_Sidebar.Controls.Add(btn_Clientes);
            flowLayoutPanel_Sidebar.Controls.Add(btn_Mantenimiento);
            flowLayoutPanel_Sidebar.Controls.Add(btn_Informes);
            flowLayoutPanel_Sidebar.Controls.Add(btn_GenerarActualizacion);
            flowLayoutPanel_Sidebar.Controls.Add(btn_UpdateRotoData);
            flowLayoutPanel_Sidebar.Controls.Add(btn_Salir);
            flowLayoutPanel_Sidebar.Dock = DockStyle.Fill;
            flowLayoutPanel_Sidebar.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Sidebar.Location = new Point(11, 13);
            flowLayoutPanel_Sidebar.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel_Sidebar.Name = "flowLayoutPanel_Sidebar";
            flowLayoutPanel_Sidebar.Size = new Size(264, 926);
            flowLayoutPanel_Sidebar.TabIndex = 0;
            flowLayoutPanel_Sidebar.WrapContents = false;
            // 
            // btn_Informes
            // 
            btn_Informes.Font = new Font("Calibri", 9F);
            btn_Informes.Image = (Image)resources.GetObject("btn_Informes.Image");
            btn_Informes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Informes.Location = new Point(3, 170);
            btn_Informes.Margin = new Padding(3, 4, 3, 4);
            btn_Informes.Name = "btn_Informes";
            btn_Informes.Padding = new Padding(11, 0, 0, 0);
            btn_Informes.Size = new Size(256, 75);
            btn_Informes.TabIndex = 2;
            btn_Informes.Text = "Informes";
            btn_Informes.UseVisualStyleBackColor = true;
            btn_Informes.Click += btn_Informes_Click;
            // 
            // btn_GenerarActualizacion
            // 
            btn_GenerarActualizacion.Font = new Font("Calibri", 9F);
            btn_GenerarActualizacion.Image = (Image)resources.GetObject("btn_GenerarActualizacion.Image");
            btn_GenerarActualizacion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GenerarActualizacion.Location = new Point(3, 253);
            btn_GenerarActualizacion.Margin = new Padding(3, 4, 3, 4);
            btn_GenerarActualizacion.Name = "btn_GenerarActualizacion";
            btn_GenerarActualizacion.Padding = new Padding(11, 0, 10, 0);
            btn_GenerarActualizacion.Size = new Size(256, 75);
            btn_GenerarActualizacion.TabIndex = 5;
            btn_GenerarActualizacion.Text = "Crear actualización de datos";
            btn_GenerarActualizacion.TextAlign = ContentAlignment.MiddleRight;
            btn_GenerarActualizacion.UseVisualStyleBackColor = true;
            btn_GenerarActualizacion.Click += btn_GenerarActualizacion_Click;
            // 
            // btn_UpdateRotoData
            // 
            btn_UpdateRotoData.Font = new Font("Calibri", 9F);
            btn_UpdateRotoData.Image = (Image)resources.GetObject("btn_UpdateRotoData.Image");
            btn_UpdateRotoData.ImageAlign = ContentAlignment.MiddleLeft;
            btn_UpdateRotoData.Location = new Point(3, 336);
            btn_UpdateRotoData.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateRotoData.Name = "btn_UpdateRotoData";
            btn_UpdateRotoData.Padding = new Padding(11, 0, 0, 0);
            btn_UpdateRotoData.Size = new Size(256, 75);
            btn_UpdateRotoData.TabIndex = 4;
            btn_UpdateRotoData.Text = "Actualizar datos Roto";
            btn_UpdateRotoData.UseVisualStyleBackColor = true;
            btn_UpdateRotoData.Click += btn_UpdateRotoData_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Dock = DockStyle.Bottom;
            btn_Salir.Font = new Font("Calibri", 9F);
            btn_Salir.Image = (Image)resources.GetObject("btn_Salir.Image");
            btn_Salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Salir.Location = new Point(3, 419);
            btn_Salir.Margin = new Padding(3, 4, 3, 4);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Padding = new Padding(11, 0, 0, 0);
            btn_Salir.Size = new Size(256, 75);
            btn_Salir.TabIndex = 3;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // picture_Main
            // 
            picture_Main.Dock = DockStyle.Fill;
            picture_Main.Image = (Image)resources.GetObject("picture_Main.Image");
            picture_Main.Location = new Point(80, 80);
            picture_Main.Name = "picture_Main";
            picture_Main.Padding = new Padding(80);
            picture_Main.Size = new Size(978, 573);
            picture_Main.SizeMode = PictureBoxSizeMode.Zoom;
            picture_Main.TabIndex = 36;
            picture_Main.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(833, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // panel_Inferior
            // 
            panel_Inferior.Controls.Add(statusStrip1);
            panel_Inferior.Controls.Add(pictureBox1);
            panel_Inferior.Dock = DockStyle.Bottom;
            panel_Inferior.Location = new Point(286, 813);
            panel_Inferior.Name = "panel_Inferior";
            panel_Inferior.Size = new Size(1138, 219);
            panel_Inferior.TabIndex = 38;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_dataVersion });
            statusStrip1.Location = new Point(0, 193);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1138, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 38;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_dataVersion
            // 
            toolStripStatusLabel_dataVersion.Name = "toolStripStatusLabel_dataVersion";
            toolStripStatusLabel_dataVersion.Size = new Size(151, 20);
            toolStripStatusLabel_dataVersion.Text = "toolStripStatusLabel1";
            // 
            // panel_Central
            // 
            panel_Central.Controls.Add(picture_Main);
            panel_Central.Dock = DockStyle.Fill;
            panel_Central.Location = new Point(286, 80);
            panel_Central.Name = "panel_Central";
            panel_Central.Padding = new Padding(80);
            panel_Central.Size = new Size(1138, 733);
            panel_Central.TabIndex = 39;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1424, 1032);
            Controls.Add(panel_Central);
            Controls.Add(panel_Inferior);
            Controls.Add(panel_Sidebar);
            Controls.Add(panel_Header);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1442, 1079);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RGC";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            panel_Sidebar.ResumeLayout(false);
            flowLayoutPanel_Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_Main).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Inferior.ResumeLayout(false);
            panel_Inferior.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel_Central.ResumeLayout(false);
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
        private PictureBox picture_Main;
        private PictureBox pictureBox1;
        private Panel panel_Inferior;
        private Panel panel_Central;
        private Button btn_Salir;
        private Button btn_UpdateRotoData;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel_dataVersion;
        private Button btn_GenerarActualizacion;
    }
}
