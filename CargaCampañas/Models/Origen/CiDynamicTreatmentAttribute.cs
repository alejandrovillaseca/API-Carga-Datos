using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiDynamicTreatmentAttribute
    {
        public decimal CellPackageSk { get; set; }
        public decimal TreatmentSk { get; set; }
        public string TreatmentHashVal { get; set; }
        public string PackageHashVal { get; set; }
        public decimal? SequenceNo { get; set; }

        public virtual CiCellPackage CellPackageSkNavigation { get; set; }
        public virtual CiTreatment TreatmentSkNavigation { get; set; }
    }
}
