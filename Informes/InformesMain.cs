using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public partial class InformesMain : Form
    {
        #region Private properties

        private readonly ApplicationDbContext _context;
        #endregion

        #region Constructors
        public InformesMain(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
            ConfigureGrid();
        }

        #endregion

        #region Events
        private void InformesMain_Load(object sender, EventArgs e)
        {
            panel_Sidebar.BackColor = Color.FromArgb(245, 247, 250);
        }
        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Private methods
        private void ConfigureGrid()
        {
            
        }

        #endregion


    }
}
