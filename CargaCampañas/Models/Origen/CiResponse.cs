using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiResponse
    {
        public CiResponse()
        {
            CiResponseChannelResponse = new HashSet<CiResponseChannelResponse>();
            CiResponseXCellPackage = new HashSet<CiResponseXCellPackage>();
        }

        public decimal ResponseSk { get; set; }
        public string ResponseCd { get; set; }
        public string ResponseNm { get; set; }

        public virtual ICollection<CiResponseChannelResponse> CiResponseChannelResponse { get; set; }
        public virtual ICollection<CiResponseXCellPackage> CiResponseXCellPackage { get; set; }
    }
}
