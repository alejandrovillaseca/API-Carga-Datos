using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CockPitHistoricoEstadoOportunidad
    {
        public long IdHistoricoCp { get; set; }
        public long IdHistoricoEstadoOportunidad { get; set; }
        public long IdOportunidad { get; set; }
        public int RutPersona { get; set; }
        public string DvPersona { get; set; }
        public int? IdCanalCambioEstado { get; set; }
        public DateTime? FechaCambioEstado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string IdEjecutivoGestion { get; set; }
    }
}
