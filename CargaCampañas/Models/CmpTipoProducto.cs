using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpTipoProducto
    {
        public CmpTipoProducto()
        {
            CmpCampaña = new HashSet<CmpCampaña>();
        }

        public int IdTipoProducto { get; set; }
        public string NombreTipoProducto { get; set; }
        public string DescTipoProducto { get; set; }

        public virtual ICollection<CmpCampaña> CmpCampaña { get; set; }
    }
}
