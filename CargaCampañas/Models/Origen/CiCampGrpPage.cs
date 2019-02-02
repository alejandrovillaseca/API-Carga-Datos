using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampGrpPage
    {
        public CiCampGrpPage()
        {
            CiCampGrpPageCharUdf = new HashSet<CiCampGrpPageCharUdf>();
            CiCampGrpPageDateUdf = new HashSet<CiCampGrpPageDateUdf>();
            CiCampGrpPageNumUdf = new HashSet<CiCampGrpPageNumUdf>();
        }

        public decimal CampaignGroupSk { get; set; }
        public string PageNm { get; set; }
        public string PageStatusFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaignGroup CampaignGroupSkNavigation { get; set; }
        public virtual ICollection<CiCampGrpPageCharUdf> CiCampGrpPageCharUdf { get; set; }
        public virtual ICollection<CiCampGrpPageDateUdf> CiCampGrpPageDateUdf { get; set; }
        public virtual ICollection<CiCampGrpPageNumUdf> CiCampGrpPageNumUdf { get; set; }
    }
}
