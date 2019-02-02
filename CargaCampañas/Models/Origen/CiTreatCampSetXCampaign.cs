using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiTreatCampSetXCampaign
    {
        public decimal TreatmentCampaignSetSk { get; set; }
        public decimal CampaignSk { get; set; }
        public string DeletedFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaign CampaignSkNavigation { get; set; }
        public virtual CiTreatmentCampaignSet TreatmentCampaignSetSkNavigation { get; set; }
    }
}
