using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCommunication
    {
        public CiCommunication()
        {
            CiCellPackage = new HashSet<CiCellPackage>();
            CiCommunicationCharUdf = new HashSet<CiCommunicationCharUdf>();
            CiCommunicationDateUdf = new HashSet<CiCommunicationDateUdf>();
            CiCommunicationNumUdf = new HashSet<CiCommunicationNumUdf>();
        }

        public decimal CommunicationSk { get; set; }
        public decimal CampaignSk { get; set; }
        public string CommunicationCd { get; set; }
        public decimal? CommunicationOccurrenceNo { get; set; }
        public string CommunicationNm { get; set; }
        public string CommunicationDesc { get; set; }
        public string CommunicationStatusCd { get; set; }
        public string CommunicationRecurrTypeCd { get; set; }
        public string SubjectTypeNm { get; set; }
        public decimal? MinBudgetOfferAmt { get; set; }
        public decimal? MaxBudgetOfferAmt { get; set; }
        public decimal? MinBudgetAmt { get; set; }
        public decimal? MaxBudgetAmt { get; set; }
        public decimal? BudgetUnitCostAmt { get; set; }
        public decimal? BudgetUnitUsageAmt { get; set; }
        public DateTime? StartDttm { get; set; }
        public DateTime? EndDttm { get; set; }
        public DateTime? ExportDttm { get; set; }
        public string UpdateContactHistoryFlg { get; set; }
        public string StandardReplyFlg { get; set; }
        public string DeletedFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaign CampaignSkNavigation { get; set; }
        public virtual CiCommunicationRecurrType CommunicationRecurrTypeCdNavigation { get; set; }
        public virtual CiCommunicationStatus CommunicationStatusCdNavigation { get; set; }
        public virtual CiCommunicationExt CiCommunicationExt { get; set; }
        public virtual ICollection<CiCellPackage> CiCellPackage { get; set; }
        public virtual ICollection<CiCommunicationCharUdf> CiCommunicationCharUdf { get; set; }
        public virtual ICollection<CiCommunicationDateUdf> CiCommunicationDateUdf { get; set; }
        public virtual ICollection<CiCommunicationNumUdf> CiCommunicationNumUdf { get; set; }
    }
}
