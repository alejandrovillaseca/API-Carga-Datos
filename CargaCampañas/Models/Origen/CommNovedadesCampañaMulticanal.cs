using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CommNovedadesCampañaMulticanal
    {
        public int Id { get; set; }
        public int Idcmpejec { get; set; }
        public int? IdCanal { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Glosa { get; set; }
        public DateTime? Fechacarga { get; set; }
    }
}
