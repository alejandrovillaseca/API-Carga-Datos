using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiMarketingCell
    {
        public CiMarketingCell()
        {
            CiCellPackage = new HashSet<CiCellPackage>();
            CiCtlGrpCellXTestCellControlGroupCellSkNavigation = new HashSet<CiCtlGrpCellXTestCell>();
            CiCtlGrpCellXTestCellMarketingCellSkNavigation = new HashSet<CiCtlGrpCellXTestCell>();
        }

        public decimal MarketingCellSk { get; set; }
        public decimal CampaignSk { get; set; }
        public string MarketingCellCd { get; set; }
        public string MarketingCellNm { get; set; }
        public string MarketingCellDesc { get; set; }
        public string ControlGroupTypeCd { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaign CampaignSkNavigation { get; set; }
        public virtual CiControlGroupType ControlGroupTypeCdNavigation { get; set; }
        public virtual ICollection<CiCellPackage> CiCellPackage { get; set; }
        public virtual ICollection<CiCtlGrpCellXTestCell> CiCtlGrpCellXTestCellControlGroupCellSkNavigation { get; set; }
        public virtual ICollection<CiCtlGrpCellXTestCell> CiCtlGrpCellXTestCellMarketingCellSkNavigation { get; set; }
    }
}
