using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiChangeType
    {
        public CiChangeType()
        {
            CiChangeLog = new HashSet<CiChangeLog>();
        }

        public string ChangeTypeCd { get; set; }
        public string ChangeTypeDesc { get; set; }

        public virtual ICollection<CiChangeLog> CiChangeLog { get; set; }
    }
}
