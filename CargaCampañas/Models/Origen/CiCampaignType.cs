using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaignType
    {
        public CiCampaignType()
        {
            CiCampaign = new HashSet<CiCampaign>();
        }

        public string CampaignTypeCd { get; set; }
        public string CampaignTypeDesc { get; set; }

        public virtual ICollection<CiCampaign> CiCampaign { get; set; }
    }
}
