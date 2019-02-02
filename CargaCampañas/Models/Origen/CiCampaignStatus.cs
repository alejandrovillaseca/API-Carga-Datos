using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaignStatus
    {
        public CiCampaignStatus()
        {
            CiCampaign = new HashSet<CiCampaign>();
        }

        public string CampaignStatusCd { get; set; }
        public string CampaignStatusDesc { get; set; }

        public virtual ICollection<CiCampaign> CiCampaign { get; set; }
    }
}
