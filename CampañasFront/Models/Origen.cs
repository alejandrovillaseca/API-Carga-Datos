using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampañasFront.Models
{
    public class Origen : Header
    {
        public string RutSinDV { get; set; }
        public string DV { get; set; }
        public string IdCampaña { get; set; }
    }
}
