using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampGrpXMoOptScenario
    {
        public decimal CampaignGroupSk { get; set; }
        public decimal MoOptScenarioSk { get; set; }

        public virtual CiCampaignGroup CampaignGroupSkNavigation { get; set; }
        public virtual CiMoOptimizationScenario MoOptScenarioSkNavigation { get; set; }
    }
}
