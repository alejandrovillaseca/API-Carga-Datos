using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpDetalleCampaña
    {
        public CmpDetalleCampaña()
        {
            CmpDetalleCampañaOportunidad = new HashSet<CmpDetalleCampañaOportunidad>();
        }

        public long IdDetalleCampaña { get; set; }
        public string IdCampaña { get; set; }
        public string ResponseTrackCd { get; set; }
        public int IdCmpEjec { get; set; }
        public int IdCanal { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaCreacionRegistro { get; set; }
        public string DescripcionCampaña { get; set; }
        public bool CmpMigrada { get; set; }

        public virtual CmpCampaña IdCampañaNavigation { get; set; }
        public virtual CmpCanal IdCanalNavigation { get; set; }
        public virtual ICollection<CmpDetalleCampañaOportunidad> CmpDetalleCampañaOportunidad { get; set; }
    }
}
