using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiMoOptimizationScenario
    {
        public CiMoOptimizationScenario()
        {
            CiCampGrpXMoOptScenario = new HashSet<CiCampGrpXMoOptScenario>();
        }

        public decimal MoOptScenarioSk { get; set; }
        public decimal? MoOptScenarioVersionNo { get; set; }
        public string MoOptScenarioNm { get; set; }
        public string MoOptScenarioDesc { get; set; }
        public DateTime? MoOptScenarioRunDttm { get; set; }
        public string MoOptScenarioOwnerNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual ICollection<CiCampGrpXMoOptScenario> CiCampGrpXMoOptScenario { get; set; }
    }
}
