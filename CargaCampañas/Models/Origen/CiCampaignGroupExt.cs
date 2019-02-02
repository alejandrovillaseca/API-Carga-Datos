using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaignGroupExt
    {
        public decimal CampaignGroupSk { get; set; }

        public virtual CiCampaignGroup CampaignGroupSkNavigation { get; set; }
    }
}
