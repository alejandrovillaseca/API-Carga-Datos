using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CargaCampañas.Models.Motor_SAS_V2
{
    public partial class MOTOR_SAS_V2Context : DbContext
    {
        public MOTOR_SAS_V2Context()
        {
        }

        public MOTOR_SAS_V2Context(DbContextOptions<MOTOR_SAS_V2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CommContactos> CommContactos { get; set; }
        public virtual DbSet<CommContactosAgenda> CommContactosAgenda { get; set; }
        public virtual DbSet<CommNovedadesRutMulticanal> CommNovedadesRutMulticanal { get; set; }
        public virtual DbSet<EtlRutCargaCampaña> EtlRutCargaCampaña { get; set; }
        public virtual DbSet<MtrEjecuciones> MtrEjecuciones { get; set; }
        public virtual DbSet<SasClienteCampana> SasClienteCampana { get; set; }
        public virtual DbSet<SasEjecucionCampana> SasEjecucionCampana { get; set; }
        public virtual DbSet<SasOfertaCampana> SasOfertaCampana { get; set; }

        // Unable to generate entity type for table 'dbo.Previa_LGCConsumo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_LGCConsumo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Previa_LGCTarjetaCredito'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_LGCTarjetaCredito'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_GenericaGatillo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Previa_LGCLineaCredito'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pj_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hCOMM_CONTACTOS_2017'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_PRC_P'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_LGCLineaCredito'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hCOMM_CONTACTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_PRC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Hcomm_contactos_11_12_2018'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_HCOMM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MTR_RegEjecucionCampana'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_GenericaProductoInfoClientes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Previa_PJFirma'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Previa_PJPreAprobados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Previa_PJMVP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_PJFirma'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_PJPreAprobados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_PJMVP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Previa_PJ_ProductoBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MTR_LlaveEjecucionCampana'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_PJ_ProductoBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MTR_SolicitudProceso'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Previa_PJ_ForzadaFO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_PJ_ForzadaFO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_FlujoFrio'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_Campaña'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Paso_StockTC_Usa2daTarjeta'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_CRM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_Forzada_Rene'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_ParteFija'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<CommContactos>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.IdCampana });

                entity.ToTable("COMM_CONTACTOS");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.IdCampana)
                    .HasColumnName("ID_CAMPANA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcCierreMobile)
                    .HasColumnName("AC_CIERRE_MOBILE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AcCierreWeb)
                    .HasColumnName("AC_CIERRE_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Canales)
                    .HasColumnName("CANALES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DigitoRut)
                    .HasColumnName("DIGITO_RUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivo)
                    .HasColumnName("EJECUTIVO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstiloWeb)
                    .HasColumnName("ESTILO_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FecfinAgenda)
                    .HasColumnName("FECFIN_AGENDA")
                    .HasColumnType("date");

                entity.Property(e => e.FecfinMobile)
                    .HasColumnName("FECFIN_MOBILE")
                    .HasColumnType("date");

                entity.Property(e => e.FecfinWeb)
                    .HasColumnName("FECFIN_WEB")
                    .HasColumnType("date");

                entity.Property(e => e.FeciniAgenda)
                    .HasColumnName("FECINI_AGENDA")
                    .HasColumnType("date");

                entity.Property(e => e.FeciniMobile)
                    .HasColumnName("FECINI_MOBILE")
                    .HasColumnType("date");

                entity.Property(e => e.FeciniWeb)
                    .HasColumnName("FECINI_WEB")
                    .HasColumnType("date");

                entity.Property(e => e.FinFlujo)
                    .HasColumnName("FIN_FLUJO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.IdCampanaCrm)
                    .HasColumnName("idCampanaCRM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdWcmWeb)
                    .HasColumnName("ID_WCM_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMobile)
                    .HasColumnName("LINK_MOBILE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LinkWeb)
                    .HasColumnName("LINK_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MonAprobado)
                    .HasColumnName("MON_APROBADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrecampana)
                    .HasColumnName("NOMBRECAMPANA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notificacion)
                    .HasColumnName("NOTIFICACION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo1)
                    .HasColumnName("OFERTA_CUPO_1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo2)
                    .HasColumnName("OFERTA_CUPO_2")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo3)
                    .HasColumnName("OFERTA_CUPO_3")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo4)
                    .HasColumnName("OFERTA_CUPO_4")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo5)
                    .HasColumnName("OFERTA_CUPO_5")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTrackingCd)
                    .HasColumnName("RESPONSE_TRACKING_CD")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Texto1Mobile)
                    .HasColumnName("TEXTO1_MOBILE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Texto1Web)
                    .HasColumnName("TEXTO1_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Texto2Mobile)
                    .HasColumnName("TEXTO2_MOBILE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Texto2Web)
                    .HasColumnName("TEXTO2_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TextoVariable1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TextoVariable2)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TextoVariable3)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TextoVariable4)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TipCampana).HasColumnName("TIP_CAMPANA");

                entity.Property(e => e.TipProducto)
                    .HasColumnName("TIP_PRODUCTO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tipodefuncional)
                    .HasColumnName("TIPODEFUNCIONAL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommContactosAgenda>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.TextoVariable1 });

                entity.ToTable("COMM_CONTACTOS_AGENDA");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.TextoVariable1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.AcCierreMobile)
                    .HasColumnName("AC_CIERRE_MOBILE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AcCierreWeb)
                    .HasColumnName("AC_CIERRE_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Canales)
                    .HasColumnName("CANALES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DigitoRut)
                    .HasColumnName("DIGITO_RUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivo)
                    .HasColumnName("EJECUTIVO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstiloWeb)
                    .HasColumnName("ESTILO_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FecfinAgenda)
                    .HasColumnName("FECFIN_AGENDA")
                    .HasColumnType("date");

                entity.Property(e => e.FecfinMobile)
                    .HasColumnName("FECFIN_MOBILE")
                    .HasColumnType("date");

                entity.Property(e => e.FecfinWeb)
                    .HasColumnName("FECFIN_WEB")
                    .HasColumnType("date");

                entity.Property(e => e.FeciniAgenda)
                    .HasColumnName("FECINI_AGENDA")
                    .HasColumnType("date");

                entity.Property(e => e.FeciniMobile)
                    .HasColumnName("FECINI_MOBILE")
                    .HasColumnType("date");

                entity.Property(e => e.FeciniWeb)
                    .HasColumnName("FECINI_WEB")
                    .HasColumnType("date");

                entity.Property(e => e.FinFlujo)
                    .HasColumnName("FIN_FLUJO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.IdCampana)
                    .IsRequired()
                    .HasColumnName("ID_CAMPANA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCampanaCrm)
                    .HasColumnName("idCampanaCRM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdWcmWeb)
                    .HasColumnName("ID_WCM_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMobile)
                    .HasColumnName("LINK_MOBILE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LinkWeb)
                    .HasColumnName("LINK_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MonAprobado)
                    .HasColumnName("MON_APROBADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrecampana)
                    .HasColumnName("NOMBRECAMPANA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notificacion)
                    .HasColumnName("NOTIFICACION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo1)
                    .HasColumnName("OFERTA_CUPO_1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo2)
                    .HasColumnName("OFERTA_CUPO_2")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo3)
                    .HasColumnName("OFERTA_CUPO_3")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo4)
                    .HasColumnName("OFERTA_CUPO_4")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OfertaCupo5)
                    .HasColumnName("OFERTA_CUPO_5")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTrackingCd)
                    .HasColumnName("RESPONSE_TRACKING_CD")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Texto1Mobile)
                    .HasColumnName("TEXTO1_MOBILE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Texto1Web)
                    .HasColumnName("TEXTO1_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Texto2Mobile)
                    .HasColumnName("TEXTO2_MOBILE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Texto2Web)
                    .HasColumnName("TEXTO2_WEB")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TextoVariable2)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TextoVariable3)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TextoVariable4)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TipCampana).HasColumnName("TIP_CAMPANA");

                entity.Property(e => e.TipProducto)
                    .HasColumnName("TIP_PRODUCTO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tipodefuncional)
                    .HasColumnName("TIPODEFUNCIONAL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommNovedadesRutMulticanal>(entity =>
            {
                entity.ToTable("COMM_NOVEDADES_RUT_MULTICANAL");

                entity.HasIndex(e => e.Rut)
                    .HasName("COMM_NOVEDADES_RUT_MULTICANAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fechacarga)
                    .HasColumnName("FECHACARGA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Glosa)
                    .HasColumnName("GLOSA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCanal).HasColumnName("ID_CANAL");

                entity.Property(e => e.Idcampaña)
                    .HasColumnName("IDCAMPAÑA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idcmpejec).HasColumnName("IDCMPEJEC");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.Vigente)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EtlRutCargaCampaña>(entity =>
            {
                entity.HasKey(e => new { e.IdOportunidad, e.IdCmpEjec })
                    .HasName("PK_Cmp_RutCargaCampaña");

                entity.ToTable("Etl_RutCargaCampaña");

                entity.Property(e => e.IdCmpEjec)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionError).IsUnicode(false);

                entity.Property(e => e.Error).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCampana)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StrXml)
                    .HasColumnName("StrXML")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtrEjecuciones>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.IdCamp, e.Codcampana, e.IdOportunidad });

                entity.ToTable("MTR_Ejecuciones");

                entity.HasIndex(e => e.Codcampana)
                    .HasName("IND_MTREjecuciones02");

                entity.HasIndex(e => e.IdCamp)
                    .HasName("IND_MTREjecuciones01");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IdCamp).HasColumnName("ID_CAMP");

                entity.Property(e => e.Codcampana)
                    .HasColumnName("CODCAMPANA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdOportunidad).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SasClienteCampana>(entity =>
            {
                entity.HasKey(e => e.IdOportunidad);

                entity.ToTable("SAS_ClienteCampana");

                entity.Property(e => e.IdOportunidad).ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionError).IsUnicode(false);

                entity.Property(e => e.DvCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DvEmpresa)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProcesamiento).HasColumnType("datetime");

                entity.Property(e => e.IdCmpEjec)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdWcm)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEjecutivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSucursal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SasEjecucionCampana>(entity =>
            {
                entity.HasKey(e => e.IdCmpEjec);

                entity.ToTable("SAS_EjecucionCampana");

                entity.Property(e => e.IdCmpEjec)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescripcionCampana)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.IdCampana)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoCampana)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoFuncional)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoProducto)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCampana)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SasOfertaCampana>(entity =>
            {
                entity.HasKey(e => e.IdOfertaCampana);

                entity.ToTable("SAS_OfertaCampana");

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Canal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCmpEjec)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTrackCd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=CLSTGPORTD05;Initial Catalog=MOTOR_SAS_V2;persist security info=True;user id=desa;password=desa");
            }
        }

    }

    
}
