using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampGrpPageDateUdf
    {
        public decimal CampaignGroupSk { get; set; }
        public string PageNm { get; set; }
        public string DateUdfNm { get; set; }
        public DateTime? DateUdfVal { get; set; }
        public string DateExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampGrpPage CiCampGrpPage { get; set; }
    }
}
