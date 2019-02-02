using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpCampaña
    {
        public CmpCampaña()
        {
            CmpDetalleCampaña = new HashSet<CmpDetalleCampaña>();
            CmpDetalleCampañaOportunidad = new HashSet<CmpDetalleCampañaOportunidad>();
            CmpValoresPersonalizadosDetalleMigrado = new HashSet<CmpValoresPersonalizadosDetalleMigrado>();
        }

        public string IdCampaña { get; set; }
        public string NombreCampaña { get; set; }
        public DateTime FechaCreacionCampaña { get; set; }
        public int IdTipoCampaña { get; set; }
        public int IdTipoProducto { get; set; }
        public int IdFuncional { get; set; }

        public virtual CmpFuncional IdFuncionalNavigation { get; set; }
        public virtual CmpTipoCampaña IdTipoCampañaNavigation { get; set; }
        public virtual CmpTipoProducto IdTipoProductoNavigation { get; set; }
        public virtual ICollection<CmpDetalleCampaña> CmpDetalleCampaña { get; set; }
        public virtual ICollection<CmpDetalleCampañaOportunidad> CmpDetalleCampañaOportunidad { get; set; }
        public virtual ICollection<CmpValoresPersonalizadosDetalleMigrado> CmpValoresPersonalizadosDetalleMigrado { get; set; }
    }
}
