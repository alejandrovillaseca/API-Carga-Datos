using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.CMP_GESTION
{
    public partial class CmpBody
    {
        public int Id { get; set; }
        public int IdHead { get; set; }
        public string Nombre { get; set; }
        public string CustomValue { get; set; }
        public string Mapeo { get; set; }
        public string MapeoImap { get; set; }
        public string CommContacto { get; set; }
        public string Cockpit { get; set; }
        public string ValorPorDefecto { get; set; }
        public Guid? UsrCreaReg { get; set; }
        public DateTime? FechaCreaReg { get; set; }
        public Guid? UsrModificaReg { get; set; }
        public DateTime? FechaModificaReg { get; set; }
    }
}
