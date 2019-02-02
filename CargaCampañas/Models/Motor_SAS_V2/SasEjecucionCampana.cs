using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Motor_SAS_V2
{
    public partial class SasEjecucionCampana
    {
        public string IdCmpEjec { get; set; }
        public string IdCampana { get; set; }
        public string NombreCampana { get; set; }
        public string DescripcionCampana { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string IdTipoCampana { get; set; }
        public string IdTipoFuncional { get; set; }
        public string IdTipoProducto { get; set; }
    }
}
