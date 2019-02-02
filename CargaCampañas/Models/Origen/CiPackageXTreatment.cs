using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiPackageXTreatment
    {
        public decimal PackageSk { get; set; }
        public string PackageHashVal { get; set; }
        public decimal TreatmentSk { get; set; }
        public decimal ContributingCellPackageSk { get; set; }
        public decimal SequenceNo { get; set; }

        public virtual CiCellPackage ContributingCellPackageSkNavigation { get; set; }
        public virtual CiPackage PackageSkNavigation { get; set; }
        public virtual CiTreatment TreatmentSkNavigation { get; set; }
    }
}
