using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class CmpFuncional
    {
        public CmpFuncional()
        {
            CmpCampaña = new HashSet<CmpCampaña>();
        }

        public int IdFuncional { get; set; }
        public string NombreFuncional { get; set; }
        public string DescFuncional { get; set; }

        public virtual ICollection<CmpCampaña> CmpCampaña { get; set; }
    }
}
