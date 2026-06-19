using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public class ApplicationInfo
    {
        public ApplicationEdition Edition { get; }
        public int ResponsableId { get; }
        public string Version => Application.ProductVersion;
        public string Nombre => Application.ProductName;
        public bool IsInternal => Edition == ApplicationEdition.Internal;
        public bool IsDistributor => Edition == ApplicationEdition.Distributor;
        public bool IsDebug => Edition == ApplicationEdition.Debug;

        public ApplicationInfo(ApplicationSettings settings)
        {
            Edition = settings.Edition;
            ResponsableId = settings.ResponsableId;
        }
    }
}
