using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RotoGestionClientes
{
    public partial class ExportProgressForm : Form
    {
        public ExportProgressForm()
        {
            InitializeComponent();
            ControlBox = false;
            progressBar.Minimum = 0;
        }

        public void Inicializar(int total)
        {
            progressBar.Maximum = total;
            progressBar.Value = 0;

            lblEstado.Text = $"0 de {total}";
        }

        public void Actualizar(ExportProgressInfo info)
        {
            progressBar.Value = info.Actual;
            lblCliente.Text = info.ClienteNombre;
            lblEstado.Text = $"{info.Actual} de {info.Total}";
            lblPorcentaje.Text = $"{(info.Actual * 100) / info.Total}%";
        }
    }

    public class ExportProgressInfo
    {
        public int Actual { get; set; }

        public int Total { get; set; }

        public string ClienteNombre { get; set; } = string.Empty;
    }
}
