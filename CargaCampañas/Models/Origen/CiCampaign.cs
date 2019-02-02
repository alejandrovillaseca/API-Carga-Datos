using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampaign
    {
        public CiCampaign()
        {
            CiCampPage = new HashSet<CiCampPage>();
            CiCellPackage = new HashSet<CiCellPackage>();
            CiChangeLog = new HashSet<CiChangeLog>();
            CiCommunication = new HashSet<CiCommunication>();
            CiMarketingCell = new HashSet<CiMarketingCell>();
            CiTreatCampSetXCampaign = new HashSet<CiTreatCampSetXCampaign>();
        }

        public decimal CampaignSk { get; set; }
        public string CampaignCd { get; set; }
        public string CampaignStatusCd { get; set; }
        public decimal? CampaignVersionNo { get; set; }
        public string CurrentVersionFlg { get; set; }
        public string CampaignNm { get; set; }
        public string CampaignDesc { get; set; }
        public string CampaignFolderTxt { get; set; }
        public string CampaignOwnerNm { get; set; }
        public decimal? CampaignGroupSk { get; set; }
        public decimal? DeploymentVersionNo { get; set; }
        public decimal? MinBudgetOfferAmt { get; set; }
        public decimal? MaxBudgetOfferAmt { get; set; }
        public decimal? MinBudgetAmt { get; set; }
        public decimal? MaxBudgetAmt { get; set; }
        public DateTime? StartDttm { get; set; }
        public DateTime? EndDttm { get; set; }
        public DateTime? RunDttm { get; set; }
        public DateTime? LastModifiedDttm { get; set; }
        public string LastModifiedByUserNm { get; set; }
        public DateTime? ApprovalDttm { get; set; }
        public string ApprovalGivenByNm { get; set; }
        public string BusinessContextNm { get; set; }
        public string CampaignTypeCd { get; set; }
        public string DeletedFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaignGroup CampaignGroupSkNavigation { get; set; }
        public virtual CiCampaignStatus CampaignStatusCdNavigation { get; set; }
        public virtual CiCampaignType CampaignTypeCdNavigation { get; set; }
        public virtual CiCampaignExt CiCampaignExt { get; set; }
        public virtual ICollection<CiCampPage> CiCampPage { get; set; }
        public virtual ICollection<CiCellPackage> CiCellPackage { get; set; }
        public virtual ICollection<CiChangeLog> CiChangeLog { get; set; }
        public virtual ICollection<CiCommunication> CiCommunication { get; set; }
        public virtual ICollection<CiMarketingCell> CiMarketingCell { get; set; }
        public virtual ICollection<CiTreatCampSetXCampaign> CiTreatCampSetXCampaign { get; set; }
    }
}
