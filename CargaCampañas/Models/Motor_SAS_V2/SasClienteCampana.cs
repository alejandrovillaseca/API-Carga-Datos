using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Motor_SAS_V2
{
    public partial class SasClienteCampana
    {
        public long IdOportunidad { get; set; }
        public string IdCmpEjec { get; set; }
        public int RutCliente { get; set; }
        public string DvCliente { get; set; }
        public int? IdClienteAltamira { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? RutEmpresa { get; set; }
        public string DvEmpresa { get; set; }
        public string NombreEjecutivo { get; set; }
        public string NombreSucursal { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Procesado { get; set; }
        public DateTime? FechaProcesamiento { get; set; }
        public bool? Error { get; set; }
        public string DescripcionError { get; set; }
        public string IdWcm { get; set; }
    }
}
