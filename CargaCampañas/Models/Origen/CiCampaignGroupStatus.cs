using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaignGroupStatus
    {
        public CiCampaignGroupStatus()
        {
            CiCampaignGroup = new HashSet<CiCampaignGroup>();
        }

        public string CampaignGroupStatusCd { get; set; }
        public string CampaignGroupStatusDesc { get; set; }

        public virtual ICollection<CiCampaignGroup> CiCampaignGroup { get; set; }
    }
}
