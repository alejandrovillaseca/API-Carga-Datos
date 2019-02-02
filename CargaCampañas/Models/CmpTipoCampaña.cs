using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpTipoCampaña
    {
        public CmpTipoCampaña()
        {
            CmpCampaña = new HashSet<CmpCampaña>();
        }

        public int IdTipoCampaña { get; set; }
        public string NombreTipCampaña { get; set; }
        public string DescTipCampaña { get; set; }

        public virtual ICollection<CmpCampaña> CmpCampaña { get; set; }
    }
}
