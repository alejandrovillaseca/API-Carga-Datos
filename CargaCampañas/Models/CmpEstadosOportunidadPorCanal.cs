using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpEstadosOportunidadPorCanal
    {
        public int IdEstadoOportunidad { get; set; }
        public int IdCanal { get; set; }
        public bool Visualizar { get; set; }
        public bool Vigente { get; set; }

        public virtual CmpCanal IdCanalNavigation { get; set; }
        public virtual CmpEstadoOportunidad IdEstadoOportunidadNavigation { get; set; }
    }
}
