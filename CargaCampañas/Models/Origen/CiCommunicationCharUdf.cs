﻿using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.Origen
{
    public partial class CiCommunicationCharUdf
    {
        public decimal CommunicationSk { get; set; }
        public string CharUdfNm { get; set; }
        public string CharUdfVal { get; set; }
        public string CharExtColumnNm { get; set; }
        public DateTime? ProcessedDttm { get; set; }

        public virtual CiCommunication CommunicationSkNavigation { get; set; }
    }
}
