using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CommContactosMulticanal
    {
        public long Id { get; set; }
        public decimal Rut { get; set; }
        public string DigitoRut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Idsucursal { get; set; }
        public string Sucursal { get; set; }
        public int Ordencmpcanal { get; set; }
        public int Idcmpejec { get; set; }
        public string Idejecutivo { get; set; }
        public string Ejecutivo { get; set; }
        public string Emailcontacto { get; set; }
        public string Telefonocontacto { get; set; }
        public string ResponseTrackingCd { get; set; }
        public string Estado { get; set; }
        public string IdCampana { get; set; }
        public int? TipCampana { get; set; }
        public string TipProducto { get; set; }
        public string Canal { get; set; }
        public DateTime? FeciniCamp { get; set; }
        public DateTime? FecfinCamp { get; set; }
        public string IdWcmWeb { get; set; }
        public string Nombrecampana { get; set; }
        public string Tipodefuncional { get; set; }
        public string CustomValue1 { get; set; }
        public string CustomValue2 { get; set; }
        public string CustomValue3 { get; set; }
        public string CustomValue4 { get; set; }
        public string CustomValue5 { get; set; }
        public string CustomValue6 { get; set; }
        public string CustomValue7 { get; set; }
        public string CustomValue8 { get; set; }
        public string CustomValue9 { get; set; }
        public string CustomValue10 { get; set; }
        public string CustomValue11 { get; set; }
        public string CustomValue12 { get; set; }
        public string CustomValue13 { get; set; }
        public string CustomValue14 { get; set; }
        public string CustomValue15 { get; set; }
        public string CustomValue16 { get; set; }
        public string CustomValue17 { get; set; }
        public string CustomValue18 { get; set; }
        public string CustomValue19 { get; set; }
        public string CustomValue20 { get; set; }
        public string CustomValue21 { get; set; }
        public string CustomValue22 { get; set; }
        public string CustomValue23 { get; set; }
        public string CustomValue24 { get; set; }
        public string CustomValue25 { get; set; }
        public DateTime? Fechaingreso { get; set; }
        public DateTime? Fechaprocesamiento { get; set; }
        public bool? Procesado { get; set; }
        public string XmlNegociacion { get; set; }
        public bool? Error { get; set; }
        public string Descripcionerror { get; set; }
    }
}
