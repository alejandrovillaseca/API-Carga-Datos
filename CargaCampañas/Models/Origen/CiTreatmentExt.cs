using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiTreatmentExt
    {
        public decimal TreatmentSk { get; set; }

        public virtual CiTreatment TreatmentSkNavigation { get; set; }
    }
}
