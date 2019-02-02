using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaignGroup
    {
        public CiCampaignGroup()
        {
            CiCampGrpPage = new HashSet<CiCampGrpPage>();
            CiCampGrpXMoOptScenario = new HashSet<CiCampGrpXMoOptScenario>();
            CiCampaign = new HashSet<CiCampaign>();
        }

        public decimal CampaignGroupSk { get; set; }
        public string CampaignGroupCd { get; set; }
        public string CampaignGroupNm { get; set; }
        public string CampaignGroupDesc { get; set; }
        public string CampaignGroupTypeCd { get; set; }
        public decimal? CampaignGroupVersionNo { get; set; }
        public string CampaignGroupFolderTxt { get; set; }
        public string CampaignGroupStatusCd { get; set; }
        public decimal? MinBudgetOfferAmt { get; set; }
        public decimal? MaxBudgetOfferAmt { get; set; }
        public decimal? MinBudgetAmt { get; set; }
        public decimal? MaxBudgetAmt { get; set; }
        public string LastModifiedByUserNm { get; set; }
        public DateTime? LastModifiedDttm { get; set; }
        public string DeletedFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaignGroupStatus CampaignGroupStatusCdNavigation { get; set; }
        public virtual CiCampaignGroupType CampaignGroupTypeCdNavigation { get; set; }
        public virtual CiCampaignGroupExt CiCampaignGroupExt { get; set; }
        public virtual ICollection<CiCampGrpPage> CiCampGrpPage { get; set; }
        public virtual ICollection<CiCampGrpXMoOptScenario> CiCampGrpXMoOptScenario { get; set; }
        public virtual ICollection<CiCampaign> CiCampaign { get; set; }
    }
}
