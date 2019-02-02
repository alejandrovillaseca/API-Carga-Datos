using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using CargaCampañas.Models.SASBD_NEW_2;
using CargaCampañas.Models;
using CargaCampañas.Models.Motor_SAS_V2;
using CargaCampañas.Models.Origen;
using System.Globalization;
using CargaCampañas.Models.CMP_GESTION;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CargaCampañas.Controllers
{
    [Route("api/[controller]")]
    public class OrigenController : Controller
    {
        private readonly SAS_CampaignContext _context;
        private readonly MOTOR_SAS_V2Context _contextMotorSAS;
        private readonly SASBD_NEW_2Context _contextSASDB;
        private readonly CMP_GESTIONContext _contextCPM;

        public OrigenController(SAS_CampaignContext context, MOTOR_SAS_V2Context contextMotorSAS, SASBD_NEW_2Context contextSASDB, CMP_GESTIONContext contextCPM)
        {
            _context = context;
            _contextMotorSAS = contextMotorSAS;
            _contextSASDB = contextSASDB;
            _contextCPM = contextCPM;
        }

        // POST api/<controller>
        [HttpPost]
        public Models.Response.OrigenResponse ObtenerOrigen(decimal RutSinDV, string DV, string IdCampaña)
        {
            try
            {
                using (var dbContext = new MOTOR_SAS_V2Context())
                {
                    if (IdCampaña.Count() > 5)
                        throw new Exception("El IdCampaña es mayor a 5 caracteres (" + IdCampaña + ")");

                    //Primero obtengo la info de la campaña
                    var _info = ObtenerInfoCampaña(IdCampaña);
                    if (_info == null)
                        throw new Exception("No existe info de la campaña");
                    int TIP_CAMPANA = _info.IdTipoCampaña;
                    string TIP_PRODUCTO = _info.NombreTipoProducto;
                    string TipodeFuncional = _info.NombreFuncional;
                    string ID_WCM_WEB = _info.IdWCM;

                    new DestinoController(dbContext, _contextSASDB).EliminaData();

                    var _response = new Models.Response.OrigenResponse();
                    #region Query
                    _context.Database.SetCommandTimeout(240);
                    var _result = _context.hCOMM_CONTACTOSQuery.FromSql(@"SELECT TOP (10) *
                                                                    FROM [dbo].[hCOMM_CONTACTOS] nolock
                                                                    WHERE TIP_CAMPANA = " + TIP_CAMPANA.ToString() + @"
                                                                    AND TIP_PRODUCTO = '" + TIP_PRODUCTO + @"'
                                                                    AND TipodeFuncional = '" + TipodeFuncional + @"'
                                                                    AND ID_WCM_WEB = '" + ID_WCM_WEB + @"'
                                                                    ORDER BY FECINI_WEB DESC
                                                                    ").ToList().LastOrDefault();
                    #endregion

                    if (_result == null)
                        throw new Exception("No se obtuvo ningun resultado --> TIP_CAMPANA: " + TIP_CAMPANA + " TIP_PRODUCTO: " + TIP_PRODUCTO + " TipodeFuncional: " + TipodeFuncional + " ID_WCM_WEB: " + ID_WCM_WEB);

                    #region Refinacion Data
                    //Se cambia el rut
                    _result.RUT = RutSinDV;
                    //El DV
                    _result.DIGITO_RUT = DV;
                    //Fechas
                    if (_result.CANALES == "1")
                    {
                        if (_result.FECFIN_WEB != null)
                        {
                            _result.FECINI_WEB = DateTime.Now;
                            _result.FECFIN_WEB = DateTime.Now.AddDays(30);
                        }
                        //Textos variables
                        if (_result.TextoVariable1 != null && _result.TextoVariable1.Length == 5)
                        {
                            _result.TextoVariable1 = _result.FECFIN_WEB.Value.ToString("yyyy-MM-dd");
                        }
                        if (_result.TextoVariable2 != null && _result.TextoVariable2.Length == 5)
                        {
                            _result.TextoVariable2 = _result.FECFIN_WEB.Value.ToString("yyyy-MM-dd");
                        }
                        if (_result.TextoVariable3 != null && _result.TextoVariable3.Length == 5)
                        {
                            _result.TextoVariable3 = _result.FECFIN_WEB.Value.ToString("yyyy-MM-dd");
                        }
                        if (_result.TextoVariable4 != null && _result.TextoVariable4.Length == 5)
                        {
                            _result.TextoVariable4 = _result.FECFIN_WEB.Value.ToString("yyyy-MM-dd");
                        }

                    }

                    if (_result.FECINI_MOBILE != null)
                    {
                        _result.FECINI_MOBILE = DateTime.Now;
                        _result.FECFIN_MOBILE = DateTime.Now.AddDays(30);
                    }
                    //TODO Canales    

                    #endregion

                    _response.Origen = _result;

                    var _obj = new Models.Motor_SAS_V2.CommContactos();

                    //Se revisa si el IdCampaña ya existe
                    var _id = dbContext.CommContactos.Where(x => x.IdCampana == _result.ID_CAMPANA).FirstOrDefault();
                    if (_id != null)
                        throw new Exception("El ID_CAMPANA " + _result.ID_CAMPANA + " ya existe");

                    _obj.Rut = _result.RUT;
                    _obj.DigitoRut = _result.DIGITO_RUT;
                    _obj.Nombre = _result.NOMBRE;
                    _obj.Apellido = _result.APELLIDO;
                    _obj.Sucursal = _result.SUCURSAL;
                    _obj.MonAprobado = _result.MON_APROBADO;
                    _obj.OfertaCupo1 = _result.OFERTA_CUPO_1;
                    _obj.OfertaCupo2 = _result.OFERTA_CUPO_2;
                    _obj.OfertaCupo3 = _result.OFERTA_CUPO_3;
                    _obj.OfertaCupo4 = _result.OFERTA_CUPO_4;
                    _obj.OfertaCupo5 = _result.OFERTA_CUPO_5;
                    _obj.Tasa = _result.TASA;
                    _obj.Ejecutivo = _result.EJECUTIVO;
                    _obj.Email = _result.EMAIL;
                    _obj.ResponseTrackingCd = _result.RESPONSE_TRACKING_CD;
                    _obj.Estado = _result.ESTADO;
                    _obj.IdCampana = _result.ID_CAMPANA;
                    _obj.TipCampana = _result.TIP_CAMPANA;
                    _obj.TipProducto = _result.TIP_PRODUCTO;
                    _obj.Notificacion = _result.NOTIFICACION;
                    _obj.Canales = _result.CANALES;
                    _obj.FeciniWeb = _result.FECINI_WEB;
                    _obj.FecfinWeb = _result.FECFIN_WEB;
                    _obj.Texto1Web = _result.TEXTO1_WEB;
                    _obj.Texto2Web = _result.TEXTO2_WEB;
                    _obj.FinFlujo = _result.FIN_FLUJO;
                    _obj.EstiloWeb = _result.ESTILO_WEB;
                    _obj.IdWcmWeb = _result.ID_WCM_WEB;
                    _obj.LinkWeb = _result.LINK_WEB;
                    _obj.AcCierreMobile = _result.AC_CIERRE_MOBILE;
                    _obj.FeciniMobile = _result.FECINI_MOBILE;
                    _obj.FecfinMobile = _result.FECFIN_MOBILE;
                    _obj.Texto1Mobile = _result.TEXTO1_MOBILE;
                    _obj.Texto2Mobile = _result.TEXTO2_MOBILE;
                    _obj.LinkMobile = _result.LINK_MOBILE;
                    _obj.AcCierreMobile = _result.AC_CIERRE_MOBILE;
                    _obj.FeciniAgenda = _result.FECINI_AGENDA;
                    _obj.FecfinAgenda = _result.FECFIN_AGENDA;
                    _obj.TextoVariable1 = _result.TextoVariable1;
                    _obj.TextoVariable2 = _result.TextoVariable2;
                    _obj.TextoVariable3 = _result.TextoVariable3;
                    _obj.TextoVariable4 = _result.TextoVariable4;
                    _obj.Nombrecampana = _result.NombreCampana;
                    _obj.Tipodefuncional = _result.TipodeFuncional;
                    _obj.IdCampanaCrm = IdCampaña;

                    dbContext.CommContactos.Add(_obj);
                    dbContext.SaveChanges();


                    //Ahora el destino
                    new DestinoController(dbContext, _contextSASDB).EjecutaSP(RutSinDV.ToString());


                    _response.Header = new Header()
                    {
                        Correcto = true,
                        FechaProceso = DateTime.Now,
                        Observación = "Proceso correcto"
                    };
                    return _response;
                }
            }
            catch (Exception ex)
            {
                var _return = new Models.Response.OrigenResponse();
                _return.Header = new Header()
                {
                    Correcto = false,
                    FechaProceso = DateTime.Now,
                    Observación = ex.Message
                };
                return _return;

            }
            finally
            {

            }
        }
        [HttpPost("obtenerinfo")]
        public Models.CMP_GESTION.InfoCampañas ObtenerInfoCampaña(string IdCampaña)
        {
            var _info = _contextCPM.InfoCamp.FromSql(@"SELECT TOP (1) IdTipoCampaña, B.NombreTipoProducto, C.NombreFuncional,IdWCM
                                                      FROM [CMP_GESTION].[dbo].[Cmp_HEAD] A
                                                      INNER JOIN [CMP_GESTION].[dbo].[Cmp_TipoProducto] B
	                                                    ON A.IdTipoProducto = B.IdTipoProducto
                                                      INNER JOIN [CMP_GESTION].[dbo].[Cmp_TipoFuncional] C
	                                                    ON A.IdTipoFuncional = C.IdTipoFuncional
                                                      where A.IdCampaña = 'BANEL'
                                                      and A.Revisada = 1
                                                      and A.Imap = 1
                                                      and A.GeneradaMA = 1
                                                      and A.DueñoCMP = 'PJ'").ToList().FirstOrDefault();
            return _info;
        }

        [HttpPost("porlotes")]
        public Header PorLotes()
        {
            try
            {
                using (var dbContext = new SASBD_NEW_2Context())
                {
                    var _registros = dbContext.TpmCargaData.Where(x => x.Procesado != true).ToList();
                    foreach (var item in _registros)
                    {
                        try
                        {
                            item.RutConDv = item.RutConDv.Replace("\r\n", string.Empty);
                            item.IdCampaña = item.IdCampaña.Replace("\r\n", string.Empty);
                            item.RutConDv = item.RutConDv.Replace("\t", string.Empty);
                            item.IdCampaña = item.IdCampaña.Replace("\t", string.Empty);
                            item.RutConDv = item.RutConDv.Trim();
                            item.IdCampaña = item.IdCampaña.Trim();


                            decimal RutSinDV = Convert.ToDecimal(item.RutConDv.Substring(0, item.RutConDv.Length - 1));
                            string DV = item.RutConDv.Substring(item.RutConDv.Length - 1, 1);
                            string IdCampaña = item.IdCampaña;
                            var _result = ObtenerOrigen(RutSinDV, DV, IdCampaña);
                            if (_result.Header.Correcto)
                            {
                                item.Observación = "Correcto";
                                item.Procesado = true;
                                item.FechaProceso = DateTime.Now;
                            }
                            else
                            {
                                item.Observación = _result.Header.Observación;
                                item.Procesado = false;
                                item.FechaProceso = DateTime.Now;
                            }
                            dbContext.TpmCargaData.Update(item);
                            dbContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }

                    }
                    return new Header()
                    {
                        FechaProceso = DateTime.Now,
                        Correcto = true,
                        Observación = "Se procesaron " + _registros.Count() + " registros"
                    };
                }
            }
            catch (Exception ex)
            {
                return new Header()
                {
                    FechaProceso = DateTime.Now,
                    Correcto = false,
                    Observación = ex.Message
                };

            }

        }
    }
}
