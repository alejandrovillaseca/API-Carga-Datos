using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CommNovedadesRut
    {
        public int Id { get; set; }
        public decimal Rut { get; set; }
        public double? IdCampaña { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaCarga { get; set; }
    }
}
