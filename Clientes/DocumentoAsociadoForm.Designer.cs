namespace RotoGestionClientes
{
    partial class DocumentoAsociadoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentoAsociadoForm));
            lblFichero = new Label();
            btn_Seleccionar = new Button();
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            txt_Nombre = new TextBox();
            lbl_NombreDoc = new Label();
            SuspendLayout();
            // 
            // lblFichero
            // 
            lblFichero.AutoSize = true;
            lblFichero.Location = new Point(81, 191);
            lblFichero.Name = "lblFichero";
            lblFichero.Size = new Size(50, 20);
            lblFichero.TabIndex = 0;
            lblFichero.Text = "label1";
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.Location = new Point(81, 129);
            btn_Seleccionar.Margin = new Padding(3, 4, 3, 4);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(188, 43);
            btn_Seleccionar.TabIndex = 6;
            btn_Seleccionar.Text = "Seleccionar documento";
            btn_Seleccionar.UseVisualStyleBackColor = true;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(707, 266);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(11, 0, 0, 0);
            btn_Aceptar.Size = new Size(126, 45);
            btn_Aceptar.TabIndex = 13;
            btn_Aceptar.Text = "Guardar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Image = (Image)resources.GetObject("btn_Cancelar.Image");
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(575, 266);
            btn_Cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Padding = new Padding(11, 0, 0, 0);
            btn_Cancelar.Size = new Size(126, 45);
            btn_Cancelar.TabIndex = 14;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(324, 76);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(229, 27);
            txt_Nombre.TabIndex = 15;
            // 
            // lbl_NombreDoc
            // 
            lbl_NombreDoc.AutoSize = true;
            lbl_NombreDoc.Location = new Point(81, 79);
            lbl_NombreDoc.Name = "lbl_NombreDoc";
            lbl_NombreDoc.Size = new Size(144, 20);
            lbl_NombreDoc.TabIndex = 17;
            lbl_NombreDoc.Text = "Nombre documento";
            // 
            // DocumentoAsociadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 355);
            Controls.Add(lbl_NombreDoc);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_Seleccionar);
            Controls.Add(lblFichero);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DocumentoAsociadoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DocumentoAsociadoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFichero;
        private Button btn_Seleccionar;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private TextBox txt_Nombre;
        private Label lbl_NombreDoc;
    }
}