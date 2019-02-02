using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class ParCamposMigrados
    {
        public ParCamposMigrados()
        {
            CmpValoresPersonalizadosDetalleMigrado = new HashSet<CmpValoresPersonalizadosDetalleMigrado>();
        }

        public int IdCamposMigrados { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<CmpValoresPersonalizadosDetalleMigrado> CmpValoresPersonalizadosDetalleMigrado { get; set; }
    }
}
