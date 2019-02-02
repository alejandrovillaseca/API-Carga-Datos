using System;
using System.Collections.Generic;

namespace CargaCampañas.Models
{
    public partial class CmpCampañaPropension
    {
        public int Id { get; set; }
        public string TipoProducto { get; set; }
        public int NroOrden { get; set; }
        public decimal Rut { get; set; }
        public string RutDv { get; set; }
        public string TipoFuncional { get; set; }
    }
}
