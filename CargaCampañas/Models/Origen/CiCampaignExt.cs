using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaignExt
    {
        public decimal CampaignSk { get; set; }
        public decimal? IdCampana { get; set; }
        public string DescCampana { get; set; }
        public string TipCampana { get; set; }
        public string TipProducto { get; set; }
        public string Notificacion { get; set; }

        public virtual CiCampaign CampaignSkNavigation { get; set; }
    }
}
