using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiResponseType
    {
        public CiResponseType()
        {
            CiResponseXCellPackage = new HashSet<CiResponseXCellPackage>();
        }

        public string ResponseTypeCd { get; set; }
        public string ResponseTypeDesc { get; set; }

        public virtual ICollection<CiResponseXCellPackage> CiResponseXCellPackage { get; set; }
    }
}
