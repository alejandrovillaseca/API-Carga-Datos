using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampGrpPageCharUdf
    {
        public decimal CampaignGroupSk { get; set; }
        public string PageNm { get; set; }
        public string CharUdfNm { get; set; }
        public string CharUdfVal { get; set; }
        public string CharExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampGrpPage CiCampGrpPage { get; set; }
    }
}
