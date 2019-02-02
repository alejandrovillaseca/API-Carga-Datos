using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpValoresPersonalizadosDetalle
    {
        public CmpValoresPersonalizadosDetalle()
        {
            CmpValoresPersonalizadosDetalleMigrado = new HashSet<CmpValoresPersonalizadosDetalleMigrado>();
        }

        public int Id { get; set; }
        public int IdTipoCampaña { get; set; }
        public int IdTipoProducto { get; set; }
        public int IdFuncional { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string NombreMigrado { get; set; }
        public string NombreCockpit { get; set; }
        public string Comm { get; set; }

        public virtual ICollection<CmpValoresPersonalizadosDetalleMigrado> CmpValoresPersonalizadosDetalleMigrado { get; set; }
    }
}
