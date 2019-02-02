using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Motor_SAS_V2
{
    public partial class CommNovedadesRutMulticanal
    {
        public int Id { get; set; }
        public decimal? Rut { get; set; }
        public int? Idcmpejec { get; set; }
        public bool? Vigente { get; set; }
        public int? IdCanal { get; set; }
        public string Glosa { get; set; }
        public DateTime? Fechacarga { get; set; }
        public string Idcampaña { get; set; }
    }
}
