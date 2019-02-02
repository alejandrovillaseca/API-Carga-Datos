using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class TmpOfertaCampanaPiv2Nose
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
        public bool CamapañaEmpresa { get; set; }
    }
}
