using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampPageDateUdf
    {
        public decimal CampaignSk { get; set; }
        public string PageNm { get; set; }
        public string DateUdfNm { get; set; }
        public DateTime? DateUdfVal { get; set; }
        public string DateExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampPage CiCampPage { get; set; }
    }
}
