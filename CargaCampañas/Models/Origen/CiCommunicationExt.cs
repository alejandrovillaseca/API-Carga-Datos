using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCommunicationExt
    {
        public decimal CommunicationSk { get; set; }
        public string Canales { get; set; }
        public DateTime? FeciniWeb { get; set; }
        public DateTime? FecfinWeb { get; set; }
        public string Texto1Web { get; set; }
        public string Texto2Web { get; set; }
        public string FinFlujo { get; set; }
        public string EstiloWeb { get; set; }
        public string IdWcmWeb { get; set; }
        public string LinkWeb { get; set; }
        public string AcCierreWeb { get; set; }
        public DateTime? FeciniMobile { get; set; }
        public DateTime? FecfinMobile { get; set; }
        public string Texto1Mobile { get; set; }
        public string Texto2Mobile { get; set; }
        public string LinkMobile { get; set; }
        public string AcCierreMobile { get; set; }
        public DateTime? FeciniAgenda { get; set; }
        public DateTime? FecfinAgenda { get; set; }
        public string SaludoEmail { get; set; }
        public string TipoEmail { get; set; }
        public string NombreCampana { get; set; }
        public string TipodeFuncional { get; set; }

        public virtual CiCommunication CommunicationSkNavigation { get; set; }
    }
}
