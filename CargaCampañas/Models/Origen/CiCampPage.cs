using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampPage
    {
        public CiCampPage()
        {
            CiCampPageCharUdf = new HashSet<CiCampPageCharUdf>();
            CiCampPageDateUdf = new HashSet<CiCampPageDateUdf>();
            CiCampPageNumUdf = new HashSet<CiCampPageNumUdf>();
        }

        public decimal CampaignSk { get; set; }
        public string PageNm { get; set; }
        public string PageStatusFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampaign CampaignSkNavigation { get; set; }
        public virtual ICollection<CiCampPageCharUdf> CiCampPageCharUdf { get; set; }
        public virtual ICollection<CiCampPageDateUdf> CiCampPageDateUdf { get; set; }
        public virtual ICollection<CiCampPageNumUdf> CiCampPageNumUdf { get; set; }
    }
}
