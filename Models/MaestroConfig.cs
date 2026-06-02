using System;
using System.Collections.Generic;
using System.Text;

namespace RotoGestionClientes
{
    public class MaestroConfig
    {
        public string Nombre { get; set; } = null!;

        public Func<ApplicationDbContext, List<MaestroGridItem>> LoadData { get; set; } = null!;

        public Action<ApplicationDbContext, MaestroEditItem> InsertAction { get; set; } = null!;

        public Action<ApplicationDbContext, MaestroEditItem> UpdateAction { get; set; } = null!;
    }
}
