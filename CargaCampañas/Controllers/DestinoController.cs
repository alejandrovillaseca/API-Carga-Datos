using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargaCampañas.Models;
using CargaCampañas.Models.Motor_SAS_V2;
using CargaCampañas.Models.SASBD_NEW_2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CargaCampañas.Controllers
{
    [Route("api/[controller]")]
    public class DestinoController : Controller
    {
        private readonly MOTOR_SAS_V2Context _context;
        private readonly SASBD_NEW_2Context _contextSAS;
        

        public DestinoController(MOTOR_SAS_V2Context context, SASBD_NEW_2Context contextSAS)
        {
            _context = context;
            _contextSAS = contextSAS;
        }
        [HttpPost]
        public Header InsertaDataCommContactos(Models.Origen.hCOMM_CONTACTOS _data, string IdCampaña)
        {
            try
            {
                var _obj = new Models.Motor_SAS_V2.CommContactos();

                //Se revisa si el IdCampaña ya existe
                var _id =_context.CommContactos.Where(x => x.IdCampana == IdCampaña).FirstOrDefault();
                if (_id != null)
                    throw new Exception("El ID_CAMPANA " + IdCampaña + " ya existe");

                _obj.Rut = _data.RUT;
                _obj.DigitoRut = _data.DIGITO_RUT;
                _obj.Nombre = _data.NOMBRE;
                _obj.Apellido = _data.APELLIDO;
                _obj.Sucursal = _data.SUCURSAL;
                _obj.MonAprobado = _data.MON_APROBADO;
                _obj.OfertaCupo1 = _data.OFERTA_CUPO_1;
                _obj.OfertaCupo2 = _data.OFERTA_CUPO_2;
                _obj.OfertaCupo3 = _data.OFERTA_CUPO_3;
                _obj.OfertaCupo4 = _data.OFERTA_CUPO_4;
                _obj.OfertaCupo5 = _data.OFERTA_CUPO_5;
                _obj.Tasa = _data.TASA;
                _obj.Ejecutivo = _data.EJECUTIVO;
                _obj.Email = _data.EMAIL;
                _obj.ResponseTrackingCd = _data.RESPONSE_TRACKING_CD;
                _obj.Estado = _data.ESTADO;
                _obj.IdCampana = _data.ID_CAMPANA;
                _obj.TipCampana = _data.TIP_CAMPANA;
                _obj.TipProducto = _data.TIP_PRODUCTO;
                _obj.Notificacion = _data.NOTIFICACION;
                _obj.Canales = _data.CANALES;
                _obj.FeciniWeb = _data.FECINI_WEB;
                _obj.FecfinWeb = _data.FECFIN_WEB;
                _obj.Texto1Web = _data.TEXTO1_WEB;
                _obj.Texto2Web = _data.TEXTO2_WEB;
                _obj.FinFlujo = _data.FIN_FLUJO;
                _obj.EstiloWeb = _data.ESTILO_WEB;
                _obj.IdWcmWeb = _data.ID_WCM_WEB;
                _obj.LinkWeb = _data.LINK_WEB;
                _obj.AcCierreMobile = _data.AC_CIERRE_MOBILE;
                _obj.FeciniMobile = _data.FECINI_MOBILE;
                _obj.FecfinMobile = _data.FECFIN_MOBILE;
                _obj.Texto1Mobile = _data.TEXTO1_MOBILE;
                _obj.Texto2Mobile = _data.TEXTO2_MOBILE;
                _obj.LinkMobile = _data.LINK_MOBILE;
                _obj.AcCierreMobile = _data.AC_CIERRE_MOBILE;
                _obj.FeciniAgenda = _data.FECINI_AGENDA;
                _obj.FecfinAgenda = _data.FECFIN_AGENDA;
                _obj.TextoVariable1 = _data.TextoVariable1;
                _obj.TextoVariable2 = _data.TextoVariable2;
                _obj.TextoVariable3 = _data.TextoVariable3;
                _obj.TextoVariable4 = _data.TextoVariable4;
                _obj.Nombrecampana = _data.NombreCampana;
                _obj.Tipodefuncional = _data.TipodeFuncional;
                _obj.IdCampanaCrm = IdCampaña;

                _context.CommContactos.Add(_obj);
                _context.SaveChanges();

                return new Header()
                {
                    Correcto = true,
                    FechaProceso = DateTime.Now,
                    Observación = "Inserción correcta"
                };
            }
            catch (Exception ex)
            {
                return new Header()
                {
                    Correcto = false,
                    Observación = ex.Message,
                    FechaProceso = DateTime.Now
                };
            }
        }


        [HttpPost("remove")]
        public void EliminaData()
        {
            _context.Database.ExecuteSqlCommand("delete from COMM_CONTACTOS");
            _context.Database.ExecuteSqlCommand("delete from COMM_CONTACTOS_PRC");
            _context.Database.ExecuteSqlCommand("delete from COMM_CONTACTOS_AGENDA");
            
        }

        [HttpPost("executeSP")]
        public Header EjecutaSP(string Rut)
        {
            try
            {
                
                _context.Database.OpenConnection();
                var cmd = _context.Database.GetDbConnection().CreateCommand();
                //Primero
                cmd.CommandText = "dbo.SP_CargaManualCampana__CommToSas";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var result = reader.GetString(0);
                        if (result != "0")
                            throw new Exception("Error en SP_CargaManualCampana__CommToSas: " + reader.GetString(1));

                    }
                }
                //Segundo
                cmd.CommandText = "exec [dbo].[SP_CargaManualCampana__SasToEjec] 0";
                cmd.CommandType = System.Data.CommandType.Text;
                var reader2 = cmd.ExecuteReader();
                reader2.NextResult();
                reader2.NextResult();
                reader2.NextResult();
                while (reader2.Read())
                {
                    var result = reader2.GetString(0);
                    if (result != "0")
                        throw new Exception("Error en SP_CargaManualCampana__SasToEjec: " + reader2.GetString(1));

                }
                reader2.Close();

                //Tercero
                cmd.CommandText = "update SAS_ClienteCampana set Procesado = 1";
                cmd.CommandType = System.Data.CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var result = reader.GetString(0);
                        if (result != "0")
                            throw new Exception("Error en SAS_ClienteCampana: " + reader.GetString(1));

                    }
                }
                //Cuarto
                cmd.CommandText = "EXEC [dbo].[SP_CargaManualCampana__SasToEjec] 1";
                cmd.CommandType = System.Data.CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var result = reader.GetString(0);
                        if (result != "0")
                            throw new Exception("Error en SP_CargaManualCampana__SasToEjec: " + reader.GetString(1));

                    }
                }
                //Quinto
                //_contextSAS.CmpOportunidad.FromSql(@"update o set
                //                                      o.NombrePersona	= 'NomItaú' 
                //                                     ,o.ApellidoPersona	= 'ApeItaú' 
                //                                     ,o.EmailContacto	= 'Cliente@dominio.cl' 
                //                                     ,o.TelefonoContacto	= '987654321' 
                //                                     ,o.NombreSucursal	= 'La Reina'
                //                                     ,o.NombreEjecutivo	= 'Ejecutivos Itaú'
                //                                    from Cmp_Oportunidad o
                //                                    where
                //                                     o.NombrePersona <> 'NomItaú'").ToList().FirstOrDefault();
                _contextSAS.Database.OpenConnection();
                cmd = _contextSAS.Database.GetDbConnection().CreateCommand();
                cmd.CommandText = @"update o set
                                        o.NombrePersona = 'NomItaú'
                                        ,o.ApellidoPersona = 'ApeItaú'
                                        ,o.EmailContacto = 'Cliente@dominio.cl'
                                        ,o.TelefonoContacto = '987654321'
                                        ,o.NombreSucursal = 'La Reina'
                                        ,o.NombreEjecutivo = 'Ejecutivos Itaú'
                                    from Cmp_Oportunidad o
                                    where
                                        o.NombrePersona <> 'NomItaú'";
                cmd.CommandType = System.Data.CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {
                    
                }
                //Sexto JOB ETL
                
                cmd.CommandText = "USE msdb EXEC dbo.sp_start_job N'JOB_SSIS_CargaSasMulticanal_OLD'";
                cmd.CommandType = System.Data.CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {

                }

                _context.Database.CloseConnection();
                _contextSAS.Database.CloseConnection();

                var _comp = Comprobacion(Rut);
                if (!_comp.Correcto)
                    throw new Exception(_comp.Observación);

                var _obj = new Header();
                _obj.Correcto = true;
                _obj.FechaProceso = DateTime.Now;
                _obj.Observación = "Proceso correcto";
                return _obj;
            }
            catch (Exception ex)
            {
                return new Header()
                {
                    Correcto = false,
                    FechaProceso = DateTime.Now,
                    Observación = ex.Message
                };
            }
        }

        [HttpPost("comprobacion")]
        public Header Comprobacion(string Rut)
        {
            try
            {
                _contextSAS.Database.OpenConnection();
                var cmd = _contextSAS.Database.GetDbConnection().CreateCommand();
                
                cmd.CommandText = "exec SP_ListarCampanasSAS "+Rut+",1";
                cmd.CommandType = System.Data.CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {
                    reader.NextResult();
                    while (reader.Read())
                    {
                        if(!reader.HasRows)
                            throw new Exception("No existen datos, revisar");
                    }
                }
                _contextSAS.Database.CloseConnection();
                return new Header()
                {
                    Correcto = true,
                    FechaProceso = DateTime.Now,
                    Observación = "OK"
                };
            }
            catch (Exception ex)
            {
                return new Header()
                {
                    Observación = ex.Message,
                    FechaProceso = DateTime.Now,
                    Correcto = true
                };
            }
        }
    }
}
