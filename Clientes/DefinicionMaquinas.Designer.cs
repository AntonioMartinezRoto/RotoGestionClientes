namespace RotoGestionClientes
{
    partial class DefinicionMaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinicionMaquinas));
            group_TipoMaquina = new GroupBox();
            cmb_TipoMaquina = new ComboBox();
            group_MarcaMaquina = new GroupBox();
            cmb_MarcaMaquina = new ComboBox();
            group_EmpresaMaquina = new GroupBox();
            cmb_MantenimientoMaquina = new ComboBox();
            group_Comentarios = new GroupBox();
            txt_Observaciones = new TextBox();
            btn_Aceptar = new Button();
            group_TipoMaquina.SuspendLayout();
            group_MarcaMaquina.SuspendLayout();
            group_EmpresaMaquina.SuspendLayout();
            group_Comentarios.SuspendLayout();
            SuspendLayout();
            // 
            // group_TipoMaquina
            // 
            group_TipoMaquina.Controls.Add(cmb_TipoMaquina);
            group_TipoMaquina.Location = new Point(25, 56);
            group_TipoMaquina.Margin = new Padding(3, 4, 3, 4);
            group_TipoMaquina.Name = "group_TipoMaquina";
            group_TipoMaquina.Padding = new Padding(3, 4, 3, 4);
            group_TipoMaquina.Size = new Size(330, 95);
            group_TipoMaquina.TabIndex = 7;
            group_TipoMaquina.TabStop = false;
            group_TipoMaquina.Text = "Tipo";
            // 
            // cmb_TipoMaquina
            // 
            cmb_TipoMaquina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TipoMaquina.FormattingEnabled = true;
            cmb_TipoMaquina.Location = new Point(18, 41);
            cmb_TipoMaquina.Margin = new Padding(3, 4, 3, 4);
            cmb_TipoMaquina.Name = "cmb_TipoMaquina";
            cmb_TipoMaquina.Size = new Size(285, 28);
            cmb_TipoMaquina.TabIndex = 0;
            // 
            // group_MarcaMaquina
            // 
            group_MarcaMaquina.Controls.Add(cmb_MarcaMaquina);
            group_MarcaMaquina.Location = new Point(381, 56);
            group_MarcaMaquina.Margin = new Padding(3, 4, 3, 4);
            group_MarcaMaquina.Name = "group_MarcaMaquina";
            group_MarcaMaquina.Padding = new Padding(3, 4, 3, 4);
            group_MarcaMaquina.Size = new Size(330, 95);
            group_MarcaMaquina.TabIndex = 8;
            group_MarcaMaquina.TabStop = false;
            group_MarcaMaquina.Text = "Marca";
            // 
            // cmb_MarcaMaquina
            // 
            cmb_MarcaMaquina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MarcaMaquina.FormattingEnabled = true;
            cmb_MarcaMaquina.Location = new Point(18, 41);
            cmb_MarcaMaquina.Margin = new Padding(3, 4, 3, 4);
            cmb_MarcaMaquina.Name = "cmb_MarcaMaquina";
            cmb_MarcaMaquina.Size = new Size(285, 28);
            cmb_MarcaMaquina.TabIndex = 0;
            // 
            // group_EmpresaMaquina
            // 
            group_EmpresaMaquina.Controls.Add(cmb_MantenimientoMaquina);
            group_EmpresaMaquina.Location = new Point(25, 163);
            group_EmpresaMaquina.Margin = new Padding(3, 4, 3, 4);
            group_EmpresaMaquina.Name = "group_EmpresaMaquina";
            group_EmpresaMaquina.Padding = new Padding(3, 4, 3, 4);
            group_EmpresaMaquina.Size = new Size(330, 95);
            group_EmpresaMaquina.TabIndex = 9;
            group_EmpresaMaquina.TabStop = false;
            group_EmpresaMaquina.Text = "Mantenimiento";
            // 
            // cmb_MantenimientoMaquina
            // 
            cmb_MantenimientoMaquina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MantenimientoMaquina.FormattingEnabled = true;
            cmb_MantenimientoMaquina.Location = new Point(19, 41);
            cmb_MantenimientoMaquina.Margin = new Padding(3, 4, 3, 4);
            cmb_MantenimientoMaquina.Name = "cmb_MantenimientoMaquina";
            cmb_MantenimientoMaquina.Size = new Size(285, 28);
            cmb_MantenimientoMaquina.TabIndex = 0;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_Observaciones);
            group_Comentarios.Location = new Point(381, 163);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(330, 95);
            group_Comentarios.TabIndex = 11;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_Observaciones
            // 
            txt_Observaciones.Location = new Point(19, 29);
            txt_Observaciones.Margin = new Padding(3, 4, 3, 4);
            txt_Observaciones.MaxLength = 1000;
            txt_Observaciones.Multiline = true;
            txt_Observaciones.Name = "txt_Observaciones";
            txt_Observaciones.Size = new Size(285, 56);
            txt_Observaciones.TabIndex = 8;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(585, 293);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Padding = new Padding(11, 0, 0, 0);
            btn_Aceptar.Size = new Size(126, 45);
            btn_Aceptar.TabIndex = 12;
            btn_Aceptar.Text = "Guardar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // DefinicionMaquinas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 369);
            Controls.Add(btn_Aceptar);
            Controls.Add(group_Comentarios);
            Controls.Add(group_EmpresaMaquina);
            Controls.Add(group_MarcaMaquina);
            Controls.Add(group_TipoMaquina);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DefinicionMaquinas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DefinicionMaquinas_Load;
            group_TipoMaquina.ResumeLayout(false);
            group_MarcaMaquina.ResumeLayout(false);
            group_EmpresaMaquina.ResumeLayout(false);
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox group_TipoMaquina;
        private ComboBox cmb_TipoMaquina;
        private GroupBox group_MarcaMaquina;
        private ComboBox cmb_MarcaMaquina;
        private GroupBox group_EmpresaMaquina;
        private ComboBox cmb_MantenimientoMaquina;
        private GroupBox group_Comentarios;
        private TextBox txt_Observaciones;
        private Button btn_Aceptar;
    }
}