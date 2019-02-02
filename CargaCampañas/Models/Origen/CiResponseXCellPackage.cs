using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiResponseXCellPackage
    {
        public decimal ResponseSk { get; set; }
        public decimal CellPackageSk { get; set; }
        public string ResponseTypeCd { get; set; }
        public decimal? EstimatedResponseRt { get; set; }

        public virtual CiCellPackage CellPackageSkNavigation { get; set; }
        public virtual CiResponse ResponseSkNavigation { get; set; }
        public virtual CiResponseType ResponseTypeCdNavigation { get; set; }
    }
}
