using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CommNovedadesCampaña
    {
        public int Id { get; set; }
        public double IdCampaña { get; set; }
        public int? IdCanal { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
