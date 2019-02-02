using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Motor_SAS_V2
{
    public partial class SasOfertaCampana
    {
        public long IdOfertaCampana { get; set; }
        public long IdOportunidad { get; set; }
        public string IdCmpEjec { get; set; }
        public string Canal { get; set; }
        public string ResponseTrackCd { get; set; }
        public bool CmpCnlMigrado { get; set; }
        public int OrdenCmpCanal { get; set; }
        public string Campo { get; set; }
        public string Valor { get; set; }
        public bool CampanaEmpresa { get; set; }
    }
}
