using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCommunicationStatus
    {
        public CiCommunicationStatus()
        {
            CiCommunication = new HashSet<CiCommunication>();
        }

        public string CommunicationStatusCd { get; set; }
        public string CommunicationStatusDesc { get; set; }

        public virtual ICollection<CiCommunication> CiCommunication { get; set; }
    }
}
