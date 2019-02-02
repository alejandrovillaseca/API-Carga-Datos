using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpDetalleCampañaOportunidadHistorico
    {
        public long IdDetalleCampañaOportunidadHistorico { get; set; }
        public long IdDetalleCampañaOportunidad { get; set; }
        public int OrdenPropension { get; set; }
        public bool? Vigente { get; set; }
        public string Glosa { get; set; }
        public DateTime FechaCambio { get; set; }

        public virtual CmpDetalleCampañaOportunidad IdDetalleCampañaOportunidadNavigation { get; set; }
    }
}
