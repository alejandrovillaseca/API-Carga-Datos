using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiTreatCampSetStatus
    {
        public CiTreatCampSetStatus()
        {
            CiTreatmentCampaignSet = new HashSet<CiTreatmentCampaignSet>();
        }

        public string TreatCampSetStatusCd { get; set; }
        public string TreatCampSetStatusDesc { get; set; }

        public virtual ICollection<CiTreatmentCampaignSet> CiTreatmentCampaignSet { get; set; }
    }
}
