using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiChannel
    {
        public CiChannel()
        {
            CiPackage = new HashSet<CiPackage>();
            CiResponseChannelResponse = new HashSet<CiResponseChannelResponse>();
        }

        public string ChannelCd { get; set; }
        public string ChannelNm { get; set; }
        public string ChannelDesc { get; set; }

        public virtual ICollection<CiPackage> CiPackage { get; set; }
        public virtual ICollection<CiResponseChannelResponse> CiResponseChannelResponse { get; set; }
    }
}
