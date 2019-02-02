using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
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
