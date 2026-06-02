namespace RotoGestionClientes
{
    partial class MaestroEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaestroEditForm));
            lbl_Nombre = new Label();
            txt_Nombre = new TextBox();
            btn_Cancelar = new Button();
            btn_Aceptar = new Button();
            chk_Activo = new CheckBox();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(85, 68);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(64, 20);
            lbl_Nombre.TabIndex = 21;
            lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(200, 65);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(229, 27);
            txt_Nombre.TabIndex = 20;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Image = (Image)resources.GetObject("btn_Cancelar.Image");
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(236, 186);
            btn_Cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Padding = new Padding(11, 0, 0, 0);
            btn_Cancelar.Size = new Size(126, 45);
            btn_Cancelar.TabIndex = 19;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(368, 186);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(11, 0, 0, 0);
            btn_Aceptar.Size = new Size(126, 45);
            btn_Aceptar.TabIndex = 18;
            btn_Aceptar.Text = "Guardar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // chk_Activo
            // 
            chk_Activo.AutoSize = true;
            chk_Activo.Location = new Point(85, 120);
            chk_Activo.Name = "chk_Activo";
            chk_Activo.Size = new Size(73, 24);
            chk_Activo.TabIndex = 22;
            chk_Activo.Text = "Activo";
            chk_Activo.UseVisualStyleBackColor = true;
            // 
            // MaestroEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(524, 273);
            Controls.Add(chk_Activo);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MaestroEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MaestroEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nombre;
        private TextBox txt_Nombre;
        private Button btn_Cancelar;
        private Button btn_Aceptar;
        private CheckBox chk_Activo;
    }
}