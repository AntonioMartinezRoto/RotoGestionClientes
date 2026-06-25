namespace RotoGestionClientes
{
    partial class PasoDocumentosAsociados
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
            groupBox1 = new GroupBox();
            btn_AddDocument = new Button();
            dgvDocumentos = new DataGridView();
            group_Comentarios = new GroupBox();
            txt_ObservacionesDocumentos = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            group_Comentarios.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_AddDocument);
            groupBox1.Controls.Add(dgvDocumentos);
            groupBox1.Location = new Point(33, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1010, 558);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Documentos";
            // 
            // btn_AddDocument
            // 
            btn_AddDocument.Location = new Point(19, 29);
            btn_AddDocument.Margin = new Padding(3, 4, 3, 4);
            btn_AddDocument.Name = "btn_AddDocument";
            btn_AddDocument.Size = new Size(37, 43);
            btn_AddDocument.TabIndex = 5;
            btn_AddDocument.Text = " +";
            btn_AddDocument.UseVisualStyleBackColor = true;
            btn_AddDocument.Click += btn_AddDocument_Click;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.AllowUserToAddRows = false;
            dgvDocumentos.AllowUserToDeleteRows = false;
            dgvDocumentos.AllowUserToOrderColumns = true;
            dgvDocumentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDocumentos.BackgroundColor = Color.White;
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Location = new Point(19, 80);
            dgvDocumentos.Margin = new Padding(3, 4, 3, 4);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.ReadOnly = true;
            dgvDocumentos.RowHeadersVisible = false;
            dgvDocumentos.RowHeadersWidth = 51;
            dgvDocumentos.Size = new Size(972, 436);
            dgvDocumentos.TabIndex = 4;
            dgvDocumentos.CellClick += dgvDocumentos_CellClick;
            // 
            // group_Comentarios
            // 
            group_Comentarios.Controls.Add(txt_ObservacionesDocumentos);
            group_Comentarios.Location = new Point(33, 570);
            group_Comentarios.Margin = new Padding(3, 4, 3, 4);
            group_Comentarios.Name = "group_Comentarios";
            group_Comentarios.Padding = new Padding(3, 4, 3, 4);
            group_Comentarios.Size = new Size(1010, 213);
            group_Comentarios.TabIndex = 18;
            group_Comentarios.TabStop = false;
            group_Comentarios.Text = "Observaciones";
            // 
            // txt_ObservacionesDocumentos
            // 
            txt_ObservacionesDocumentos.Location = new Point(19, 29);
            txt_ObservacionesDocumentos.Margin = new Padding(3, 4, 3, 4);
            txt_ObservacionesDocumentos.MaxLength = 1000;
            txt_ObservacionesDocumentos.Multiline = true;
            txt_ObservacionesDocumentos.Name = "txt_ObservacionesDocumentos";
            txt_ObservacionesDocumentos.Size = new Size(972, 167);
            txt_ObservacionesDocumentos.TabIndex = 8;
            txt_ObservacionesDocumentos.TextChanged += txt_ObservacionesDocumentos_TextChanged;
            // 
            // PasoDocumentosAsociados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(group_Comentarios);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1081, 805);
            Name = "PasoDocumentosAsociados";
            Size = new Size(1081, 805);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            group_Comentarios.ResumeLayout(false);
            group_Comentarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupSoporteMarco;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupCentroTripleTaladro;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupSoldadoraBisagras;
        private RadioButton rb_BisagraSoldadoraSi;
        private RadioButton rb_BombilloNo;
        private Button btn_AddDocument;
        private DataGridView dgvDocumentos;
        private PictureBox pictureBox1;
        private GroupBox group_Comentarios;
        private TextBox txt_ObservacionesDocumentos;
    }
}
