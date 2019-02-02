using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpTablaXmlprc
    {
        public int Id { get; set; }
        public int Rut { get; set; }
        public string RutDv { get; set; }
        public int? NumeroSolicitud { get; set; }
        public string RqinotIndNotario { get; set; }
        public string RqicomIndSegComplem { get; set; }
        public string RqidesIndSegDesgrav { get; set; }
        public string RqiimpIndImpuesto { get; set; }
        public int? RqmodcModalidadCalculo { get; set; }
        public string RqtipcTipoCredito { get; set; }
        public int? RqsucnSucursalNotario { get; set; }
        public int? RqnaseNumeroAsegurados { get; set; }
        public string RqmoneCodigoMoneda { get; set; }
        public string RqetriExcensionTribut { get; set; }
        public int? RqplazPlazoCredito { get; set; }
        public string RqfrepFrecuenciaDePago { get; set; }
        public decimal? RqtcomTasaSegCompl1 { get; set; }
        public int? CodcomCodigoDeSegComp1 { get; set; }
        public string NomcomNombreDeSegComp1 { get; set; }
        public decimal? RqmcreMontoCredito { get; set; }
        public decimal? RqtscoTasaSegCompl2 { get; set; }
        public decimal? CodscoCodigoDeSegComp2 { get; set; }
        public string NomscoNombreDeSegComp2 { get; set; }
        public decimal? RqtasaTasaInteres { get; set; }
        public int? RqindiIndCotizaciones { get; set; }
        public string RqcimpArregloCuotasExim { get; set; }
        public string Canal { get; set; }
        public string Tipodefuncional { get; set; }
        public string TipProducto { get; set; }
        public int? TipCampana { get; set; }
        public DateTime Fechaingreso { get; set; }
        public int IdOportunidad { get; set; }
        public int? PeriodoGracia { get; set; }
    }
}
