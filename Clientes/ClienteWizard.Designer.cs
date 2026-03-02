namespace RotoGestionClientes
{
    partial class ClienteWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteWizard));
            panel_Header = new Panel();
            lbl_Subtitulo = new Label();
            lbl_Titulo = new Label();
            panel_Footer = new Panel();
            btn_Atras = new Button();
            btn_Cancelar = new Button();
            btn_Siguiente = new Button();
            btn_Finalizar = new Button();
            panel_Sidebar = new Panel();
            flowLayoutPanel_Sidebar = new FlowLayoutPanel();
            panel_Content = new Panel();
            panel_Header.SuspendLayout();
            panel_Footer.SuspendLayout();
            panel_Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.White;
            panel_Header.Controls.Add(lbl_Subtitulo);
            panel_Header.Controls.Add(lbl_Titulo);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1246, 60);
            panel_Header.TabIndex = 0;
            // 
            // lbl_Subtitulo
            // 
            lbl_Subtitulo.AutoSize = true;
            lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            lbl_Subtitulo.ForeColor = Color.DimGray;
            lbl_Subtitulo.Location = new Point(28, 33);
            lbl_Subtitulo.Name = "lbl_Subtitulo";
            lbl_Subtitulo.Size = new Size(214, 15);
            lbl_Subtitulo.TabIndex = 1;
            lbl_Subtitulo.Text = "Completa los datos para crear el cliente";
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_Titulo.Location = new Point(25, 8);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(134, 25);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Nuevo cliente";
            // 
            // panel_Footer
            // 
            panel_Footer.BackColor = Color.White;
            panel_Footer.Controls.Add(btn_Atras);
            panel_Footer.Controls.Add(btn_Cancelar);
            panel_Footer.Controls.Add(btn_Siguiente);
            panel_Footer.Controls.Add(btn_Finalizar);
            panel_Footer.Dock = DockStyle.Bottom;
            panel_Footer.Location = new Point(0, 714);
            panel_Footer.Name = "panel_Footer";
            panel_Footer.Size = new Size(1246, 60);
            panel_Footer.TabIndex = 1;
            // 
            // btn_Atras
            // 
            btn_Atras.FlatStyle = FlatStyle.Flat;
            btn_Atras.Location = new Point(128, 14);
            btn_Atras.Name = "btn_Atras";
            btn_Atras.Size = new Size(110, 34);
            btn_Atras.TabIndex = 3;
            btn_Atras.Text = "Atrás";
            btn_Atras.UseVisualStyleBackColor = true;
            btn_Atras.Click += btn_Atras_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Location = new Point(12, 14);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(110, 34);
            btn_Cancelar.TabIndex = 2;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Siguiente
            // 
            btn_Siguiente.FlatStyle = FlatStyle.Flat;
            btn_Siguiente.Location = new Point(1008, 14);
            btn_Siguiente.Name = "btn_Siguiente";
            btn_Siguiente.Size = new Size(110, 34);
            btn_Siguiente.TabIndex = 1;
            btn_Siguiente.Text = "Siguiente";
            btn_Siguiente.UseVisualStyleBackColor = true;
            btn_Siguiente.Click += btn_Siguiente_Click;
            // 
            // btn_Finalizar
            // 
            btn_Finalizar.FlatStyle = FlatStyle.Flat;
            btn_Finalizar.Location = new Point(1124, 14);
            btn_Finalizar.Name = "btn_Finalizar";
            btn_Finalizar.Size = new Size(110, 34);
            btn_Finalizar.TabIndex = 0;
            btn_Finalizar.Text = "Finalizar";
            btn_Finalizar.UseVisualStyleBackColor = true;
            btn_Finalizar.Click += btn_Finalizar_Click;
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
            panel_Sidebar.Size = new Size(250, 654);
            panel_Sidebar.TabIndex = 2;
            // 
            // flowLayoutPanel_Sidebar
            // 
            flowLayoutPanel_Sidebar.AutoScroll = true;
            flowLayoutPanel_Sidebar.Dock = DockStyle.Fill;
            flowLayoutPanel_Sidebar.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Sidebar.Location = new Point(10, 10);
            flowLayoutPanel_Sidebar.Name = "flowLayoutPanel_Sidebar";
            flowLayoutPanel_Sidebar.Size = new Size(230, 634);
            flowLayoutPanel_Sidebar.TabIndex = 0;
            flowLayoutPanel_Sidebar.WrapContents = false;
            // 
            // panel_Content
            // 
            panel_Content.BackColor = Color.White;
            panel_Content.Dock = DockStyle.Fill;
            panel_Content.Location = new Point(250, 60);
            panel_Content.Name = "panel_Content";
            panel_Content.Padding = new Padding(25);
            panel_Content.Size = new Size(996, 654);
            panel_Content.TabIndex = 3;
            // 
            // ClienteWizard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 774);
            Controls.Add(panel_Content);
            Controls.Add(panel_Sidebar);
            Controls.Add(panel_Footer);
            Controls.Add(panel_Header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClienteWizard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ClienteWizard_Load;
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            panel_Footer.ResumeLayout(false);
            panel_Sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Header;
        private Panel panel_Footer;
        private Panel panel_Sidebar;
        private Panel panel_Content;
        private Label lbl_Titulo;
        private Label lbl_Subtitulo;
        private FlowLayoutPanel flowLayoutPanel_Sidebar;
        private Button btn_Atras;
        private Button btn_Cancelar;
        private Button btn_Siguiente;
        private Button btn_Finalizar;
    }
}