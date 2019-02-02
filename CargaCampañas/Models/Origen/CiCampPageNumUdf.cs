﻿using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCampPageNumUdf
    {
        public decimal CampaignSk { get; set; }
        public string PageNm { get; set; }
        public string NumUdfNm { get; set; }
        public decimal? NumUdfVal { get; set; }
        public string NumExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCampPage CiCampPage { get; set; }
    }
}
