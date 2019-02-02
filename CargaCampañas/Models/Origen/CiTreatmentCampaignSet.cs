using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiTreatmentCampaignSet
    {
        public CiTreatmentCampaignSet()
        {
            CiTreatCampSetXCampaign = new HashSet<CiTreatCampSetXCampaign>();
        }

        public decimal TreatmentCampaignSetSk { get; set; }
        public string TreatmentCampSetNm { get; set; }
        public string TreatmentCampSetDesc { get; set; }
        public string TreatmentCampSetFolderTxt { get; set; }
        public string LastModifiedByUserNm { get; set; }
        public DateTime? LastModifiedDttm { get; set; }
        public string TreatCampSetStatusCd { get; set; }
        public string DeletedFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiTreatCampSetStatus TreatCampSetStatusCdNavigation { get; set; }
        public virtual ICollection<CiTreatCampSetXCampaign> CiTreatCampSetXCampaign { get; set; }
    }
}
