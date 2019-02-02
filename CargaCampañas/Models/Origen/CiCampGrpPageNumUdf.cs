using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampGrpPageNumUdf
    {
        public decimal CampaignGroupSk { get; set; }
        public string PageNm { get; set; }
        public string NumUdfNm { get; set; }
        public decimal? NumUdfVal { get; set; }
        public string NumExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampGrpPage CiCampGrpPage { get; set; }
    }
}
