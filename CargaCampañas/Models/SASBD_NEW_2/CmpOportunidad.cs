using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpOportunidad
    {
        public CmpOportunidad()
        {
            CmpDetalleCampañaOportunidad = new HashSet<CmpDetalleCampañaOportunidad>();
            CmpHistoricoEstadoOportunidad = new HashSet<CmpHistoricoEstadoOportunidad>();
        }

        public long IdOportunidad { get; set; }
        public int RutPersona { get; set; }
        public string DvPersona { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidoPersona { get; set; }
        public int? RutEmpresa { get; set; }
        public DateTime? FechaCambioEstado { get; set; }
        public int IdEstadoOportunidad { get; set; }
        public int IdCanalCambioEstado { get; set; }
        public string EmailContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public int? IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public int? IdEjecutivo { get; set; }
        public string NombreEjecutivo { get; set; }
        public string DvEmpresa { get; set; }
        public string IdClienteAltamira { get; set; }
        public string IdWcm { get; set; }
        public string IdEjecutivoGestion { get; set; }

        public virtual CmpEstadoOportunidad IdEstadoOportunidadNavigation { get; set; }
        public virtual ICollection<CmpDetalleCampañaOportunidad> CmpDetalleCampañaOportunidad { get; set; }
        public virtual ICollection<CmpHistoricoEstadoOportunidad> CmpHistoricoEstadoOportunidad { get; set; }
    }
}
