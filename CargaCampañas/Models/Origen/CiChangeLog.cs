using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiChangeLog
    {
        public decimal CampaignSk { get; set; }
        public string ChangeTypeCd { get; set; }
        public DateTime ChangeDttm { get; set; }
        public string ChangedByUserNm { get; set; }
        public string ChangeTxt { get; set; }

        public virtual CiCampaign CampaignSkNavigation { get; set; }
        public virtual CiChangeType ChangeTypeCdNavigation { get; set; }
    }
}
