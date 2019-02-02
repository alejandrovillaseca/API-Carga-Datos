using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiPackage
    {
        public CiPackage()
        {
            CiCellPackage = new HashSet<CiCellPackage>();
            CiPackageXTreatment = new HashSet<CiPackageXTreatment>();
        }

        public decimal PackageSk { get; set; }
        public string PackageCd { get; set; }
        public string ChannelCd { get; set; }

        public virtual CiChannel ChannelCdNavigation { get; set; }
        public virtual ICollection<CiCellPackage> CiCellPackage { get; set; }
        public virtual ICollection<CiPackageXTreatment> CiPackageXTreatment { get; set; }
    }
}
