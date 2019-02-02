using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Motor_SAS_V2
{
    public partial class CommContactos
    {
        public decimal Rut { get; set; }
        public string DigitoRut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sucursal { get; set; }
        public string MonAprobado { get; set; }
        public string OfertaCupo1 { get; set; }
        public string OfertaCupo2 { get; set; }
        public string OfertaCupo3 { get; set; }
        public string OfertaCupo4 { get; set; }
        public string OfertaCupo5 { get; set; }
        public string Tasa { get; set; }
        public string Ejecutivo { get; set; }
        public string Email { get; set; }
        public string ResponseTrackingCd { get; set; }
        public string Estado { get; set; }
        public string IdCampana { get; set; }
        public int? TipCampana { get; set; }
        public string TipProducto { get; set; }
        public string Notificacion { get; set; }
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
        public string TextoVariable1 { get; set; }
        public string TextoVariable2 { get; set; }
        public string TextoVariable3 { get; set; }
        public string TextoVariable4 { get; set; }
        public string Nombrecampana { get; set; }
        public string Tipodefuncional { get; set; }
        public string IdCampanaCrm { get; set; }
    }
}
