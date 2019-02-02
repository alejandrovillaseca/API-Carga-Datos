using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiPresentedTreatmentHistory
    {
        public decimal CellPackageSk { get; set; }
        public decimal Rut { get; set; }
        public decimal TreatmentSk { get; set; }
        public string TreatmentHashVal { get; set; }
        public DateTime PresentedTreatmentHistDttm { get; set; }
        public DateTime? PresentedTreatmentDt { get; set; }
        public string ExternalPresentedInfoId1 { get; set; }
        public string ExternalPresentedInfoId2 { get; set; }
        public string ResponseTrackingCd { get; set; }
    }
}
