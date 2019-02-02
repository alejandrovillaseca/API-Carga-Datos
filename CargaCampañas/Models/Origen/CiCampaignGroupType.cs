using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaignGroupType
    {
        public CiCampaignGroupType()
        {
            CiCampaignGroup = new HashSet<CiCampaignGroup>();
        }

        public string CampaignGroupTypeCd { get; set; }
        public string CampaignGroupTypeDesc { get; set; }

        public virtual ICollection<CiCampaignGroup> CiCampaignGroup { get; set; }
    }
}
