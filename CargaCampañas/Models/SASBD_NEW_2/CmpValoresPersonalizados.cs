using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpValoresPersonalizados
    {
        public long IdValoresPersonalizados { get; set; }
        public long IdDetalleCampañaOportunidad { get; set; }
        public string Llave { get; set; }
        public string Valor { get; set; }
        public bool? Vigente { get; set; }
        public string LlaveCv { get; set; }
        public string LlaveCp { get; set; }

        public virtual CmpDetalleCampañaOportunidad IdDetalleCampañaOportunidadNavigation { get; set; }
    }
}
