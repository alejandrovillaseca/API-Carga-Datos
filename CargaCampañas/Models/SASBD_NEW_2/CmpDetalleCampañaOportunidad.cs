using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpDetalleCampañaOportunidad
    {
        public CmpDetalleCampañaOportunidad()
        {
            CmpDetalleCampañaOportunidadHistorico = new HashSet<CmpDetalleCampañaOportunidadHistorico>();
            CmpValoresPersonalizados = new HashSet<CmpValoresPersonalizados>();
        }

        public long IdDetalleCampañaOportunidad { get; set; }
        public string IdCampaña { get; set; }
        public long IdOportunidad { get; set; }
        public long IdDetalleCampaña { get; set; }
        public int OrdenPropension { get; set; }
        public bool? Vigente { get; set; }
        public string Glosa { get; set; }
        public bool EstadoMensajeria { get; set; }

        public virtual CmpCampaña IdCampañaNavigation { get; set; }
        public virtual CmpDetalleCampaña IdDetalleCampañaNavigation { get; set; }
        public virtual CmpOportunidad IdOportunidadNavigation { get; set; }
        public virtual ICollection<CmpDetalleCampañaOportunidadHistorico> CmpDetalleCampañaOportunidadHistorico { get; set; }
        public virtual ICollection<CmpValoresPersonalizados> CmpValoresPersonalizados { get; set; }
    }
}
