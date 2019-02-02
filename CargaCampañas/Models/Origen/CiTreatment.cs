using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiTreatment
    {
        public CiTreatment()
        {
            CiDynamicTreatmentAttrExt = new HashSet<CiDynamicTreatmentAttrExt>();
            CiDynamicTreatmentAttribute = new HashSet<CiDynamicTreatmentAttribute>();
            CiPackageXTreatment = new HashSet<CiPackageXTreatment>();
            CiTreatmentCharUdf = new HashSet<CiTreatmentCharUdf>();
            CiTreatmentDateUdf = new HashSet<CiTreatmentDateUdf>();
            CiTreatmentNumUdf = new HashSet<CiTreatmentNumUdf>();
        }

        public decimal TreatmentSk { get; set; }
        public string TreatmentCd { get; set; }
        public decimal? TreatmentVersionNo { get; set; }
        public string TreatmentNm { get; set; }
        public string TreatmentDesc { get; set; }
        public string TreatmentReferenceTxt { get; set; }
        public string TreatmentReferenceUrl { get; set; }
        public string CurrentVersionFlg { get; set; }
        public DateTime? StartDttm { get; set; }
        public DateTime? EndDttm { get; set; }
        public string DeletedFlg { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiTreatmentExt CiTreatmentExt { get; set; }
        public virtual ICollection<CiDynamicTreatmentAttrExt> CiDynamicTreatmentAttrExt { get; set; }
        public virtual ICollection<CiDynamicTreatmentAttribute> CiDynamicTreatmentAttribute { get; set; }
        public virtual ICollection<CiPackageXTreatment> CiPackageXTreatment { get; set; }
        public virtual ICollection<CiTreatmentCharUdf> CiTreatmentCharUdf { get; set; }
        public virtual ICollection<CiTreatmentDateUdf> CiTreatmentDateUdf { get; set; }
        public virtual ICollection<CiTreatmentNumUdf> CiTreatmentNumUdf { get; set; }
    }
}
