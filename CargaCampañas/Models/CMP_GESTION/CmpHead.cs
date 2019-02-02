using System;
using System.Collections.Generic;

namespace CargaCampañas.Models.CMP_GESTION
{
    public partial class CmpHead
    {
        public int Id { get; set; }
        public string IdCampaña { get; set; }
        public string NombreTipoCampaña { get; set; }
        public string NombreTipoProducto { get; set; }
        public string NombreFuncional { get; set; }
        public string IdWcm { get; set; }
        public string IdWcmdetalle { get; set; }
        public int? IdTipoCampaña { get; set; }
        public int? IdTipoProducto { get; set; }
        public int? IdTipoFuncional { get; set; }
        public bool Revisada { get; set; }
        public bool Imap { get; set; }
        public bool GeneradaMa { get; set; }
        public string NombreCampaña { get; set; }
        public string DueñoCmp { get; set; }
        public Guid? UsrRevisa { get; set; }
        public DateTime? FechaRevisa { get; set; }
        public Guid? UsrImap { get; set; }
        public DateTime? FechaImap { get; set; }
        public Guid? UsrGeneradaMa { get; set; }
        public DateTime? FechaGeneradaMa { get; set; }
        public int IdEstadoCampaña { get; set; }
        public Guid? UsrCreaReg { get; set; }
        public DateTime? FechaCreaReg { get; set; }
        public Guid? UsrModificaReg { get; set; }
        public DateTime? FechaModificaReg { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaCompromiso { get; set; }
        public Guid? UsrRespCrm { get; set; }
        public Guid? UsrRespMa { get; set; }
    }
}
