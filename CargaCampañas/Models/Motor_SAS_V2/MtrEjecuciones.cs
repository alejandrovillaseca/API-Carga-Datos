using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Motor_SAS_V2
{
    public partial class MtrEjecuciones
    {
        public decimal Rut { get; set; }
        public long IdCamp { get; set; }
        public string Codcampana { get; set; }
        public long IdOportunidad { get; set; }
    }
}
