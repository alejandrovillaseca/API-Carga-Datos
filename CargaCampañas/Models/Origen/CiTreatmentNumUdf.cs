using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiTreatmentNumUdf
    {
        public decimal TreatmentSk { get; set; }
        public string NumUdfNm { get; set; }
        public string TreatmentHashVal { get; set; }
        public decimal? NumUdfVal { get; set; }
        public string NumExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiTreatment TreatmentSkNavigation { get; set; }
    }
}
