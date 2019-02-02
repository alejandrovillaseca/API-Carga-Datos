using CargaCampañas.Models.Origen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargaCampañas.Models.Response
{
    public class OrigenResponse
    {
        public Header Header { get; set; }
        public hCOMM_CONTACTOS Origen { get; set; }
    }
}
