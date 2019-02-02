using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCtlGrpCellXTestCell
    {
        public decimal ControlGroupCellSk { get; set; }
        public decimal MarketingCellSk { get; set; }

        public virtual CiMarketingCell ControlGroupCellSkNavigation { get; set; }
        public virtual CiMarketingCell MarketingCellSkNavigation { get; set; }
    }
}
