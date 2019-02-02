using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCellPackage
    {
        public CiCellPackage()
        {
            CiDynamicTreatmentAttribute = new HashSet<CiDynamicTreatmentAttribute>();
            CiPackageXTreatment = new HashSet<CiPackageXTreatment>();
            CiResponseXCellPackage = new HashSet<CiResponseXCellPackage>();
        }

        public decimal CellPackageSk { get; set; }
        public decimal CampaignSk { get; set; }
        public string CampaignCd { get; set; }
        public string CampaignNm { get; set; }
        public decimal CommunicationSk { get; set; }
        public string CommunicationCd { get; set; }
        public string CommunicationNm { get; set; }
        public decimal? CommunicationOccurrenceNo { get; set; }
        public decimal MarketingCellSk { get; set; }
        public string MarketingCellCd { get; set; }
        public string MarketingCellNm { get; set; }
        public string MarketingCellDesc { get; set; }
        public decimal? PackageSk { get; set; }
        public string PackageCd { get; set; }
        public string ChannelCd { get; set; }
        public string SubjectTypeNm { get; set; }
        public string ControlGroupTypeCd { get; set; }
        public decimal? TotalPreoptimizedContactCnt { get; set; }
        public string TrackPresentedTreatmentsFlg { get; set; }
        public decimal? MaxTreatmentCnt { get; set; }
        public string DeletedFlg { get; set; }
        public string ResponseTrackingCd { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaign CampaignSkNavigation { get; set; }
        public virtual CiCommunication CommunicationSkNavigation { get; set; }
        public virtual CiControlGroupType ControlGroupTypeCdNavigation { get; set; }
        public virtual CiMarketingCell MarketingCellSkNavigation { get; set; }
        public virtual CiPackage PackageSkNavigation { get; set; }
        public virtual ICollection<CiDynamicTreatmentAttribute> CiDynamicTreatmentAttribute { get; set; }
        public virtual ICollection<CiPackageXTreatment> CiPackageXTreatment { get; set; }
        public virtual ICollection<CiResponseXCellPackage> CiResponseXCellPackage { get; set; }
    }
}
