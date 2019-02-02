using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiContactHistory
    {
        public decimal CellPackageSk { get; set; }
        public decimal Rut { get; set; }
        public DateTime ContactDttm { get; set; }
        public DateTime? ContactDt { get; set; }
        public string ContactHistoryStatusCd { get; set; }
        public string PackageHashVal { get; set; }
        public string OptimizationBackfillFlg { get; set; }
        public string ExternalContactInfoId1 { get; set; }
        public string ExternalContactInfoId2 { get; set; }
        public string ResponseTrackingCd { get; set; }
    }
}
