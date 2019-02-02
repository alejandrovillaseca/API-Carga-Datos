using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpValoresPersonalizadosDetalleMigrado
    {
        public int IdVpdmigrado { get; set; }
        public string IdCampaña { get; set; }
        public int IdValoresPersonalizadoDetalle { get; set; }
        public int IdCamposMigrados { get; set; }

        public virtual CmpCampaña IdCampañaNavigation { get; set; }
        public virtual ParCamposMigrados IdCamposMigradosNavigation { get; set; }
        public virtual CmpValoresPersonalizadosDetalle IdValoresPersonalizadoDetalleNavigation { get; set; }
    }
}
