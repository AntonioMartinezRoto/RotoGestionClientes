namespace RotoGestionClientes
{
    partial class ExportProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportProgressForm));
            lblTitulo = new Label();
            lblCliente = new Label();
            progressBar = new ProgressBar();
            lblEstado = new Label();
            lblPorcentaje = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(50, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(58, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cliente:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(50, 90);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(64, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "CLIENTE";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(50, 123);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(448, 27);
            progressBar.TabIndex = 2;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(50, 164);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(64, 20);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "ESTADO";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(504, 127);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(96, 20);
            lblPorcentaje.TabIndex = 4;
            lblPorcentaje.Text = "PORCENTAJE";
            // 
            // ExportProgressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(643, 237);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblEstado);
            Controls.Add(progressBar);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportProgressForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCliente;
        private ProgressBar progressBar;
        private Label lblEstado;
        private Label lblPorcentaje;
    }
}