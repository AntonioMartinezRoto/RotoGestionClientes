namespace RotoGestionClientes
{
    partial class ClienteResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteResumen));
            tlpRoot = new TableLayoutPanel();
            tlpHeader = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tlpInfoHeader = new TableLayoutPanel();
            lbl_Observaciones = new Label();
            label4 = new Label();
            lbl_Alias = new Label();
            lbl_SapId = new Label();
            lbl_Nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tlpBody = new TableLayoutPanel();
            tlpLeft = new TableLayoutPanel();
            groupBox_Documentos = new GroupBox();
            txt_Documentos = new TextBox();
            groupBox_General = new GroupBox();
            lbl_ConsumenPlegables = new Label();
            lbl_UsaDlo = new Label();
            lbl_ElevableEstandar = new Label();
            groupBox_Software = new GroupBox();
            lbl_Software = new Label();
            groupBox_Manillas = new GroupBox();
            txt_Manillas = new TextBox();
            groupBox_Perfiles = new GroupBox();
            txt_Perfiles = new TextBox();
            tlpCentral = new TableLayoutPanel();
            tlpCentral_Sup = new TableLayoutPanel();
            picture_Ventana = new PictureBox();
            groupBox_PasivaPrac = new GroupBox();
            txt_PasivasPract = new TextBox();
            groupBox_PasivaOsc = new GroupBox();
            txt_PasivasOsc = new TextBox();
            groupBox_SeguridadVent = new GroupBox();
            txt_SeguridadVentana = new TextBox();
            tlpCentral_Inf = new TableLayoutPanel();
            picture_Balconera = new PictureBox();
            groupBox_PasivaBalc = new GroupBox();
            txt_PasivaBalc = new TextBox();
            groupBox_SeguridadBalc = new GroupBox();
            txt_SeguridadBalc = new TextBox();
            groupBox_AgujasBalc = new GroupBox();
            txt_AgujasBalc = new TextBox();
            tlp_Derecha = new TableLayoutPanel();
            groupMaquinas = new GroupBox();
            dgvMaquinas = new DataGridView();
            tlp_DerechaSup = new TableLayoutPanel();
            groupbox_AgujasPuerta = new GroupBox();
            txt_AgujasPuerta = new TextBox();
            groupbox_Bisagras = new GroupBox();
            txt_Bisagras = new TextBox();
            groupBox_Cerraduras = new GroupBox();
            txt_Cerraduras = new TextBox();
            picture_Puerta = new PictureBox();
            tlp_Footer = new TableLayoutPanel();
            panel_botons = new Panel();
            btn_Cerrar = new Button();
            btn_ExportarPdf = new Button();
            tlpRoot.SuspendLayout();
            tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpInfoHeader.SuspendLayout();
            tlpBody.SuspendLayout();
            tlpLeft.SuspendLayout();
            groupBox_Documentos.SuspendLayout();
            groupBox_General.SuspendLayout();
            groupBox_Software.SuspendLayout();
            groupBox_Manillas.SuspendLayout();
            groupBox_Perfiles.SuspendLayout();
            tlpCentral.SuspendLayout();
            tlpCentral_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Ventana).BeginInit();
            groupBox_PasivaPrac.SuspendLayout();
            groupBox_PasivaOsc.SuspendLayout();
            groupBox_SeguridadVent.SuspendLayout();
            tlpCentral_Inf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Balconera).BeginInit();
            groupBox_PasivaBalc.SuspendLayout();
            groupBox_SeguridadBalc.SuspendLayout();
            groupBox_AgujasBalc.SuspendLayout();
            tlp_Derecha.SuspendLayout();
            groupMaquinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinas).BeginInit();
            tlp_DerechaSup.SuspendLayout();
            groupbox_AgujasPuerta.SuspendLayout();
            groupbox_Bisagras.SuspendLayout();
            groupBox_Cerraduras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Puerta).BeginInit();
            tlp_Footer.SuspendLayout();
            panel_botons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(tlpHeader, 0, 0);
            tlpRoot.Controls.Add(tlpBody, 0, 1);
            tlpRoot.Controls.Add(tlp_Footer, 0, 2);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(15);
            tlpRoot.RowCount = 3;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tlpRoot.Size = new Size(1587, 1076);
            tlpRoot.TabIndex = 0;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeader.Controls.Add(pictureBox1, 0, 0);
            tlpHeader.Controls.Add(tlpInfoHeader, 1, 0);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(18, 18);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpHeader.Size = new Size(1551, 114);
            tlpHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tlpInfoHeader
            // 
            tlpInfoHeader.ColumnCount = 2;
            tlpInfoHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpInfoHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInfoHeader.Controls.Add(lbl_Observaciones, 1, 3);
            tlpInfoHeader.Controls.Add(label4, 0, 3);
            tlpInfoHeader.Controls.Add(lbl_Alias, 1, 2);
            tlpInfoHeader.Controls.Add(lbl_SapId, 1, 1);
            tlpInfoHeader.Controls.Add(lbl_Nombre, 1, 0);
            tlpInfoHeader.Controls.Add(label1, 0, 0);
            tlpInfoHeader.Controls.Add(label2, 0, 1);
            tlpInfoHeader.Controls.Add(label3, 0, 2);
            tlpInfoHeader.Dock = DockStyle.Fill;
            tlpInfoHeader.Location = new Point(253, 3);
            tlpInfoHeader.Name = "tlpInfoHeader";
            tlpInfoHeader.RowCount = 4;
            tlpInfoHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInfoHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInfoHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpInfoHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpInfoHeader.Size = new Size(1295, 108);
            tlpInfoHeader.TabIndex = 2;
            // 
            // lbl_Observaciones
            // 
            lbl_Observaciones.AutoSize = true;
            lbl_Observaciones.Location = new Point(153, 78);
            lbl_Observaciones.Name = "lbl_Observaciones";
            lbl_Observaciones.Size = new Size(113, 20);
            lbl_Observaciones.TabIndex = 7;
            lbl_Observaciones.Text = "COMENTARIOS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(3, 78);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "Comentarios:";
            // 
            // lbl_Alias
            // 
            lbl_Alias.AutoSize = true;
            lbl_Alias.Location = new Point(153, 48);
            lbl_Alias.Name = "lbl_Alias";
            lbl_Alias.Size = new Size(48, 20);
            lbl_Alias.TabIndex = 5;
            lbl_Alias.Text = "ALIAS";
            // 
            // lbl_SapId
            // 
            lbl_SapId.AutoSize = true;
            lbl_SapId.Location = new Point(153, 24);
            lbl_SapId.Name = "lbl_SapId";
            lbl_SapId.Size = new Size(54, 20);
            lbl_SapId.TabIndex = 4;
            lbl_SapId.Text = "SAP ID";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(153, 0);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(70, 20);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 24);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "SAP Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Alias:";
            // 
            // tlpBody
            // 
            tlpBody.ColumnCount = 3;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpBody.Controls.Add(tlpLeft, 0, 0);
            tlpBody.Controls.Add(tlpCentral, 1, 0);
            tlpBody.Controls.Add(tlp_Derecha, 2, 0);
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.Location = new Point(18, 138);
            tlpBody.Name = "tlpBody";
            tlpBody.Padding = new Padding(10);
            tlpBody.RowCount = 1;
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBody.Size = new Size(1551, 853);
            tlpBody.TabIndex = 1;
            // 
            // tlpLeft
            // 
            tlpLeft.AutoScroll = true;
            tlpLeft.BackColor = Color.Gainsboro;
            tlpLeft.ColumnCount = 1;
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.Controls.Add(groupBox_Documentos, 0, 4);
            tlpLeft.Controls.Add(groupBox_General, 0, 1);
            tlpLeft.Controls.Add(groupBox_Software, 0, 0);
            tlpLeft.Controls.Add(groupBox_Manillas, 0, 3);
            tlpLeft.Controls.Add(groupBox_Perfiles, 0, 2);
            tlpLeft.Dock = DockStyle.Fill;
            tlpLeft.Location = new Point(13, 13);
            tlpLeft.Name = "tlpLeft";
            tlpLeft.RowCount = 5;
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 11.85006F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9383316F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9093113F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25.272068F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25.03023F));
            tlpLeft.Size = new Size(300, 827);
            tlpLeft.TabIndex = 0;
            // 
            // groupBox_Documentos
            // 
            groupBox_Documentos.Controls.Add(txt_Documentos);
            groupBox_Documentos.Dock = DockStyle.Top;
            groupBox_Documentos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_Documentos.Location = new Point(3, 623);
            groupBox_Documentos.Name = "groupBox_Documentos";
            groupBox_Documentos.Size = new Size(294, 201);
            groupBox_Documentos.TabIndex = 5;
            groupBox_Documentos.TabStop = false;
            groupBox_Documentos.Text = "Documentos";
            // 
            // txt_Documentos
            // 
            txt_Documentos.BackColor = Color.Gainsboro;
            txt_Documentos.BorderStyle = BorderStyle.None;
            txt_Documentos.Font = new Font("Segoe UI", 15F);
            txt_Documentos.Location = new Point(6, 26);
            txt_Documentos.Multiline = true;
            txt_Documentos.Name = "txt_Documentos";
            txt_Documentos.ReadOnly = true;
            txt_Documentos.Size = new Size(281, 172);
            txt_Documentos.TabIndex = 28;
            // 
            // groupBox_General
            // 
            groupBox_General.Controls.Add(lbl_ConsumenPlegables);
            groupBox_General.Controls.Add(lbl_UsaDlo);
            groupBox_General.Controls.Add(lbl_ElevableEstandar);
            groupBox_General.Dock = DockStyle.Top;
            groupBox_General.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_General.Location = new Point(3, 101);
            groupBox_General.Name = "groupBox_General";
            groupBox_General.Size = new Size(294, 101);
            groupBox_General.TabIndex = 4;
            groupBox_General.TabStop = false;
            groupBox_General.Text = "General";
            // 
            // lbl_ConsumenPlegables
            // 
            lbl_ConsumenPlegables.AutoSize = true;
            lbl_ConsumenPlegables.Font = new Font("Segoe UI", 9F);
            lbl_ConsumenPlegables.Location = new Point(18, 75);
            lbl_ConsumenPlegables.Name = "lbl_ConsumenPlegables";
            lbl_ConsumenPlegables.Size = new Size(169, 20);
            lbl_ConsumenPlegables.TabIndex = 4;
            lbl_ConsumenPlegables.Text = "CONSUMEN PLEGABLES";
            // 
            // lbl_UsaDlo
            // 
            lbl_UsaDlo.AutoSize = true;
            lbl_UsaDlo.Font = new Font("Segoe UI", 9F);
            lbl_UsaDlo.Location = new Point(18, 50);
            lbl_UsaDlo.Name = "lbl_UsaDlo";
            lbl_UsaDlo.Size = new Size(69, 20);
            lbl_UsaDlo.TabIndex = 3;
            lbl_UsaDlo.Text = "USA DLO";
            // 
            // lbl_ElevableEstandar
            // 
            lbl_ElevableEstandar.AutoSize = true;
            lbl_ElevableEstandar.Font = new Font("Segoe UI", 9F);
            lbl_ElevableEstandar.Location = new Point(18, 24);
            lbl_ElevableEstandar.Name = "lbl_ElevableEstandar";
            lbl_ElevableEstandar.Size = new Size(152, 20);
            lbl_ElevableEstandar.TabIndex = 2;
            lbl_ElevableEstandar.Text = "ELEVABLE ESTANDAR";
            // 
            // groupBox_Software
            // 
            groupBox_Software.Controls.Add(lbl_Software);
            groupBox_Software.Dock = DockStyle.Top;
            groupBox_Software.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_Software.Location = new Point(3, 3);
            groupBox_Software.Name = "groupBox_Software";
            groupBox_Software.Size = new Size(294, 92);
            groupBox_Software.TabIndex = 0;
            groupBox_Software.TabStop = false;
            groupBox_Software.Text = "Software";
            // 
            // lbl_Software
            // 
            lbl_Software.AutoSize = true;
            lbl_Software.Font = new Font("Segoe UI", 15F);
            lbl_Software.Location = new Point(17, 41);
            lbl_Software.Name = "lbl_Software";
            lbl_Software.Size = new Size(139, 35);
            lbl_Software.TabIndex = 1;
            lbl_Software.Text = "SOFTWARE";
            // 
            // groupBox_Manillas
            // 
            groupBox_Manillas.Controls.Add(txt_Manillas);
            groupBox_Manillas.Dock = DockStyle.Top;
            groupBox_Manillas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_Manillas.Location = new Point(3, 414);
            groupBox_Manillas.Name = "groupBox_Manillas";
            groupBox_Manillas.Size = new Size(294, 203);
            groupBox_Manillas.TabIndex = 3;
            groupBox_Manillas.TabStop = false;
            groupBox_Manillas.Text = "Manillas";
            // 
            // txt_Manillas
            // 
            txt_Manillas.BackColor = Color.Gainsboro;
            txt_Manillas.BorderStyle = BorderStyle.None;
            txt_Manillas.Font = new Font("Segoe UI", 15F);
            txt_Manillas.Location = new Point(6, 26);
            txt_Manillas.Multiline = true;
            txt_Manillas.Name = "txt_Manillas";
            txt_Manillas.ReadOnly = true;
            txt_Manillas.Size = new Size(281, 172);
            txt_Manillas.TabIndex = 28;
            // 
            // groupBox_Perfiles
            // 
            groupBox_Perfiles.Controls.Add(txt_Perfiles);
            groupBox_Perfiles.Dock = DockStyle.Top;
            groupBox_Perfiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_Perfiles.Location = new Point(3, 208);
            groupBox_Perfiles.Name = "groupBox_Perfiles";
            groupBox_Perfiles.Size = new Size(294, 194);
            groupBox_Perfiles.TabIndex = 1;
            groupBox_Perfiles.TabStop = false;
            groupBox_Perfiles.Text = "Perfiles";
            // 
            // txt_Perfiles
            // 
            txt_Perfiles.BackColor = Color.Gainsboro;
            txt_Perfiles.BorderStyle = BorderStyle.None;
            txt_Perfiles.Font = new Font("Segoe UI", 15F);
            txt_Perfiles.Location = new Point(6, 25);
            txt_Perfiles.Multiline = true;
            txt_Perfiles.Name = "txt_Perfiles";
            txt_Perfiles.ReadOnly = true;
            txt_Perfiles.Size = new Size(270, 157);
            txt_Perfiles.TabIndex = 26;
            // 
            // tlpCentral
            // 
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(tlpCentral_Sup, 0, 0);
            tlpCentral.Controls.Add(tlpCentral_Inf, 0, 1);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(319, 13);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 2;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.Size = new Size(606, 827);
            tlpCentral.TabIndex = 1;
            // 
            // tlpCentral_Sup
            // 
            tlpCentral_Sup.BackColor = Color.WhiteSmoke;
            tlpCentral_Sup.ColumnCount = 2;
            tlpCentral_Sup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral_Sup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral_Sup.Controls.Add(picture_Ventana, 0, 0);
            tlpCentral_Sup.Controls.Add(groupBox_PasivaPrac, 1, 1);
            tlpCentral_Sup.Controls.Add(groupBox_PasivaOsc, 0, 1);
            tlpCentral_Sup.Controls.Add(groupBox_SeguridadVent, 1, 0);
            tlpCentral_Sup.Dock = DockStyle.Fill;
            tlpCentral_Sup.Location = new Point(3, 3);
            tlpCentral_Sup.Name = "tlpCentral_Sup";
            tlpCentral_Sup.RowCount = 2;
            tlpCentral_Sup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral_Sup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral_Sup.Size = new Size(600, 407);
            tlpCentral_Sup.TabIndex = 0;
            // 
            // picture_Ventana
            // 
            picture_Ventana.Dock = DockStyle.Fill;
            picture_Ventana.Image = (Image)resources.GetObject("picture_Ventana.Image");
            picture_Ventana.Location = new Point(3, 3);
            picture_Ventana.Name = "picture_Ventana";
            picture_Ventana.Size = new Size(294, 197);
            picture_Ventana.SizeMode = PictureBoxSizeMode.Zoom;
            picture_Ventana.TabIndex = 7;
            picture_Ventana.TabStop = false;
            // 
            // groupBox_PasivaPrac
            // 
            groupBox_PasivaPrac.Controls.Add(txt_PasivasPract);
            groupBox_PasivaPrac.Dock = DockStyle.Top;
            groupBox_PasivaPrac.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_PasivaPrac.Location = new Point(303, 206);
            groupBox_PasivaPrac.Name = "groupBox_PasivaPrac";
            groupBox_PasivaPrac.Size = new Size(294, 193);
            groupBox_PasivaPrac.TabIndex = 3;
            groupBox_PasivaPrac.TabStop = false;
            groupBox_PasivaPrac.Text = "Pasiva (Practicables)";
            // 
            // txt_PasivasPract
            // 
            txt_PasivasPract.BackColor = Color.WhiteSmoke;
            txt_PasivasPract.BorderStyle = BorderStyle.None;
            txt_PasivasPract.Font = new Font("Segoe UI", 15F);
            txt_PasivasPract.Location = new Point(12, 29);
            txt_PasivasPract.Multiline = true;
            txt_PasivasPract.Name = "txt_PasivasPract";
            txt_PasivasPract.ReadOnly = true;
            txt_PasivasPract.Size = new Size(270, 152);
            txt_PasivasPract.TabIndex = 29;
            // 
            // groupBox_PasivaOsc
            // 
            groupBox_PasivaOsc.Controls.Add(txt_PasivasOsc);
            groupBox_PasivaOsc.Dock = DockStyle.Top;
            groupBox_PasivaOsc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_PasivaOsc.Location = new Point(3, 206);
            groupBox_PasivaOsc.Name = "groupBox_PasivaOsc";
            groupBox_PasivaOsc.Size = new Size(294, 193);
            groupBox_PasivaOsc.TabIndex = 0;
            groupBox_PasivaOsc.TabStop = false;
            groupBox_PasivaOsc.Text = "Pasiva (Oscilo)";
            // 
            // txt_PasivasOsc
            // 
            txt_PasivasOsc.BackColor = Color.WhiteSmoke;
            txt_PasivasOsc.BorderStyle = BorderStyle.None;
            txt_PasivasOsc.Font = new Font("Segoe UI", 15F);
            txt_PasivasOsc.Location = new Point(12, 26);
            txt_PasivasOsc.Multiline = true;
            txt_PasivasOsc.Name = "txt_PasivasOsc";
            txt_PasivasOsc.ReadOnly = true;
            txt_PasivasOsc.Size = new Size(270, 152);
            txt_PasivasOsc.TabIndex = 28;
            // 
            // groupBox_SeguridadVent
            // 
            groupBox_SeguridadVent.Controls.Add(txt_SeguridadVentana);
            groupBox_SeguridadVent.Dock = DockStyle.Top;
            groupBox_SeguridadVent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_SeguridadVent.Location = new Point(303, 3);
            groupBox_SeguridadVent.Name = "groupBox_SeguridadVent";
            groupBox_SeguridadVent.Size = new Size(294, 193);
            groupBox_SeguridadVent.TabIndex = 1;
            groupBox_SeguridadVent.TabStop = false;
            groupBox_SeguridadVent.Text = "Seguridad ventana";
            // 
            // txt_SeguridadVentana
            // 
            txt_SeguridadVentana.BackColor = Color.WhiteSmoke;
            txt_SeguridadVentana.BorderStyle = BorderStyle.None;
            txt_SeguridadVentana.Font = new Font("Segoe UI", 15F);
            txt_SeguridadVentana.Location = new Point(12, 26);
            txt_SeguridadVentana.Multiline = true;
            txt_SeguridadVentana.Name = "txt_SeguridadVentana";
            txt_SeguridadVentana.ReadOnly = true;
            txt_SeguridadVentana.Size = new Size(270, 152);
            txt_SeguridadVentana.TabIndex = 27;
            // 
            // tlpCentral_Inf
            // 
            tlpCentral_Inf.BackColor = Color.WhiteSmoke;
            tlpCentral_Inf.ColumnCount = 2;
            tlpCentral_Inf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral_Inf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral_Inf.Controls.Add(picture_Balconera, 0, 0);
            tlpCentral_Inf.Controls.Add(groupBox_PasivaBalc, 1, 1);
            tlpCentral_Inf.Controls.Add(groupBox_SeguridadBalc, 0, 1);
            tlpCentral_Inf.Controls.Add(groupBox_AgujasBalc, 1, 0);
            tlpCentral_Inf.Dock = DockStyle.Fill;
            tlpCentral_Inf.Location = new Point(3, 416);
            tlpCentral_Inf.Name = "tlpCentral_Inf";
            tlpCentral_Inf.RowCount = 2;
            tlpCentral_Inf.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral_Inf.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral_Inf.Size = new Size(600, 408);
            tlpCentral_Inf.TabIndex = 1;
            // 
            // picture_Balconera
            // 
            picture_Balconera.Dock = DockStyle.Fill;
            picture_Balconera.Image = (Image)resources.GetObject("picture_Balconera.Image");
            picture_Balconera.Location = new Point(3, 3);
            picture_Balconera.Name = "picture_Balconera";
            picture_Balconera.Size = new Size(294, 198);
            picture_Balconera.SizeMode = PictureBoxSizeMode.Zoom;
            picture_Balconera.TabIndex = 7;
            picture_Balconera.TabStop = false;
            // 
            // groupBox_PasivaBalc
            // 
            groupBox_PasivaBalc.Controls.Add(txt_PasivaBalc);
            groupBox_PasivaBalc.Dock = DockStyle.Top;
            groupBox_PasivaBalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_PasivaBalc.Location = new Point(303, 207);
            groupBox_PasivaBalc.Name = "groupBox_PasivaBalc";
            groupBox_PasivaBalc.Size = new Size(294, 198);
            groupBox_PasivaBalc.TabIndex = 5;
            groupBox_PasivaBalc.TabStop = false;
            groupBox_PasivaBalc.Text = "Pasiva (Balconera)";
            // 
            // txt_PasivaBalc
            // 
            txt_PasivaBalc.BackColor = Color.WhiteSmoke;
            txt_PasivaBalc.BorderStyle = BorderStyle.None;
            txt_PasivaBalc.Font = new Font("Segoe UI", 15F);
            txt_PasivaBalc.Location = new Point(12, 26);
            txt_PasivaBalc.Multiline = true;
            txt_PasivaBalc.Name = "txt_PasivaBalc";
            txt_PasivaBalc.ReadOnly = true;
            txt_PasivaBalc.Size = new Size(270, 152);
            txt_PasivaBalc.TabIndex = 27;
            // 
            // groupBox_SeguridadBalc
            // 
            groupBox_SeguridadBalc.Controls.Add(txt_SeguridadBalc);
            groupBox_SeguridadBalc.Dock = DockStyle.Top;
            groupBox_SeguridadBalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_SeguridadBalc.Location = new Point(3, 207);
            groupBox_SeguridadBalc.Name = "groupBox_SeguridadBalc";
            groupBox_SeguridadBalc.Size = new Size(294, 198);
            groupBox_SeguridadBalc.TabIndex = 4;
            groupBox_SeguridadBalc.TabStop = false;
            groupBox_SeguridadBalc.Text = "Seguridad balconera";
            // 
            // txt_SeguridadBalc
            // 
            txt_SeguridadBalc.BackColor = Color.WhiteSmoke;
            txt_SeguridadBalc.BorderStyle = BorderStyle.None;
            txt_SeguridadBalc.Font = new Font("Segoe UI", 15F);
            txt_SeguridadBalc.Location = new Point(12, 26);
            txt_SeguridadBalc.Multiline = true;
            txt_SeguridadBalc.Name = "txt_SeguridadBalc";
            txt_SeguridadBalc.ReadOnly = true;
            txt_SeguridadBalc.Size = new Size(270, 152);
            txt_SeguridadBalc.TabIndex = 27;
            // 
            // groupBox_AgujasBalc
            // 
            groupBox_AgujasBalc.Controls.Add(txt_AgujasBalc);
            groupBox_AgujasBalc.Dock = DockStyle.Top;
            groupBox_AgujasBalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_AgujasBalc.Location = new Point(303, 3);
            groupBox_AgujasBalc.Name = "groupBox_AgujasBalc";
            groupBox_AgujasBalc.Size = new Size(294, 193);
            groupBox_AgujasBalc.TabIndex = 2;
            groupBox_AgujasBalc.TabStop = false;
            groupBox_AgujasBalc.Text = "Aguja balconera";
            // 
            // txt_AgujasBalc
            // 
            txt_AgujasBalc.BackColor = Color.WhiteSmoke;
            txt_AgujasBalc.BorderStyle = BorderStyle.None;
            txt_AgujasBalc.Font = new Font("Segoe UI", 15F);
            txt_AgujasBalc.Location = new Point(12, 26);
            txt_AgujasBalc.Multiline = true;
            txt_AgujasBalc.Name = "txt_AgujasBalc";
            txt_AgujasBalc.ReadOnly = true;
            txt_AgujasBalc.Size = new Size(270, 152);
            txt_AgujasBalc.TabIndex = 27;
            // 
            // tlp_Derecha
            // 
            tlp_Derecha.ColumnCount = 1;
            tlp_Derecha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Derecha.Controls.Add(groupMaquinas, 0, 1);
            tlp_Derecha.Controls.Add(tlp_DerechaSup, 0, 0);
            tlp_Derecha.Dock = DockStyle.Fill;
            tlp_Derecha.Location = new Point(931, 13);
            tlp_Derecha.Name = "tlp_Derecha";
            tlp_Derecha.RowCount = 2;
            tlp_Derecha.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Derecha.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Derecha.Size = new Size(607, 827);
            tlp_Derecha.TabIndex = 2;
            // 
            // groupMaquinas
            // 
            groupMaquinas.Controls.Add(dgvMaquinas);
            groupMaquinas.Dock = DockStyle.Top;
            groupMaquinas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupMaquinas.Location = new Point(3, 416);
            groupMaquinas.Name = "groupMaquinas";
            groupMaquinas.Size = new Size(601, 408);
            groupMaquinas.TabIndex = 33;
            groupMaquinas.TabStop = false;
            groupMaquinas.Text = "Máquinas";
            // 
            // dgvMaquinas
            // 
            dgvMaquinas.AllowUserToAddRows = false;
            dgvMaquinas.AllowUserToDeleteRows = false;
            dgvMaquinas.AllowUserToOrderColumns = true;
            dgvMaquinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMaquinas.BackgroundColor = Color.White;
            dgvMaquinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinas.Location = new Point(6, 24);
            dgvMaquinas.Margin = new Padding(3, 4, 3, 4);
            dgvMaquinas.Name = "dgvMaquinas";
            dgvMaquinas.ReadOnly = true;
            dgvMaquinas.RowHeadersVisible = false;
            dgvMaquinas.RowHeadersWidth = 51;
            dgvMaquinas.Size = new Size(589, 377);
            dgvMaquinas.TabIndex = 22;
            // 
            // tlp_DerechaSup
            // 
            tlp_DerechaSup.BackColor = Color.WhiteSmoke;
            tlp_DerechaSup.ColumnCount = 2;
            tlp_DerechaSup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_DerechaSup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_DerechaSup.Controls.Add(groupbox_AgujasPuerta, 1, 0);
            tlp_DerechaSup.Controls.Add(groupbox_Bisagras, 0, 1);
            tlp_DerechaSup.Controls.Add(groupBox_Cerraduras, 1, 1);
            tlp_DerechaSup.Controls.Add(picture_Puerta, 0, 0);
            tlp_DerechaSup.Dock = DockStyle.Fill;
            tlp_DerechaSup.Location = new Point(3, 3);
            tlp_DerechaSup.Name = "tlp_DerechaSup";
            tlp_DerechaSup.RowCount = 2;
            tlp_DerechaSup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_DerechaSup.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_DerechaSup.Size = new Size(601, 407);
            tlp_DerechaSup.TabIndex = 34;
            // 
            // groupbox_AgujasPuerta
            // 
            groupbox_AgujasPuerta.Controls.Add(txt_AgujasPuerta);
            groupbox_AgujasPuerta.Dock = DockStyle.Top;
            groupbox_AgujasPuerta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupbox_AgujasPuerta.Location = new Point(303, 3);
            groupbox_AgujasPuerta.Name = "groupbox_AgujasPuerta";
            groupbox_AgujasPuerta.Size = new Size(295, 193);
            groupbox_AgujasPuerta.TabIndex = 3;
            groupbox_AgujasPuerta.TabStop = false;
            groupbox_AgujasPuerta.Text = "Aguja balconera";
            // 
            // txt_AgujasPuerta
            // 
            txt_AgujasPuerta.BackColor = Color.WhiteSmoke;
            txt_AgujasPuerta.BorderStyle = BorderStyle.None;
            txt_AgujasPuerta.Font = new Font("Segoe UI", 15F);
            txt_AgujasPuerta.Location = new Point(12, 26);
            txt_AgujasPuerta.Multiline = true;
            txt_AgujasPuerta.Name = "txt_AgujasPuerta";
            txt_AgujasPuerta.ReadOnly = true;
            txt_AgujasPuerta.Size = new Size(270, 152);
            txt_AgujasPuerta.TabIndex = 27;
            // 
            // groupbox_Bisagras
            // 
            groupbox_Bisagras.Controls.Add(txt_Bisagras);
            groupbox_Bisagras.Dock = DockStyle.Fill;
            groupbox_Bisagras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupbox_Bisagras.Location = new Point(3, 206);
            groupbox_Bisagras.Name = "groupbox_Bisagras";
            groupbox_Bisagras.Size = new Size(294, 198);
            groupbox_Bisagras.TabIndex = 4;
            groupbox_Bisagras.TabStop = false;
            groupbox_Bisagras.Text = "Bisagras";
            // 
            // txt_Bisagras
            // 
            txt_Bisagras.BackColor = Color.WhiteSmoke;
            txt_Bisagras.BorderStyle = BorderStyle.None;
            txt_Bisagras.Font = new Font("Segoe UI", 15F);
            txt_Bisagras.Location = new Point(12, 26);
            txt_Bisagras.Multiline = true;
            txt_Bisagras.Name = "txt_Bisagras";
            txt_Bisagras.ReadOnly = true;
            txt_Bisagras.Size = new Size(270, 155);
            txt_Bisagras.TabIndex = 28;
            // 
            // groupBox_Cerraduras
            // 
            groupBox_Cerraduras.Controls.Add(txt_Cerraduras);
            groupBox_Cerraduras.Dock = DockStyle.Fill;
            groupBox_Cerraduras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox_Cerraduras.Location = new Point(303, 206);
            groupBox_Cerraduras.Name = "groupBox_Cerraduras";
            groupBox_Cerraduras.Size = new Size(295, 198);
            groupBox_Cerraduras.TabIndex = 5;
            groupBox_Cerraduras.TabStop = false;
            groupBox_Cerraduras.Text = "Cerraduras";
            // 
            // txt_Cerraduras
            // 
            txt_Cerraduras.BackColor = Color.WhiteSmoke;
            txt_Cerraduras.BorderStyle = BorderStyle.None;
            txt_Cerraduras.Font = new Font("Segoe UI", 15F);
            txt_Cerraduras.Location = new Point(12, 26);
            txt_Cerraduras.Multiline = true;
            txt_Cerraduras.Name = "txt_Cerraduras";
            txt_Cerraduras.ReadOnly = true;
            txt_Cerraduras.Size = new Size(270, 155);
            txt_Cerraduras.TabIndex = 28;
            // 
            // picture_Puerta
            // 
            picture_Puerta.Dock = DockStyle.Fill;
            picture_Puerta.Image = (Image)resources.GetObject("picture_Puerta.Image");
            picture_Puerta.Location = new Point(3, 3);
            picture_Puerta.Name = "picture_Puerta";
            picture_Puerta.Size = new Size(294, 197);
            picture_Puerta.SizeMode = PictureBoxSizeMode.Zoom;
            picture_Puerta.TabIndex = 6;
            picture_Puerta.TabStop = false;
            // 
            // tlp_Footer
            // 
            tlp_Footer.ColumnCount = 2;
            tlp_Footer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlp_Footer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlp_Footer.Controls.Add(panel_botons, 1, 0);
            tlp_Footer.Dock = DockStyle.Fill;
            tlp_Footer.Location = new Point(18, 997);
            tlp_Footer.Name = "tlp_Footer";
            tlp_Footer.RowCount = 1;
            tlp_Footer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Footer.Size = new Size(1551, 61);
            tlp_Footer.TabIndex = 2;
            // 
            // panel_botons
            // 
            panel_botons.Controls.Add(btn_Cerrar);
            panel_botons.Controls.Add(btn_ExportarPdf);
            panel_botons.Dock = DockStyle.Fill;
            panel_botons.Location = new Point(1088, 3);
            panel_botons.Name = "panel_botons";
            panel_botons.Size = new Size(460, 55);
            panel_botons.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Cerrar.FlatStyle = FlatStyle.Flat;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cerrar.Location = new Point(141, 6);
            btn_Cerrar.Margin = new Padding(3, 4, 3, 4);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Padding = new Padding(11, 0, 0, 0);
            btn_Cerrar.Size = new Size(155, 45);
            btn_Cerrar.TabIndex = 18;
            btn_Cerrar.Text = "Cancelar";
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_ExportarPdf
            // 
            btn_ExportarPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ExportarPdf.FlatStyle = FlatStyle.Flat;
            btn_ExportarPdf.Image = (Image)resources.GetObject("btn_ExportarPdf.Image");
            btn_ExportarPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ExportarPdf.Location = new Point(302, 6);
            btn_ExportarPdf.Margin = new Padding(3, 4, 3, 4);
            btn_ExportarPdf.Name = "btn_ExportarPdf";
            btn_ExportarPdf.Padding = new Padding(11, 0, 0, 0);
            btn_ExportarPdf.Size = new Size(155, 45);
            btn_ExportarPdf.TabIndex = 17;
            btn_ExportarPdf.Text = "Exportar PDF";
            btn_ExportarPdf.UseVisualStyleBackColor = true;
            btn_ExportarPdf.Click += btn_ExportarPdf_Click;
            // 
            // ClienteResumen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1587, 1076);
            Controls.Add(tlpRoot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 700);
            Name = "ClienteResumen";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += ClienteResumen_Load;
            tlpRoot.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpInfoHeader.ResumeLayout(false);
            tlpInfoHeader.PerformLayout();
            tlpBody.ResumeLayout(false);
            tlpLeft.ResumeLayout(false);
            groupBox_Documentos.ResumeLayout(false);
            groupBox_Documentos.PerformLayout();
            groupBox_General.ResumeLayout(false);
            groupBox_General.PerformLayout();
            groupBox_Software.ResumeLayout(false);
            groupBox_Software.PerformLayout();
            groupBox_Manillas.ResumeLayout(false);
            groupBox_Manillas.PerformLayout();
            groupBox_Perfiles.ResumeLayout(false);
            groupBox_Perfiles.PerformLayout();
            tlpCentral.ResumeLayout(false);
            tlpCentral_Sup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_Ventana).EndInit();
            groupBox_PasivaPrac.ResumeLayout(false);
            groupBox_PasivaPrac.PerformLayout();
            groupBox_PasivaOsc.ResumeLayout(false);
            groupBox_PasivaOsc.PerformLayout();
            groupBox_SeguridadVent.ResumeLayout(false);
            groupBox_SeguridadVent.PerformLayout();
            tlpCentral_Inf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_Balconera).EndInit();
            groupBox_PasivaBalc.ResumeLayout(false);
            groupBox_PasivaBalc.PerformLayout();
            groupBox_SeguridadBalc.ResumeLayout(false);
            groupBox_SeguridadBalc.PerformLayout();
            groupBox_AgujasBalc.ResumeLayout(false);
            groupBox_AgujasBalc.PerformLayout();
            tlp_Derecha.ResumeLayout(false);
            groupMaquinas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaquinas).EndInit();
            tlp_DerechaSup.ResumeLayout(false);
            groupbox_AgujasPuerta.ResumeLayout(false);
            groupbox_AgujasPuerta.PerformLayout();
            groupbox_Bisagras.ResumeLayout(false);
            groupbox_Bisagras.PerformLayout();
            groupBox_Cerraduras.ResumeLayout(false);
            groupBox_Cerraduras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Puerta).EndInit();
            tlp_Footer.ResumeLayout(false);
            panel_botons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private TableLayoutPanel tlpHeader;
        private PictureBox pictureBox1;
        private TableLayoutPanel tlpInfoHeader;
        private Label label1;
        private Label lbl_SapId;
        private Label lbl_Alias;
        private Label lbl_Nombre;
        private Label label2;
        private Label label3;
        private Label lbl_Observaciones;
        private Label label4;
        private TableLayoutPanel tlpBody;
        private TableLayoutPanel tlpLeft;
        private GroupBox groupBox_Software;
        private TableLayoutPanel tlp_Footer;
        private Panel panel_botons;
        private Button btn_Cerrar;
        private Button btn_ExportarPdf;
        private Label lbl_Software;
        private GroupBox groupBox_Perfiles;
        private TextBox txt_Perfiles;
        private GroupBox groupBox_General;
        private GroupBox groupBox_Manillas;
        private TextBox txt_Manillas;
        private Label lbl_ElevableEstandar;
        private Label lbl_UsaDlo;
        private Label lbl_ConsumenPlegables;
        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tlpCentral_Sup;
        private GroupBox groupBox_PasivaPrac;
        private GroupBox groupBox2;
        private GroupBox groupBox_SeguridadVent;
        private TextBox txt_SeguridadVentana;
        private TextBox txt_PasivasPract;
        private GroupBox groupBox_Ventanas;
        private TableLayoutPanel tlpCentral_Inf;
        private GroupBox groupBox5;
        private TextBox txt_PasivaBalc;
        private GroupBox groupBox_SeguridadBalc;
        private TextBox txt_SeguridadBalc;
        private GroupBox groupBox_PasivaBalc;
        private TextBox textBox2;
        private GroupBox groupBox_AgujasBalc;
        private TextBox txt_AgujasBalc;
        private GroupBox groupBox_PasivaOsc;
        private TextBox txt_PasivasOsc;
        private GroupBox groupBox_Documentos;
        private TextBox txt_Documentos;
        private TableLayoutPanel tlp_Derecha;
        private GroupBox groupMaquinas;
        private DataGridView dgvMaquinas;
        private TableLayoutPanel tlp_DerechaSup;
        private GroupBox groupbox_AgujasPuerta;
        private TextBox txt_AgujasPuerta;
        private GroupBox groupbox_Bisagras;
        private TextBox txt_Bisagras;
        private GroupBox groupBox_Cerraduras;
        private TextBox txt_Cerraduras;
        private PictureBox picture_Ventana;
        private PictureBox picture_Balconera;
        private PictureBox picture_Puerta;
    }
}