using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiDynamicTreatmentAttrExt
    {
        public decimal TreatmentSk { get; set; }
        public string TreatmentHashVal { get; set; }

        public virtual CiTreatment TreatmentSkNavigation { get; set; }
    }
}
