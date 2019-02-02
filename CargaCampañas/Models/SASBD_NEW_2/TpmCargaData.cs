using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class TpmCargaData
    {
        public int Id { get; set; }
        public string RutConDv { get; set; }
        public string IdCampaña { get; set; }
        public DateTime? FechaProceso { get; set; }
        public string Observación { get; set; }
        public bool? Procesado { get; set; }
    }
}
