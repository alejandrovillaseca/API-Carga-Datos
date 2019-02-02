using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCommunicationNumUdf
    {
        public decimal CommunicationSk { get; set; }
        public string NumUdfNm { get; set; }
        public decimal? NumUdfVal { get; set; }
        public string NumExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCommunication CommunicationSkNavigation { get; set; }
    }
}
