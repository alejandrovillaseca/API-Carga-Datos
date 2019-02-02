using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpEstadoOportunidad
    {
        public CmpEstadoOportunidad()
        {
            CmpEstadosOportunidadPorCanal = new HashSet<CmpEstadosOportunidadPorCanal>();
            CmpOportunidad = new HashSet<CmpOportunidad>();
        }

        public int IdEstadoOportunidad { get; set; }
        public string Codigo { get; set; }
        public string NombreEstOportunidad { get; set; }
        public string DescEstOportunidad { get; set; }
        public string CodCanalExterno { get; set; }
        public int? CodRespuestaExterno { get; set; }
        public string DatoExterno01 { get; set; }

        public virtual ICollection<CmpEstadosOportunidadPorCanal> CmpEstadosOportunidadPorCanal { get; set; }
        public virtual ICollection<CmpOportunidad> CmpOportunidad { get; set; }
    }
}
