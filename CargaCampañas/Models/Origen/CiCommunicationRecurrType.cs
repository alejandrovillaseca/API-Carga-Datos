using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCommunicationRecurrType
    {
        public CiCommunicationRecurrType()
        {
            CiCommunication = new HashSet<CiCommunication>();
        }

        public string CommunicationRecurrTypeCd { get; set; }
        public string CommunicationRecurrTypeDesc { get; set; }

        public virtual ICollection<CiCommunication> CiCommunication { get; set; }
    }
}
