using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiResponseHistory
    {
        public decimal CellPackageSk { get; set; }
        public decimal TreatmentSk { get; set; }
        public string TreatmentHashVal { get; set; }
        public decimal ResponseSk { get; set; }
        public decimal Rut { get; set; }
        public DateTime ResponseDttm { get; set; }
        public DateTime? ResponseDt { get; set; }
        public string ResponseChannelCd { get; set; }
        public string InferredResponseFlg { get; set; }
        public decimal? ResponseValueAmt { get; set; }
        public string ExternalResponseInfoId1 { get; set; }
        public string ExternalResponseInfoId2 { get; set; }
        public string ResponseTrackingCd { get; set; }
        public DateTime? ProcessedDttm { get; set; }
    }
}
