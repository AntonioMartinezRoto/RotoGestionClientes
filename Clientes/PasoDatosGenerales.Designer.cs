namespace RotoGestionClientes
{
    partial class PasoDatosGenerales
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txt_NombreCliente = new TextBox();
            lbl_NombreCliente = new Label();
            lbl_Alias = new Label();
            txt_Alias = new TextBox();
            group_PerfilTipo = new GroupBox();
            dgvPerfilTipo = new DataGridView();
            group_Software = new GroupBox();
            cmb_Software = new ComboBox();
            group_Manillas = new GroupBox();
            dgvManillas = new DataGridView();
            txt_Comentarios = new TextBox();
            group_Comentarios = new GroupBox();
            group_SoporteCompas = new GroupBox();
            dgvSoporteCompas = new DataGridView();
            lbl_SapId = new Label();
            txt_SapId = new TextBox();
            groupBox1 = new GroupBox();
            dgvPerfil = new DataGridView();
            group_PerfilTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerfilTipo).BeginInit();
            group_Software.SuspendLayout();
            group_Manillas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManillas).BeginInit();
            group_Comentarios.SuspendLayout();
            group_SoporteCompas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoporteCompas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerfil).BeginInit();
            SuspendLayout();
            // 
            // txt_NombreCliente
            // 
            txt_NombreCliente.Location = new Point(162, 52);
            txt_NombreCliente.MaxLength = 50;
            txt_NombreCliente.Name = "txt_NombreCliente";
            txt_NombreCliente.Size = new Size(163, 23);
            txt_NombreCliente.TabIndex = 0;
            txt_NombreCliente.TextChanged += txt_NombreCliente_TextChanged;
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Location = new Point(37, 55);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(108, 15);
            lbl_NombreCliente.TabIndex = 1;
            lbl_NombreCliente.Text = "Nombre del cliente";
            // 
            // lbl_Alias
            // 
            lbl_Alias.AutoSize = true;
            lbl_Alias.Location = new Point(37, 92);
            lbl_Alias.Name = "lbl_Alias";
            lbl_Alias.Size = new Size(32, 15);
            lbl_Alias.TabIndex = 3;
            lbl_Alias.Text = "Alias";
            // 
            // txt_Alias
            // 
            txt_Alias.Location = new Point(162, 89);
            txt_Alias.MaxLength = 50;
            txt_Alias.Name = "txt_Alias";
            txt_Alias.Size = new Size(163, 23);
            txt_Alias.TabIndex = 2;
            txt_Alias.TextChanged += txt_Alias_TextChanged;
            // 
            // group_PerfilTipo
            // 
            group_PerfilTipo.Controls.Add(dgvPerfilTipo);
            group_PerfilTipo.Location = new Point(341, 33);
            group_PerfilTipo.Name = "group_PerfilTipo";
            group_PerfilTipo.Size = new Size(289, 192);
            group_PerfilTipo.TabIndex = 4;
            group_PerfilTipo.TabStop = false;
            group_PerfilTipo.Text = "Tipo de perfil";
            // 
            // dgvPerfilTipo
            // 
            dgvPerfilTipo.AllowUserToAddRows = false;
            dgvPerfilTipo.AllowUserToDeleteRows = false;
            dgvPerfilTipo.AllowUserToOrderColumns = true;
            dgvPerfilTipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPerfilTipo.BackgroundColor = Color.White;
            dgvPerfilTipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerfilTipo.Location = new Point(17, 22);
            dgvPerfilTipo.Name = "dgvPerfilTipo";
            dgvPerfilTipo.ReadOnly = true;
            dgvPerfilTipo.RowHeadersVisible = false;
            dgvPerfilTipo.Size = new Size(255, 153);
            dgvPerfilTipo.TabIndex = 2;
            dgvPerfilTipo.CellMouseUp += dgvPerfilTipo_CellMouseUp;
            // 
            // group_Software
            // 
            group_Software.Controls.Add(cmb_Software);
            group_Software.Location = new Point(37, 166);
            group_Software.Name = "group_Software";
            group_Software.Size = new Size(289, 59);
            group_Software.TabIndex = 6;
            group_Software.TabStop = false;
            group_Software.Text = "Software";
            // 
            // cmb_Software
            // 
            cmb_Software.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Software.FormattingEnabled = true;
            cmb_Software.Location = new Point(17, 22);
            cmb_Software.Name = "cmb_Software";
            cmb_Software.Size = new Size(250, 23);
            cmb_Software.TabIndex = 0;
            cmb_Software.SelectedValueChanged += cmb_Software_SelectedValueChanged;
            // 
            // group_Manillas
            // 
            group_Manillas.Controls.Add(dgvManillas);
            group_Manillas.Location = new Point(341, 246);
            group_Manillas.Name = "group_Manillas";
            group_Manillas.Size = new Size(289, 221);
            group_Manillas.TabIndex = 7;
            group_Manillas.TabStop = false;
            group_Manillas.Text = "Manillas";
            // 
            // dgvManillas
            // 
            dgvManillas.AllowUserToAddRows = false;
            dgvManillas.AllowUserToDeleteRows = false;
            dgvManillas.AllowUserToOrderColumns = true;
            dgvManillas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvManillas.BackgroundColor = Color.White;
            dgvManillas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManillas.Location = new Point(17, 22);
            dgvManillas.Name = "dgvManillas";
            dgvManillas.ReadOnly = true;
            dgvManillas.Size = new Size(255, 180);
            dgvManillas.TabIndex = 2;
            dgvManillas.CellMouseUp += dgvManillas_CellMouseUp;
            // 
            // txt_Comentarios
            // 
            txt_Comentarios.Location = new Point(15, 18);
            txt_Comentarios.MaxLength = 1000;
            txt_Comentarios.Multiline = true;
            txt_Comentarios.Name = "txt_Comentarios";
            txt_Comentarios.Size = new Size(858, 60);
            txt_Comentarios.TabIndex = 8;
            txt_Comentarios.TextChanged += txt_Comentarios_TextChanged;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_Comentarios);
            group_Comentarios.Location = new Point(39, 484);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Size = new Size(892, 88);
            group_Comentarios.TabIndex = 9;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Comentarios";
            // 
            // group_SoporteCompas
            // 
            group_SoporteCompas.Controls.Add(dgvSoporteCompas);
            group_SoporteCompas.Location = new Point(39, 246);
            group_SoporteCompas.Name = "group_SoporteCompas";
            group_SoporteCompas.Size = new Size(288, 221);
            group_SoporteCompas.TabIndex = 10;
            group_SoporteCompas.TabStop = false;
            group_SoporteCompas.Text = "Soporte compás";
            // 
            // dgvSoporteCompas
            // 
            dgvSoporteCompas.AllowUserToAddRows = false;
            dgvSoporteCompas.AllowUserToDeleteRows = false;
            dgvSoporteCompas.AllowUserToOrderColumns = true;
            dgvSoporteCompas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSoporteCompas.BackgroundColor = Color.White;
            dgvSoporteCompas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoporteCompas.Location = new Point(17, 22);
            dgvSoporteCompas.Name = "dgvSoporteCompas";
            dgvSoporteCompas.ReadOnly = true;
            dgvSoporteCompas.Size = new Size(255, 180);
            dgvSoporteCompas.TabIndex = 3;
            dgvSoporteCompas.CellMouseUp += dgvSoporteCompas_CellMouseUp;
            // 
            // lbl_SapId
            // 
            lbl_SapId.AutoSize = true;
            lbl_SapId.Location = new Point(37, 133);
            lbl_SapId.Name = "lbl_SapId";
            lbl_SapId.Size = new Size(41, 15);
            lbl_SapId.TabIndex = 13;
            lbl_SapId.Text = "Id SAP";
            // 
            // txt_SapId
            // 
            txt_SapId.Location = new Point(162, 130);
            txt_SapId.MaxLength = 50;
            txt_SapId.Name = "txt_SapId";
            txt_SapId.Size = new Size(163, 23);
            txt_SapId.TabIndex = 12;
            txt_SapId.TextChanged += txt_SapId_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPerfil);
            groupBox1.Location = new Point(642, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 434);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Perfil";
            // 
            // dgvPerfil
            // 
            dgvPerfil.AllowUserToAddRows = false;
            dgvPerfil.AllowUserToDeleteRows = false;
            dgvPerfil.AllowUserToOrderColumns = true;
            dgvPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPerfil.BackgroundColor = Color.White;
            dgvPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerfil.Location = new Point(17, 22);
            dgvPerfil.Name = "dgvPerfil";
            dgvPerfil.ReadOnly = true;
            dgvPerfil.Size = new Size(253, 393);
            dgvPerfil.TabIndex = 2;
            dgvPerfil.CellMouseUp += dgvPerfil_CellMouseUp;
            // 
            // PasoDatosGenerales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(lbl_SapId);
            Controls.Add(txt_SapId);
            Controls.Add(group_SoporteCompas);
            Controls.Add(group_Comentarios);
            Controls.Add(group_Manillas);
            Controls.Add(group_Software);
            Controls.Add(group_PerfilTipo);
            Controls.Add(lbl_Alias);
            Controls.Add(txt_Alias);
            Controls.Add(lbl_NombreCliente);
            Controls.Add(txt_NombreCliente);
            Name = "PasoDatosGenerales";
            Size = new Size(946, 604);
            Load += PasoDatosGenerales_Load;
            group_PerfilTipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPerfilTipo).EndInit();
            group_Software.ResumeLayout(false);
            group_Manillas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvManillas).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            group_SoporteCompas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSoporteCompas).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_NombreCliente;
        private Label lbl_NombreCliente;
        private Label lbl_Alias;
        private TextBox txt_Alias;
        private GroupBox group_PerfilTipo;
        private DataGridView dgvPerfilTipo;
        private Label lbl_Software;
        private GroupBox group_Software;
        private ComboBox cmb_Software;
        private GroupBox group_Manillas;
        private DataGridView dgvManillas;
        private TextBox txt_Comentarios;
        private GroupBox group_Comentarios;
        private GroupBox group_SoporteCompas;
        private DataGridView dgvSoporteCompas;
        private Label lbl_SapId;
        private TextBox txt_SapId;
        private GroupBox groupBox1;
        private DataGridView dgvPerfil;
    }
}
