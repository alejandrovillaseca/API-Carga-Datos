using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiControlGroupType
    {
        public CiControlGroupType()
        {
            CiCellPackage = new HashSet<CiCellPackage>();
            CiMarketingCell = new HashSet<CiMarketingCell>();
        }

        public string ControlGroupTypeCd { get; set; }
        public string ControlGroupTypeDesc { get; set; }

        public virtual ICollection<CiCellPackage> CiCellPackage { get; set; }
        public virtual ICollection<CiMarketingCell> CiMarketingCell { get; set; }
    }
}
