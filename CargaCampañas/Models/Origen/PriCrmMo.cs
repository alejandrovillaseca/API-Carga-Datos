using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class PriCrmMo
    {
        public int Id { get; set; }
        public int Rut { get; set; }
        public string Dv { get; set; }
        public long IdOportunidad { get; set; }
        public string IdCmpEjec { get; set; }
        public string IdCampaña { get; set; }
        public int TipoProducto { get; set; }
        public int TipoFuncional { get; set; }
        public int TipoCampañas { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public int Canal { get; set; }
    }
}
