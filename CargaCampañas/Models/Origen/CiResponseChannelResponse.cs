using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiResponseChannelResponse
    {
        public string ResponseChannelCd { get; set; }
        public string ResponseChannelResponseCd { get; set; }
        public decimal ResponseSk { get; set; }

        public virtual CiChannel ResponseChannelCdNavigation { get; set; }
        public virtual CiResponse ResponseSkNavigation { get; set; }
    }
}
