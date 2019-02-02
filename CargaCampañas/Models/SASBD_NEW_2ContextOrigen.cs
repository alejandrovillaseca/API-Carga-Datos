using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CargaCampañas.Models
{
    public partial class SASBD_NEW_2ContextOrigen : DbContext
    {
        public SASBD_NEW_2ContextOrigen()
        {
        }

        public SASBD_NEW_2ContextOrigen(DbContextOptions<SASBD_NEW_2ContextOrigen> options)
            : base(options)
        {
        }

        public virtual DbSet<CmpCampaña> CmpCampaña { get; set; }
        public virtual DbSet<CmpCampañaPropension> CmpCampañaPropension { get; set; }
        public virtual DbSet<CmpCanal> CmpCanal { get; set; }
        public virtual DbSet<CmpDetalleCampaña> CmpDetalleCampaña { get; set; }
        public virtual DbSet<CmpDetalleCampañaOportunidad> CmpDetalleCampañaOportunidad { get; set; }
        public virtual DbSet<CmpDetalleCampañaOportunidadHistorico> CmpDetalleCampañaOportunidadHistorico { get; set; }
        public virtual DbSet<CmpEstadoOportunidad> CmpEstadoOportunidad { get; set; }
        public virtual DbSet<CmpEstadosOportunidadPorCanal> CmpEstadosOportunidadPorCanal { get; set; }
        public virtual DbSet<CmpFuncional> CmpFuncional { get; set; }
        public virtual DbSet<CmpHistoricoEstadoOportunidad> CmpHistoricoEstadoOportunidad { get; set; }
        public virtual DbSet<CmpOportunidad> CmpOportunidad { get; set; }
        public virtual DbSet<CmpTablaXmlprc> CmpTablaXmlprc { get; set; }
        public virtual DbSet<CmpTipoCampaña> CmpTipoCampaña { get; set; }
        public virtual DbSet<CmpTipoProducto> CmpTipoProducto { get; set; }
        public virtual DbSet<CmpValoresPersonalizados> CmpValoresPersonalizados { get; set; }
        public virtual DbSet<CmpValoresPersonalizadosDetalle> CmpValoresPersonalizadosDetalle { get; set; }
        public virtual DbSet<CmpValoresPersonalizadosDetalleMigrado> CmpValoresPersonalizadosDetalleMigrado { get; set; }
        public virtual DbSet<CockPitHistoricoEstadoOportunidad> CockPitHistoricoEstadoOportunidad { get; set; }
        public virtual DbSet<CommContactosPrc> CommContactosPrc { get; set; }
        public virtual DbSet<EtlRutCargaCampaña> EtlRutCargaCampaña { get; set; }
        public virtual DbSet<HCommContactosAgenda> HCommContactosAgenda { get; set; }
        public virtual DbSet<ParCamposMigrados> ParCamposMigrados { get; set; }
        public virtual DbSet<PriCrmMo> PriCrmMo { get; set; }
        public virtual DbSet<PriMoCrm> PriMoCrm { get; set; }
        public virtual DbSet<TmpOfertaCampanaPiv2Nose> TmpOfertaCampanaPiv2Nose { get; set; }

        // Unable to generate entity type for table 'dbo.tmpOK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_trans'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_CierreCruzado'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_ValoresPersonalizadosDetalleMigrado_201090103'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_ValoresPersonalizadosDetalle_201090103'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Par_CamposMigrados_20190103'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_Campaña_201090103'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Par_EstructuraFija'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=CLSTGPORTD05;Database=SASBD_NEW_2;Trusted_Connection=False; user id=desa;password=desa");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<CmpCampaña>(entity =>
            {
                entity.HasKey(e => e.IdCampaña);

                entity.ToTable("Cmp_Campaña");

                entity.Property(e => e.IdCampaña)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaCreacionCampaña)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreCampaña)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFuncionalNavigation)
                    .WithMany(p => p.CmpCampaña)
                    .HasForeignKey(d => d.IdFuncional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_Campaña_Cmp_Funcional");

                entity.HasOne(d => d.IdTipoCampañaNavigation)
                    .WithMany(p => p.CmpCampaña)
                    .HasForeignKey(d => d.IdTipoCampaña)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_Campaña_Cmp_TipoCampaña");

                entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.CmpCampaña)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_Campaña_Cmp_TipoProducto");
            });

            modelBuilder.Entity<CmpCampañaPropension>(entity =>
            {
                entity.ToTable("CMP_CampañaPropension");

                entity.HasIndex(e => new { e.NroOrden, e.Rut })
                    .HasName("UQ_CMP_Propension2")
                    .IsUnique();

                entity.HasIndex(e => new { e.TipoProducto, e.TipoFuncional, e.Rut })
                    .HasName("UQ_CMP_Propension3")
                    .IsUnique();

                entity.HasIndex(e => new { e.TipoProducto, e.TipoFuncional, e.NroOrden, e.Rut })
                    .HasName("UQ_CMP_Propension")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rut).HasColumnType("numeric(11, 0)");

                entity.Property(e => e.RutDv)
                    .IsRequired()
                    .HasColumnName("RutDV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFuncional)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpCanal>(entity =>
            {
                entity.HasKey(e => e.IdCanal)
                    .HasName("PK_Canal");

                entity.ToTable("Cmp_Canal");

                entity.Property(e => e.IdCanal).ValueGeneratedNever();

                entity.Property(e => e.DescCanal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCanal)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpDetalleCampaña>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCampaña);

                entity.ToTable("Cmp_DetalleCampaña");

                entity.HasIndex(e => e.FechaFin)
                    .HasName("IDX_Cmp_Cmp_DetalleCampaña_FechaFin");

                entity.HasIndex(e => e.FechaInicio)
                    .HasName("IDX_Cmp_Cmp_DetalleCampaña_FechaInicio");

                entity.HasIndex(e => new { e.FechaInicio, e.FechaFin })
                    .HasName("IDX_Cmp_Cmp_DetalleCampaña_Fechas");

                entity.Property(e => e.DescripcionCampaña)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacionRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.IdCampaña)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTrackCd)
                    .HasColumnName("ResponseTrackCD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCampañaNavigation)
                    .WithMany(p => p.CmpDetalleCampaña)
                    .HasForeignKey(d => d.IdCampaña)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_DetalleCampaña_Cmp_Campaña");

                entity.HasOne(d => d.IdCanalNavigation)
                    .WithMany(p => p.CmpDetalleCampaña)
                    .HasForeignKey(d => d.IdCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_DetalleCampaña_Cmp_Canal");
            });

            modelBuilder.Entity<CmpDetalleCampañaOportunidad>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCampañaOportunidad)
                    .HasName("pk_Cmp_DetalleCampañaOportunidad");

                entity.ToTable("Cmp_DetalleCampañaOportunidad");

                entity.Property(e => e.Glosa)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdCampaña)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCampañaNavigation)
                    .WithMany(p => p.CmpDetalleCampañaOportunidad)
                    .HasForeignKey(d => d.IdCampaña)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_DetalleCampañaOportunidad_Cmp_Campaña");

                entity.HasOne(d => d.IdDetalleCampañaNavigation)
                    .WithMany(p => p.CmpDetalleCampañaOportunidad)
                    .HasForeignKey(d => d.IdDetalleCampaña)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_DetalleCampañaOportunidad_Cmp_DetalleCampaña");

                entity.HasOne(d => d.IdOportunidadNavigation)
                    .WithMany(p => p.CmpDetalleCampañaOportunidad)
                    .HasForeignKey(d => d.IdOportunidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_DetalleCampañaOportunidad_Cmp_Oportunidad");
            });

            modelBuilder.Entity<CmpDetalleCampañaOportunidadHistorico>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCampañaOportunidadHistorico)
                    .HasName("PK_DetalleCampañaOportunidadHistorico");

                entity.ToTable("Cmp_DetalleCampañaOportunidadHistorico");

                entity.Property(e => e.FechaCambio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Glosa)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdDetalleCampañaOportunidadNavigation)
                    .WithMany(p => p.CmpDetalleCampañaOportunidadHistorico)
                    .HasForeignKey(d => d.IdDetalleCampañaOportunidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_DetalleCampañaOportunidadHistorico_Cmp_DetalleCampañaOportunidad");
            });

            modelBuilder.Entity<CmpEstadoOportunidad>(entity =>
            {
                entity.HasKey(e => e.IdEstadoOportunidad);

                entity.ToTable("Cmp_EstadoOportunidad");

                entity.Property(e => e.IdEstadoOportunidad).ValueGeneratedNever();

                entity.Property(e => e.CodCanalExterno)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DatoExterno01)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescEstOportunidad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEstOportunidad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpEstadosOportunidadPorCanal>(entity =>
            {
                entity.HasKey(e => new { e.IdEstadoOportunidad, e.IdCanal });

                entity.ToTable("Cmp_EstadosOportunidadPorCanal");

                entity.HasOne(d => d.IdCanalNavigation)
                    .WithMany(p => p.CmpEstadosOportunidadPorCanal)
                    .HasForeignKey(d => d.IdCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_EstadosOportunidadPorCanal_Cmp_Canal");

                entity.HasOne(d => d.IdEstadoOportunidadNavigation)
                    .WithMany(p => p.CmpEstadosOportunidadPorCanal)
                    .HasForeignKey(d => d.IdEstadoOportunidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_EstadosOportunidadPorCanal_Cmp_EstadoOportunidad");
            });

            modelBuilder.Entity<CmpFuncional>(entity =>
            {
                entity.HasKey(e => e.IdFuncional)
                    .HasName("pk_Cmp_Funcional");

                entity.ToTable("Cmp_Funcional");

                entity.Property(e => e.DescFuncional)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFuncional)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpHistoricoEstadoOportunidad>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoEstadoOportunidad);

                entity.ToTable("Cmp_HistoricoEstadoOportunidad");

                entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdEjecutivoGestion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdOportunidadNavigation)
                    .WithMany(p => p.CmpHistoricoEstadoOportunidad)
                    .HasForeignKey(d => d.IdOportunidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_HistoricoEstadoOportunidad_Cmp_Oportunidad");
            });

            modelBuilder.Entity<CmpOportunidad>(entity =>
            {
                entity.HasKey(e => e.IdOportunidad);

                entity.ToTable("Cmp_Oportunidad");

                entity.HasIndex(e => e.RutEmpresa)
                    .HasName("IDX_Cmp_Oportunidad_RutEmpresa");

                entity.HasIndex(e => e.RutPersona)
                    .HasName("IDX_Cmp_Oportunidad_RutPersona");

                entity.Property(e => e.IdOportunidad).ValueGeneratedNever();

                entity.Property(e => e.ApellidoPersona)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DvEmpresa)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DvPersona)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");

                entity.Property(e => e.IdClienteAltamira)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdEjecutivoGestion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdWcm)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEjecutivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePersona)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSucursal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoOportunidadNavigation)
                    .WithMany(p => p.CmpOportunidad)
                    .HasForeignKey(d => d.IdEstadoOportunidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_Oportunidad_Cmp_EstadoOportunidad");
            });

            modelBuilder.Entity<CmpTablaXmlprc>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.IdOportunidad })
                    .HasName("PK_tblTablaXMLprc");

                entity.ToTable("Cmp_TablaXMLprc");

                entity.Property(e => e.Rut).HasColumnName("RUT");

                entity.Property(e => e.IdOportunidad).HasColumnName("ID_OPORTUNIDAD");

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodcomCodigoDeSegComp1).HasColumnName("CODCOM_CODIGO_DE_SEG_COMP1");

                entity.Property(e => e.CodscoCodigoDeSegComp2)
                    .HasColumnName("CODSCO_CODIGO_DE_SEG_COMP2")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Fechaingreso)
                    .HasColumnName("FECHAINGRESO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NomcomNombreDeSegComp1)
                    .HasColumnName("NOMCOM_NOMBRE_DE_SEG_COMP1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomscoNombreDeSegComp2)
                    .HasColumnName("NOMSCO_NOMBRE_DE_SEG_COMP2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSolicitud).HasColumnName("NUMERO_SOLICITUD");

                entity.Property(e => e.PeriodoGracia).HasColumnName("PERIODO_GRACIA");

                entity.Property(e => e.RqcimpArregloCuotasExim)
                    .HasColumnName("RQCIMP_ARREGLO_CUOTAS_EXIM")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.RqetriExcensionTribut)
                    .HasColumnName("RQETRI_EXCENSION_TRIBUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RqfrepFrecuenciaDePago)
                    .HasColumnName("RQFREP_FRECUENCIA_DE_PAGO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RqicomIndSegComplem)
                    .HasColumnName("RQICOM_IND_SEG_COMPLEM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RqidesIndSegDesgrav)
                    .HasColumnName("RQIDES_IND_SEG_DESGRAV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RqiimpIndImpuesto)
                    .HasColumnName("RQIIMP_IND_IMPUESTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RqindiIndCotizaciones).HasColumnName("RQINDI_IND_COTIZACIONES");

                entity.Property(e => e.RqinotIndNotario)
                    .HasColumnName("RQINOT_IND_NOTARIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RqmcreMontoCredito)
                    .HasColumnName("RQMCRE_MONTO_CREDITO")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.RqmodcModalidadCalculo).HasColumnName("RQMODC_MODALIDAD_CALCULO");

                entity.Property(e => e.RqmoneCodigoMoneda)
                    .HasColumnName("RQMONE_CODIGO_MONEDA")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RqnaseNumeroAsegurados).HasColumnName("RQNASE_NUMERO_ASEGURADOS");

                entity.Property(e => e.RqplazPlazoCredito).HasColumnName("RQPLAZ_PLAZO_CREDITO");

                entity.Property(e => e.RqsucnSucursalNotario).HasColumnName("RQSUCN_SUCURSAL_NOTARIO");

                entity.Property(e => e.RqtasaTasaInteres)
                    .HasColumnName("RQTASA_TASA_INTERES")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.RqtcomTasaSegCompl1)
                    .HasColumnName("RQTCOM_TASA_SEG_COMPL_1")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.RqtipcTipoCredito)
                    .HasColumnName("RQTIPC_TIPO_CREDITO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RqtscoTasaSegCompl2)
                    .HasColumnName("RQTSCO_TASA_SEG_COMPL_2")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.RutDv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipCampana).HasColumnName("TIP_CAMPANA");

                entity.Property(e => e.TipProducto)
                    .HasColumnName("TIP_PRODUCTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipodefuncional)
                    .HasColumnName("TIPODEFUNCIONAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpTipoCampaña>(entity =>
            {
                entity.HasKey(e => e.IdTipoCampaña);

                entity.ToTable("Cmp_TipoCampaña");

                entity.Property(e => e.DescTipCampaña)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipCampaña)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpTipoProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProducto);

                entity.ToTable("Cmp_TipoProducto");

                entity.Property(e => e.DescTipoProducto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipoProducto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpValoresPersonalizados>(entity =>
            {
                entity.HasKey(e => e.IdValoresPersonalizados);

                entity.ToTable("Cmp_ValoresPersonalizados");

                entity.Property(e => e.Llave)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LlaveCp)
                    .HasColumnName("LlaveCP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LlaveCv)
                    .HasColumnName("LlaveCV")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdDetalleCampañaOportunidadNavigation)
                    .WithMany(p => p.CmpValoresPersonalizados)
                    .HasForeignKey(d => d.IdDetalleCampañaOportunidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_ValoresPersonalizados_Cmp_DetalleCampañaOportunidad");
            });

            modelBuilder.Entity<CmpValoresPersonalizadosDetalle>(entity =>
            {
                entity.ToTable("Cmp_ValoresPersonalizadosDetalle");

                entity.HasIndex(e => new { e.IdTipoCampaña, e.IdTipoProducto, e.IdFuncional, e.Nombre, e.Alias })
                    .HasName("UQ_Cmp_Cmp_TipoCampañaDetalle_IdTipoCampaña_Nombre")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comm)
                    .HasColumnName("COMM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCockpit)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMigrado)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpValoresPersonalizadosDetalleMigrado>(entity =>
            {
                entity.HasKey(e => e.IdVpdmigrado)
                    .HasName("pk_Cmp_ValoresPersonalizadoDetallesMigrado");

                entity.ToTable("Cmp_ValoresPersonalizadosDetalleMigrado");

                entity.Property(e => e.IdVpdmigrado).HasColumnName("IdVPDMigrado");

                entity.Property(e => e.IdCampaña)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCampañaNavigation)
                    .WithMany(p => p.CmpValoresPersonalizadosDetalleMigrado)
                    .HasForeignKey(d => d.IdCampaña)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_ValoresPersonalizadosDetalleMigrado_Cmp_Campaña");

                entity.HasOne(d => d.IdCamposMigradosNavigation)
                    .WithMany(p => p.CmpValoresPersonalizadosDetalleMigrado)
                    .HasForeignKey(d => d.IdCamposMigrados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_ValoresPersonalizadosDetalleMigrado_Par_CamposMigrados");

                entity.HasOne(d => d.IdValoresPersonalizadoDetalleNavigation)
                    .WithMany(p => p.CmpValoresPersonalizadosDetalleMigrado)
                    .HasForeignKey(d => d.IdValoresPersonalizadoDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cmp_ValoresPersonalizadosDetalleMigrado_Cmp_ValoresPersonalizadosDetalle");
            });

            modelBuilder.Entity<CockPitHistoricoEstadoOportunidad>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoCp)
                    .HasName("PK_Cmp_CPHistoricoEstadoOportunidad");

                entity.ToTable("CockPit_HistoricoEstadoOportunidad");

                entity.Property(e => e.IdHistoricoCp).HasColumnName("IdHistoricoCP");

                entity.Property(e => e.DvPersona)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdEjecutivoGestion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommContactosPrc>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.IdCampana });

                entity.ToTable("COMM_CONTACTOS_PRC");

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

                entity.Property(e => e.Fechaingreso)
                    .HasColumnName("FECHAINGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechaprocesamiento)
                    .HasColumnName("FECHAPROCESAMIENTO")
                    .HasColumnType("datetime");

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

                entity.Property(e => e.Procesado).HasColumnName("PROCESADO");

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

                entity.Property(e => e.XmlNegociacion)
                    .HasColumnName("XML_NEGOCIACION")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
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

                entity.Property(e => e.IdCampana)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HCommContactosAgenda>(entity =>
            {
                entity.HasKey(e => new { e.FechaIngreso, e.Rut, e.TextoVariable1 });

                entity.ToTable("H_COMM_CONTACTOS_AGENDA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("date");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.TextoVariable1)
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

                entity.Property(e => e.IdCampana)
                    .IsRequired()
                    .HasColumnName("ID_CAMPANA")
                    .HasMaxLength(20)
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

            modelBuilder.Entity<ParCamposMigrados>(entity =>
            {
                entity.HasKey(e => e.IdCamposMigrados)
                    .HasName("pk_Par_CamposMigrados");

                entity.ToTable("Par_CamposMigrados");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PriCrmMo>(entity =>
            {
                entity.ToTable("Pri_CrmMo");

                entity.Property(e => e.Dv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin)
                    .HasColumnName("Fecha_Fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("Fecha_Ini")
                    .HasColumnType("date");

                entity.Property(e => e.IdCampaña)
                    .IsRequired()
                    .HasColumnName("Id_Campaña")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdCmpEjec)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCampañas).HasColumnName("Tipo_Campañas");

                entity.Property(e => e.TipoFuncional).HasColumnName("Tipo_Funcional");

                entity.Property(e => e.TipoProducto).HasColumnName("Tipo_Producto");
            });

            modelBuilder.Entity<PriMoCrm>(entity =>
            {
                entity.ToTable("Pri_MoCrm");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("Fecha_Fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("Fecha_Ini")
                    .HasColumnType("date");

                entity.Property(e => e.IdCampaña)
                    .IsRequired()
                    .HasColumnName("Id_Campaña")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdCmpEjec)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCampaña).HasColumnName("Tipo_Campaña");

                entity.Property(e => e.TipoFuncional).HasColumnName("Tipo_Funcional");

                entity.Property(e => e.TipoProducto).HasColumnName("Tipo_Producto");
            });

            modelBuilder.Entity<TmpOfertaCampanaPiv2Nose>(entity =>
            {
                entity.HasKey(e => e.IdOfertaCampana)
                    .HasName("PK_Tmp_OfertaCampanaPIV");

                entity.ToTable("Tmp_OfertaCampanaPIV_2_NOSE");

                entity.Property(e => e.IdOfertaCampana).ValueGeneratedNever();

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
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });
        }

    }
}
