using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiTreatmentDateUdf
    {
        public decimal TreatmentSk { get; set; }
        public string DateUdfNm { get; set; }
        public string TreatmentHashVal { get; set; }
        public DateTime? DateUdfVal { get; set; }
        public string DateExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiTreatment TreatmentSkNavigation { get; set; }
    }
}
