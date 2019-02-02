using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCommunicationDateUdf
    {
        public decimal CommunicationSk { get; set; }
        public string DateUdfNm { get; set; }
        public DateTime? DateUdfVal { get; set; }
        public string DateExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCommunication CommunicationSkNavigation { get; set; }
    }
}
