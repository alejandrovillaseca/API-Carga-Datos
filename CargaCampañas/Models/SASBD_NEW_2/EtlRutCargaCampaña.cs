using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class EtlRutCargaCampaña
    {
        public int RutCliente { get; set; }
        public long IdOportunidad { get; set; }
        public string IdCmpEjec { get; set; }
        public string IdCampana { get; set; }
        public bool? Error { get; set; }
        public string DescripcionError { get; set; }
    }
}
