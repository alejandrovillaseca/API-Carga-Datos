using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpCanal
    {
        public CmpCanal()
        {
            CmpDetalleCampaña = new HashSet<CmpDetalleCampaña>();
            CmpEstadosOportunidadPorCanal = new HashSet<CmpEstadosOportunidadPorCanal>();
        }

        public int IdCanal { get; set; }
        public string NombreCanal { get; set; }
        public string DescCanal { get; set; }
        public int CodigoCanal { get; set; }

        public virtual ICollection<CmpDetalleCampaña> CmpDetalleCampaña { get; set; }
        public virtual ICollection<CmpEstadosOportunidadPorCanal> CmpEstadosOportunidadPorCanal { get; set; }
    }
}
