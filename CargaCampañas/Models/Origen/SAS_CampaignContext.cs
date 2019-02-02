using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CargaCampañas.Models.Origen
{
    public partial class SAS_CampaignContext : DbContext
    {
        public SAS_CampaignContext()
        {
        }

        public SAS_CampaignContext(DbContextOptions<SAS_CampaignContext> options)
            : base(options)
        {
            
        }

        public virtual DbQuery<hCOMM_CONTACTOS> hCOMM_CONTACTOSQuery { get; set; }
        public virtual DbSet<CiCampGrpPage> CiCampGrpPage { get; set; }
        public virtual DbSet<CiCampGrpPageCharUdf> CiCampGrpPageCharUdf { get; set; }
        public virtual DbSet<CiCampGrpPageDateUdf> CiCampGrpPageDateUdf { get; set; }
        public virtual DbSet<CiCampGrpPageNumUdf> CiCampGrpPageNumUdf { get; set; }
        public virtual DbSet<CiCampGrpXMoOptScenario> CiCampGrpXMoOptScenario { get; set; }
        public virtual DbSet<CiCampPage> CiCampPage { get; set; }
        public virtual DbSet<CiCampPageCharUdf> CiCampPageCharUdf { get; set; }
        public virtual DbSet<CiCampPageDateUdf> CiCampPageDateUdf { get; set; }
        public virtual DbSet<CiCampPageNumUdf> CiCampPageNumUdf { get; set; }
        public virtual DbSet<CiCampaign> CiCampaign { get; set; }
        public virtual DbSet<CiCampaignExt> CiCampaignExt { get; set; }
        public virtual DbSet<CiCampaignGroup> CiCampaignGroup { get; set; }
        public virtual DbSet<CiCampaignGroupExt> CiCampaignGroupExt { get; set; }
        public virtual DbSet<CiCampaignGroupStatus> CiCampaignGroupStatus { get; set; }
        public virtual DbSet<CiCampaignGroupType> CiCampaignGroupType { get; set; }
        public virtual DbSet<CiCampaignStatus> CiCampaignStatus { get; set; }
        public virtual DbSet<CiCampaignType> CiCampaignType { get; set; }
        public virtual DbSet<CiCellPackage> CiCellPackage { get; set; }
        public virtual DbSet<CiChangeLog> CiChangeLog { get; set; }
        public virtual DbSet<CiChangeType> CiChangeType { get; set; }
        public virtual DbSet<CiChannel> CiChannel { get; set; }
        public virtual DbSet<CiCommunication> CiCommunication { get; set; }
        public virtual DbSet<CiCommunicationCharUdf> CiCommunicationCharUdf { get; set; }
        public virtual DbSet<CiCommunicationDateUdf> CiCommunicationDateUdf { get; set; }
        public virtual DbSet<CiCommunicationExt> CiCommunicationExt { get; set; }
        public virtual DbSet<CiCommunicationNumUdf> CiCommunicationNumUdf { get; set; }
        public virtual DbSet<CiCommunicationRecurrType> CiCommunicationRecurrType { get; set; }
        public virtual DbSet<CiCommunicationStatus> CiCommunicationStatus { get; set; }
        public virtual DbSet<CiContactHistory> CiContactHistory { get; set; }
        public virtual DbSet<CiContactHistoryStatus> CiContactHistoryStatus { get; set; }
        public virtual DbSet<CiControlGroupType> CiControlGroupType { get; set; }
        public virtual DbSet<CiCtlGrpCellXTestCell> CiCtlGrpCellXTestCell { get; set; }
        public virtual DbSet<CiDynamicTreatmentAttrExt> CiDynamicTreatmentAttrExt { get; set; }
        public virtual DbSet<CiDynamicTreatmentAttribute> CiDynamicTreatmentAttribute { get; set; }
        public virtual DbSet<CiMarketingCell> CiMarketingCell { get; set; }
        public virtual DbSet<CiMoOptimizationScenario> CiMoOptimizationScenario { get; set; }
        public virtual DbSet<CiPackage> CiPackage { get; set; }
        public virtual DbSet<CiPackageXTreatment> CiPackageXTreatment { get; set; }
        public virtual DbSet<CiPresentedTreatmentHistory> CiPresentedTreatmentHistory { get; set; }
        public virtual DbSet<CiResponse> CiResponse { get; set; }
        public virtual DbSet<CiResponseChannelResponse> CiResponseChannelResponse { get; set; }
        public virtual DbSet<CiResponseHistory> CiResponseHistory { get; set; }
        public virtual DbSet<CiResponseType> CiResponseType { get; set; }
        public virtual DbSet<CiResponseXCellPackage> CiResponseXCellPackage { get; set; }
        public virtual DbSet<CiTreatCampSetStatus> CiTreatCampSetStatus { get; set; }
        public virtual DbSet<CiTreatCampSetXCampaign> CiTreatCampSetXCampaign { get; set; }
        public virtual DbSet<CiTreatment> CiTreatment { get; set; }
        public virtual DbSet<CiTreatmentCampaignSet> CiTreatmentCampaignSet { get; set; }
        public virtual DbSet<CiTreatmentCharUdf> CiTreatmentCharUdf { get; set; }
        public virtual DbSet<CiTreatmentDateUdf> CiTreatmentDateUdf { get; set; }
        public virtual DbSet<CiTreatmentExt> CiTreatmentExt { get; set; }
        public virtual DbSet<CiTreatmentNumUdf> CiTreatmentNumUdf { get; set; }
        public virtual DbSet<CmpCampañaPropension> CmpCampañaPropension { get; set; }
        public virtual DbSet<CommCampos> CommCampos { get; set; }
        public virtual DbSet<CommContactos> CommContactos { get; set; }
        public virtual DbSet<CommContactosClau> CommContactosClau { get; set; }
        public virtual DbSet<CommContactosMulticanal> CommContactosMulticanal { get; set; }
        public virtual DbSet<CommContactosMulticanalPrevia> CommContactosMulticanalPrevia { get; set; }
        public virtual DbSet<CommContactosPrc> CommContactosPrc { get; set; }
        public virtual DbSet<CommContactosPrima> CommContactosPrima { get; set; }
        public virtual DbSet<CommNegociacion> CommNegociacion { get; set; }
        public virtual DbSet<CommNovedadesCampaña> CommNovedadesCampaña { get; set; }
        public virtual DbSet<CommNovedadesCampañaMulticanal> CommNovedadesCampañaMulticanal { get; set; }
        public virtual DbSet<CommNovedadesRut> CommNovedadesRut { get; set; }
        public virtual DbSet<CommNovedadesRut2> CommNovedadesRut2 { get; set; }
        public virtual DbSet<CommNovedadesRutMulticanal> CommNovedadesRutMulticanal { get; set; }
        public virtual DbSet<PriCrmMo> PriCrmMo { get; set; }

        // Unable to generate entity type for table 'dbo.borrar_camp_is'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hCOMM_CONTACTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CorrComSinRep_FF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tabla_test_v2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.teste_process'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.res_comm_contactos_20ene'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_Canales'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_ivan'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_PRC_AUX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.H_COMM_CONTACTOS_PRC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_NOVEDADES_OFERTA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_COMM_CONTACTOS_MARC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_RESPUESTAS_HISTORY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MG_COMM_CONTACTOS_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUX_ID_CAMP_MORA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_SEGS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUX_ID_CAMP_RENE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CAMPAIGN_TREATMENT_DATA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_RESPUESTAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUX_IDEJECMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tMP_CRM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUX_ID_CAMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CI_INTABLE10_CPK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_BORRAR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_CONTACTOS_CG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tLGC_Blacklist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_NOVEDADES_RUT_AUX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_Tablon_B_Errores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Test_CAMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RUTERO_SOW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_RESPUESTAS_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hCOMM_CONTACTOS2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_NEGOCIACION_MUESTRA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CI_CHANNEL_RESP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hCOMM_RESPUESTAS'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=CLSTGSQLP20V1;Database=SAS_Campaign;Trusted_Connection=False; user id=BIDataReader;password=1234567890");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<CiCampGrpPage>(entity =>
            {
                entity.HasKey(e => new { e.CampaignGroupSk, e.PageNm })
                    .HasName("CAMP_GRP_PAGE_PK");

                entity.ToTable("CI_CAMP_GRP_PAGE");

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PageStatusFlg)
                    .HasColumnName("PAGE_STATUS_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CampaignGroupSkNavigation)
                    .WithMany(p => p.CiCampGrpPage)
                    .HasForeignKey(d => d.CampaignGroupSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CAMP_GRP_PAGE_FK1");
            });

            modelBuilder.Entity<CiCampGrpPageCharUdf>(entity =>
            {
                entity.HasKey(e => new { e.CampaignGroupSk, e.PageNm, e.CharUdfNm })
                    .HasName("CG_PG_CH_UDF_PK");

                entity.ToTable("CI_CAMP_GRP_PAGE_CHAR_UDF");

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CharUdfNm)
                    .HasColumnName("CHAR_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CharExtColumnNm)
                    .HasColumnName("CHAR_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CharUdfVal)
                    .HasColumnName("CHAR_UDF_VAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CiCampGrpPage)
                    .WithMany(p => p.CiCampGrpPageCharUdf)
                    .HasForeignKey(d => new { d.CampaignGroupSk, d.PageNm })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CG_PG_CH_UDF_FK1");
            });

            modelBuilder.Entity<CiCampGrpPageDateUdf>(entity =>
            {
                entity.HasKey(e => new { e.CampaignGroupSk, e.PageNm, e.DateUdfNm })
                    .HasName("CG_PG_DT_UDF_PK");

                entity.ToTable("CI_CAMP_GRP_PAGE_DATE_UDF");

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DateUdfNm)
                    .HasColumnName("DATE_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DateExtColumnNm)
                    .HasColumnName("DATE_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateUdfVal)
                    .HasColumnName("DATE_UDF_VAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CiCampGrpPage)
                    .WithMany(p => p.CiCampGrpPageDateUdf)
                    .HasForeignKey(d => new { d.CampaignGroupSk, d.PageNm })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CG_PG_DT_UDF_FK1");
            });

            modelBuilder.Entity<CiCampGrpPageNumUdf>(entity =>
            {
                entity.HasKey(e => new { e.CampaignGroupSk, e.PageNm, e.NumUdfNm })
                    .HasName("CG_PG_NM_UDF_PK");

                entity.ToTable("CI_CAMP_GRP_PAGE_NUM_UDF");

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumUdfNm)
                    .HasColumnName("NUM_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumExtColumnNm)
                    .HasColumnName("NUM_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumUdfVal)
                    .HasColumnName("NUM_UDF_VAL")
                    .HasColumnType("numeric(17, 2)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CiCampGrpPage)
                    .WithMany(p => p.CiCampGrpPageNumUdf)
                    .HasForeignKey(d => new { d.CampaignGroupSk, d.PageNm })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CG_PG_NM_UDF_FK1");
            });

            modelBuilder.Entity<CiCampGrpXMoOptScenario>(entity =>
            {
                entity.HasKey(e => new { e.CampaignGroupSk, e.MoOptScenarioSk })
                    .HasName("CG_X_MO_OPT_PK");

                entity.ToTable("CI_CAMP_GRP_X_MO_OPT_SCENARIO");

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MoOptScenarioSk)
                    .HasColumnName("MO_OPT_SCENARIO_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.CampaignGroupSkNavigation)
                    .WithMany(p => p.CiCampGrpXMoOptScenario)
                    .HasForeignKey(d => d.CampaignGroupSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CG_X_MO_OPT_FK1");

                entity.HasOne(d => d.MoOptScenarioSkNavigation)
                    .WithMany(p => p.CiCampGrpXMoOptScenario)
                    .HasForeignKey(d => d.MoOptScenarioSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CG_X_MO_OPT_FK2");
            });

            modelBuilder.Entity<CiCampPage>(entity =>
            {
                entity.HasKey(e => new { e.CampaignSk, e.PageNm })
                    .HasName("CAMP_PAGE_PK");

                entity.ToTable("CI_CAMP_PAGE");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PageStatusFlg)
                    .HasColumnName("PAGE_STATUS_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CampaignSkNavigation)
                    .WithMany(p => p.CiCampPage)
                    .HasForeignKey(d => d.CampaignSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CAMP_PAGE_FK1");
            });

            modelBuilder.Entity<CiCampPageCharUdf>(entity =>
            {
                entity.HasKey(e => new { e.CampaignSk, e.PageNm, e.CharUdfNm })
                    .HasName("CP_CH_UDF_PK");

                entity.ToTable("CI_CAMP_PAGE_CHAR_UDF");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CharUdfNm)
                    .HasColumnName("CHAR_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CharExtColumnNm)
                    .HasColumnName("CHAR_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CharUdfVal)
                    .HasColumnName("CHAR_UDF_VAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CiCampPage)
                    .WithMany(p => p.CiCampPageCharUdf)
                    .HasForeignKey(d => new { d.CampaignSk, d.PageNm })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CP_CH_UDF_FK1");
            });

            modelBuilder.Entity<CiCampPageDateUdf>(entity =>
            {
                entity.HasKey(e => new { e.CampaignSk, e.PageNm, e.DateUdfNm })
                    .HasName("CP_DT_UDF_PK");

                entity.ToTable("CI_CAMP_PAGE_DATE_UDF");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DateUdfNm)
                    .HasColumnName("DATE_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DateExtColumnNm)
                    .HasColumnName("DATE_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateUdfVal)
                    .HasColumnName("DATE_UDF_VAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CiCampPage)
                    .WithMany(p => p.CiCampPageDateUdf)
                    .HasForeignKey(d => new { d.CampaignSk, d.PageNm })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CP_DT_UDF_FK1");
            });

            modelBuilder.Entity<CiCampPageNumUdf>(entity =>
            {
                entity.HasKey(e => new { e.CampaignSk, e.PageNm, e.NumUdfNm })
                    .HasName("CP_NM_UDF_PK");

                entity.ToTable("CI_CAMP_PAGE_NUM_UDF");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PageNm)
                    .HasColumnName("PAGE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumUdfNm)
                    .HasColumnName("NUM_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumExtColumnNm)
                    .HasColumnName("NUM_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumUdfVal)
                    .HasColumnName("NUM_UDF_VAL")
                    .HasColumnType("numeric(17, 2)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CiCampPage)
                    .WithMany(p => p.CiCampPageNumUdf)
                    .HasForeignKey(d => new { d.CampaignSk, d.PageNm })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CP_NM_UDF_FK1");
            });

            modelBuilder.Entity<CiCampaign>(entity =>
            {
                entity.HasKey(e => e.CampaignSk)
                    .HasName("CAMP_PK");

                entity.ToTable("CI_CAMPAIGN");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ApprovalDttm)
                    .HasColumnName("APPROVAL_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovalGivenByNm)
                    .HasColumnName("APPROVAL_GIVEN_BY_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessContextNm)
                    .HasColumnName("BUSINESS_CONTEXT_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignCd)
                    .HasColumnName("CAMPAIGN_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignDesc)
                    .HasColumnName("CAMPAIGN_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignFolderTxt)
                    .HasColumnName("CAMPAIGN_FOLDER_TXT")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CampaignNm)
                    .HasColumnName("CAMPAIGN_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignOwnerNm)
                    .HasColumnName("CAMPAIGN_OWNER_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignStatusCd)
                    .HasColumnName("CAMPAIGN_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignTypeCd)
                    .HasColumnName("CAMPAIGN_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignVersionNo)
                    .HasColumnName("CAMPAIGN_VERSION_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CurrentVersionFlg)
                    .HasColumnName("CURRENT_VERSION_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedFlg)
                    .HasColumnName("DELETED_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeploymentVersionNo)
                    .HasColumnName("DEPLOYMENT_VERSION_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.EndDttm)
                    .HasColumnName("END_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserNm)
                    .HasColumnName("LAST_MODIFIED_BY_USER_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDttm)
                    .HasColumnName("LAST_MODIFIED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxBudgetAmt)
                    .HasColumnName("MAX_BUDGET_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MaxBudgetOfferAmt)
                    .HasColumnName("MAX_BUDGET_OFFER_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MinBudgetAmt)
                    .HasColumnName("MIN_BUDGET_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MinBudgetOfferAmt)
                    .HasColumnName("MIN_BUDGET_OFFER_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.RunDttm)
                    .HasColumnName("RUN_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDttm)
                    .HasColumnName("START_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CampaignGroupSkNavigation)
                    .WithMany(p => p.CiCampaign)
                    .HasForeignKey(d => d.CampaignGroupSk)
                    .HasConstraintName("CAMP_FK3");

                entity.HasOne(d => d.CampaignStatusCdNavigation)
                    .WithMany(p => p.CiCampaign)
                    .HasForeignKey(d => d.CampaignStatusCd)
                    .HasConstraintName("CAMP_FK1");

                entity.HasOne(d => d.CampaignTypeCdNavigation)
                    .WithMany(p => p.CiCampaign)
                    .HasForeignKey(d => d.CampaignTypeCd)
                    .HasConstraintName("CAMP_FK2");
            });

            modelBuilder.Entity<CiCampaignExt>(entity =>
            {
                entity.HasKey(e => e.CampaignSk)
                    .HasName("CAMP_EXT_PK");

                entity.ToTable("CI_CAMPAIGN_EXT");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DescCampana)
                    .HasColumnName("DESC_CAMPANA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCampana)
                    .HasColumnName("ID_CAMPANA")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Notificacion)
                    .HasColumnName("NOTIFICACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipCampana)
                    .IsRequired()
                    .HasColumnName("TIP_CAMPANA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipProducto)
                    .HasColumnName("TIP_PRODUCTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CampaignSkNavigation)
                    .WithOne(p => p.CiCampaignExt)
                    .HasForeignKey<CiCampaignExt>(d => d.CampaignSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CAMP_EXT_FK1");
            });

            modelBuilder.Entity<CiCampaignGroup>(entity =>
            {
                entity.HasKey(e => e.CampaignGroupSk)
                    .HasName("CAMP_GRP_PK");

                entity.ToTable("CI_CAMPAIGN_GROUP");

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CampaignGroupCd)
                    .HasColumnName("CAMPAIGN_GROUP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGroupDesc)
                    .HasColumnName("CAMPAIGN_GROUP_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGroupFolderTxt)
                    .HasColumnName("CAMPAIGN_GROUP_FOLDER_TXT")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGroupNm)
                    .HasColumnName("CAMPAIGN_GROUP_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGroupStatusCd)
                    .HasColumnName("CAMPAIGN_GROUP_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGroupTypeCd)
                    .HasColumnName("CAMPAIGN_GROUP_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGroupVersionNo)
                    .HasColumnName("CAMPAIGN_GROUP_VERSION_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.DeletedFlg)
                    .HasColumnName("DELETED_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedByUserNm)
                    .HasColumnName("LAST_MODIFIED_BY_USER_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDttm)
                    .HasColumnName("LAST_MODIFIED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxBudgetAmt)
                    .HasColumnName("MAX_BUDGET_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MaxBudgetOfferAmt)
                    .HasColumnName("MAX_BUDGET_OFFER_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MinBudgetAmt)
                    .HasColumnName("MIN_BUDGET_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MinBudgetOfferAmt)
                    .HasColumnName("MIN_BUDGET_OFFER_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CampaignGroupStatusCdNavigation)
                    .WithMany(p => p.CiCampaignGroup)
                    .HasForeignKey(d => d.CampaignGroupStatusCd)
                    .HasConstraintName("CAMP_GRP_FK2");

                entity.HasOne(d => d.CampaignGroupTypeCdNavigation)
                    .WithMany(p => p.CiCampaignGroup)
                    .HasForeignKey(d => d.CampaignGroupTypeCd)
                    .HasConstraintName("CAMP_GRP_FK1");
            });

            modelBuilder.Entity<CiCampaignGroupExt>(entity =>
            {
                entity.HasKey(e => e.CampaignGroupSk)
                    .HasName("CG_EXT_PK");

                entity.ToTable("CI_CAMPAIGN_GROUP_EXT");

                entity.Property(e => e.CampaignGroupSk)
                    .HasColumnName("CAMPAIGN_GROUP_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.CampaignGroupSkNavigation)
                    .WithOne(p => p.CiCampaignGroupExt)
                    .HasForeignKey<CiCampaignGroupExt>(d => d.CampaignGroupSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CG_EXT_FK1");
            });

            modelBuilder.Entity<CiCampaignGroupStatus>(entity =>
            {
                entity.HasKey(e => e.CampaignGroupStatusCd)
                    .HasName("CAMP_GRP_STATUS_PK");

                entity.ToTable("CI_CAMPAIGN_GROUP_STATUS");

                entity.Property(e => e.CampaignGroupStatusCd)
                    .HasColumnName("CAMPAIGN_GROUP_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignGroupStatusDesc)
                    .HasColumnName("CAMPAIGN_GROUP_STATUS_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCampaignGroupType>(entity =>
            {
                entity.HasKey(e => e.CampaignGroupTypeCd)
                    .HasName("CAMP_GRP_TYPE_PK");

                entity.ToTable("CI_CAMPAIGN_GROUP_TYPE");

                entity.Property(e => e.CampaignGroupTypeCd)
                    .HasColumnName("CAMPAIGN_GROUP_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignGroupTypeDesc)
                    .HasColumnName("CAMPAIGN_GROUP_TYPE_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCampaignStatus>(entity =>
            {
                entity.HasKey(e => e.CampaignStatusCd)
                    .HasName("CAMP_STATUS_PK");

                entity.ToTable("CI_CAMPAIGN_STATUS");

                entity.Property(e => e.CampaignStatusCd)
                    .HasColumnName("CAMPAIGN_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignStatusDesc)
                    .HasColumnName("CAMPAIGN_STATUS_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCampaignType>(entity =>
            {
                entity.HasKey(e => e.CampaignTypeCd)
                    .HasName("CAMP_TYPE_PK");

                entity.ToTable("CI_CAMPAIGN_TYPE");

                entity.Property(e => e.CampaignTypeCd)
                    .HasColumnName("CAMPAIGN_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignTypeDesc)
                    .HasColumnName("CAMPAIGN_TYPE_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCellPackage>(entity =>
            {
                entity.HasKey(e => e.CellPackageSk)
                    .HasName("CELL_PKG_PK");

                entity.ToTable("CI_CELL_PACKAGE");

                entity.Property(e => e.CellPackageSk)
                    .HasColumnName("CELL_PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CampaignCd)
                    .HasColumnName("CAMPAIGN_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNm)
                    .HasColumnName("CAMPAIGN_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ChannelCd)
                    .HasColumnName("CHANNEL_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationCd)
                    .HasColumnName("COMMUNICATION_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationNm)
                    .HasColumnName("COMMUNICATION_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationOccurrenceNo)
                    .HasColumnName("COMMUNICATION_OCCURRENCE_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CommunicationSk)
                    .HasColumnName("COMMUNICATION_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ControlGroupTypeCd)
                    .HasColumnName("CONTROL_GROUP_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedFlg)
                    .HasColumnName("DELETED_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCellCd)
                    .HasColumnName("MARKETING_CELL_CD")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCellDesc)
                    .HasColumnName("MARKETING_CELL_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCellNm)
                    .HasColumnName("MARKETING_CELL_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCellSk)
                    .HasColumnName("MARKETING_CELL_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MaxTreatmentCnt)
                    .HasColumnName("MAX_TREATMENT_CNT")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.PackageCd)
                    .HasColumnName("PACKAGE_CD")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PackageSk)
                    .HasColumnName("PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseTrackingCd)
                    .HasColumnName("RESPONSE_TRACKING_CD")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectTypeNm)
                    .HasColumnName("SUBJECT_TYPE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPreoptimizedContactCnt)
                    .HasColumnName("TOTAL_PREOPTIMIZED_CONTACT_CNT")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TrackPresentedTreatmentsFlg)
                    .HasColumnName("TRACK_PRESENTED_TREATMENTS_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CampaignSkNavigation)
                    .WithMany(p => p.CiCellPackage)
                    .HasForeignKey(d => d.CampaignSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CELL_PKG_FK2");

                entity.HasOne(d => d.CommunicationSkNavigation)
                    .WithMany(p => p.CiCellPackage)
                    .HasForeignKey(d => d.CommunicationSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CELL_PKG_FK1");

                entity.HasOne(d => d.ControlGroupTypeCdNavigation)
                    .WithMany(p => p.CiCellPackage)
                    .HasForeignKey(d => d.ControlGroupTypeCd)
                    .HasConstraintName("CELL_PKG_FK4");

                entity.HasOne(d => d.MarketingCellSkNavigation)
                    .WithMany(p => p.CiCellPackage)
                    .HasForeignKey(d => d.MarketingCellSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CELL_PKG_FK3");

                entity.HasOne(d => d.PackageSkNavigation)
                    .WithMany(p => p.CiCellPackage)
                    .HasForeignKey(d => d.PackageSk)
                    .HasConstraintName("CELL_PKG_FK5");
            });

            modelBuilder.Entity<CiChangeLog>(entity =>
            {
                entity.HasKey(e => new { e.CampaignSk, e.ChangeTypeCd, e.ChangeDttm })
                    .HasName("CHANGE_LOG_PK");

                entity.ToTable("CI_CHANGE_LOG");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ChangeTypeCd)
                    .HasColumnName("CHANGE_TYPE_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDttm)
                    .HasColumnName("CHANGE_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeTxt)
                    .HasColumnName("CHANGE_TXT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedByUserNm)
                    .HasColumnName("CHANGED_BY_USER_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.CampaignSkNavigation)
                    .WithMany(p => p.CiChangeLog)
                    .HasForeignKey(d => d.CampaignSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CHANGE_LOG_FK1");

                entity.HasOne(d => d.ChangeTypeCdNavigation)
                    .WithMany(p => p.CiChangeLog)
                    .HasForeignKey(d => d.ChangeTypeCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CHANGE_LOG_FK2");
            });

            modelBuilder.Entity<CiChangeType>(entity =>
            {
                entity.HasKey(e => e.ChangeTypeCd)
                    .HasName("CHANGE_TYPE_PK");

                entity.ToTable("CI_CHANGE_TYPE");

                entity.Property(e => e.ChangeTypeCd)
                    .HasColumnName("CHANGE_TYPE_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeTypeDesc)
                    .HasColumnName("CHANGE_TYPE_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiChannel>(entity =>
            {
                entity.HasKey(e => e.ChannelCd)
                    .HasName("CHANNEL_PK");

                entity.ToTable("CI_CHANNEL");

                entity.Property(e => e.ChannelCd)
                    .HasColumnName("CHANNEL_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ChannelDesc)
                    .HasColumnName("CHANNEL_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelNm)
                    .HasColumnName("CHANNEL_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCommunication>(entity =>
            {
                entity.HasKey(e => e.CommunicationSk)
                    .HasName("COMM_PK");

                entity.ToTable("CI_COMMUNICATION");

                entity.Property(e => e.CommunicationSk)
                    .HasColumnName("COMMUNICATION_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.BudgetUnitCostAmt)
                    .HasColumnName("BUDGET_UNIT_COST_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.BudgetUnitUsageAmt)
                    .HasColumnName("BUDGET_UNIT_USAGE_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CommunicationCd)
                    .HasColumnName("COMMUNICATION_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationDesc)
                    .HasColumnName("COMMUNICATION_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationNm)
                    .HasColumnName("COMMUNICATION_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationOccurrenceNo)
                    .HasColumnName("COMMUNICATION_OCCURRENCE_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CommunicationRecurrTypeCd)
                    .HasColumnName("COMMUNICATION_RECURR_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationStatusCd)
                    .HasColumnName("COMMUNICATION_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedFlg)
                    .HasColumnName("DELETED_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndDttm)
                    .HasColumnName("END_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExportDttm)
                    .HasColumnName("EXPORT_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxBudgetAmt)
                    .HasColumnName("MAX_BUDGET_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MaxBudgetOfferAmt)
                    .HasColumnName("MAX_BUDGET_OFFER_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MinBudgetAmt)
                    .HasColumnName("MIN_BUDGET_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.MinBudgetOfferAmt)
                    .HasColumnName("MIN_BUDGET_OFFER_AMT")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StandardReplyFlg)
                    .HasColumnName("STANDARD_REPLY_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartDttm)
                    .HasColumnName("START_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubjectTypeNm)
                    .HasColumnName("SUBJECT_TYPE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateContactHistoryFlg)
                    .HasColumnName("UPDATE_CONTACT_HISTORY_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CampaignSkNavigation)
                    .WithMany(p => p.CiCommunication)
                    .HasForeignKey(d => d.CampaignSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COMM_FK1");

                entity.HasOne(d => d.CommunicationRecurrTypeCdNavigation)
                    .WithMany(p => p.CiCommunication)
                    .HasForeignKey(d => d.CommunicationRecurrTypeCd)
                    .HasConstraintName("COMM_FK3");

                entity.HasOne(d => d.CommunicationStatusCdNavigation)
                    .WithMany(p => p.CiCommunication)
                    .HasForeignKey(d => d.CommunicationStatusCd)
                    .HasConstraintName("COMM_FK2");
            });

            modelBuilder.Entity<CiCommunicationCharUdf>(entity =>
            {
                entity.HasKey(e => new { e.CommunicationSk, e.CharUdfNm })
                    .HasName("COMM_CH_UDF_PK");

                entity.ToTable("CI_COMMUNICATION_CHAR_UDF");

                entity.Property(e => e.CommunicationSk)
                    .HasColumnName("COMMUNICATION_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CharUdfNm)
                    .HasColumnName("CHAR_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CharExtColumnNm)
                    .HasColumnName("CHAR_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CharUdfVal)
                    .HasColumnName("CHAR_UDF_VAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CommunicationSkNavigation)
                    .WithMany(p => p.CiCommunicationCharUdf)
                    .HasForeignKey(d => d.CommunicationSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COMM_CH_UDF_FK1");
            });

            modelBuilder.Entity<CiCommunicationDateUdf>(entity =>
            {
                entity.HasKey(e => new { e.CommunicationSk, e.DateUdfNm })
                    .HasName("COMM_DT_UDF_PK");

                entity.ToTable("CI_COMMUNICATION_DATE_UDF");

                entity.Property(e => e.CommunicationSk)
                    .HasColumnName("COMMUNICATION_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DateUdfNm)
                    .HasColumnName("DATE_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DateExtColumnNm)
                    .HasColumnName("DATE_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateUdfVal)
                    .HasColumnName("DATE_UDF_VAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CommunicationSkNavigation)
                    .WithMany(p => p.CiCommunicationDateUdf)
                    .HasForeignKey(d => d.CommunicationSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COMM_DT_UDF_FK1");
            });

            modelBuilder.Entity<CiCommunicationExt>(entity =>
            {
                entity.HasKey(e => e.CommunicationSk)
                    .HasName("COMM_EXT_PK");

                entity.ToTable("CI_COMMUNICATION_EXT");

                entity.Property(e => e.CommunicationSk)
                    .HasColumnName("COMMUNICATION_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.AcCierreMobile)
                    .HasColumnName("AC_CIERRE_MOBILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcCierreWeb)
                    .HasColumnName("AC_CIERRE_WEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Canales)
                    .IsRequired()
                    .HasColumnName("CANALES")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstiloWeb)
                    .HasColumnName("ESTILO_WEB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FecfinAgenda)
                    .HasColumnName("FECFIN_AGENDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecfinMobile)
                    .HasColumnName("FECFIN_MOBILE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecfinWeb)
                    .HasColumnName("FECFIN_WEB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeciniAgenda)
                    .HasColumnName("FECINI_AGENDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeciniMobile)
                    .HasColumnName("FECINI_MOBILE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeciniWeb)
                    .HasColumnName("FECINI_WEB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinFlujo)
                    .HasColumnName("FIN_FLUJO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdWcmWeb)
                    .HasColumnName("ID_WCM_WEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMobile)
                    .HasColumnName("LINK_MOBILE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkWeb)
                    .HasColumnName("LINK_WEB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCampana)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaludoEmail)
                    .HasColumnName("SALUDO_EMAIL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Texto1Mobile)
                    .HasColumnName("TEXTO1_MOBILE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Texto1Web)
                    .HasColumnName("TEXTO1_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Texto2Mobile)
                    .HasColumnName("TEXTO2_MOBILE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Texto2Web)
                    .HasColumnName("TEXTO2_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmail)
                    .HasColumnName("TIPO_EMAIL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipodeFuncional)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CommunicationSkNavigation)
                    .WithOne(p => p.CiCommunicationExt)
                    .HasForeignKey<CiCommunicationExt>(d => d.CommunicationSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COMM_EXT_FK1");
            });

            modelBuilder.Entity<CiCommunicationNumUdf>(entity =>
            {
                entity.HasKey(e => new { e.CommunicationSk, e.NumUdfNm })
                    .HasName("COMM_NM_UDF_PK");

                entity.ToTable("CI_COMMUNICATION_NUM_UDF");

                entity.Property(e => e.CommunicationSk)
                    .HasColumnName("COMMUNICATION_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumUdfNm)
                    .HasColumnName("NUM_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumExtColumnNm)
                    .HasColumnName("NUM_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumUdfVal)
                    .HasColumnName("NUM_UDF_VAL")
                    .HasColumnType("numeric(17, 2)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CommunicationSkNavigation)
                    .WithMany(p => p.CiCommunicationNumUdf)
                    .HasForeignKey(d => d.CommunicationSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COMM_NM_UDF_FK1");
            });

            modelBuilder.Entity<CiCommunicationRecurrType>(entity =>
            {
                entity.HasKey(e => e.CommunicationRecurrTypeCd)
                    .HasName("COMM_RECURR_TYPE_PK");

                entity.ToTable("CI_COMMUNICATION_RECURR_TYPE");

                entity.Property(e => e.CommunicationRecurrTypeCd)
                    .HasColumnName("COMMUNICATION_RECURR_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommunicationRecurrTypeDesc)
                    .HasColumnName("COMMUNICATION_RECURR_TYPE_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCommunicationStatus>(entity =>
            {
                entity.HasKey(e => e.CommunicationStatusCd)
                    .HasName("COMM_STATUS_PK");

                entity.ToTable("CI_COMMUNICATION_STATUS");

                entity.Property(e => e.CommunicationStatusCd)
                    .HasColumnName("COMMUNICATION_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommunicationStatusDesc)
                    .HasColumnName("COMMUNICATION_STATUS_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiContactHistory>(entity =>
            {
                entity.HasKey(e => new { e.CellPackageSk, e.Rut, e.ContactDttm })
                    .HasName("CONT_HIST_PK");

                entity.ToTable("CI_CONTACT_HISTORY");

                entity.Property(e => e.CellPackageSk)
                    .HasColumnName("CELL_PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.ContactDttm)
                    .HasColumnName("CONTACT_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactDt)
                    .HasColumnName("CONTACT_DT")
                    .HasColumnType("date");

                entity.Property(e => e.ContactHistoryStatusCd)
                    .HasColumnName("CONTACT_HISTORY_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalContactInfoId1)
                    .HasColumnName("EXTERNAL_CONTACT_INFO_ID1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalContactInfoId2)
                    .HasColumnName("EXTERNAL_CONTACT_INFO_ID2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OptimizationBackfillFlg)
                    .HasColumnName("OPTIMIZATION_BACKFILL_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PackageHashVal)
                    .HasColumnName("PACKAGE_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTrackingCd)
                    .HasColumnName("RESPONSE_TRACKING_CD")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiContactHistoryStatus>(entity =>
            {
                entity.HasKey(e => e.ContactHistoryStatusCd)
                    .HasName("CONT_HIST_STAT_PK");

                entity.ToTable("CI_CONTACT_HISTORY_STATUS");

                entity.Property(e => e.ContactHistoryStatusCd)
                    .HasColumnName("CONTACT_HISTORY_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactHistoryStatusDesc)
                    .HasColumnName("CONTACT_HISTORY_STATUS_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiControlGroupType>(entity =>
            {
                entity.HasKey(e => e.ControlGroupTypeCd)
                    .HasName("CTRL_GRP_TYPE_PK");

                entity.ToTable("CI_CONTROL_GROUP_TYPE");

                entity.Property(e => e.ControlGroupTypeCd)
                    .HasColumnName("CONTROL_GROUP_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ControlGroupTypeDesc)
                    .HasColumnName("CONTROL_GROUP_TYPE_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCtlGrpCellXTestCell>(entity =>
            {
                entity.HasKey(e => new { e.ControlGroupCellSk, e.MarketingCellSk })
                    .HasName("CGC_X_TST_CELL_PK");

                entity.ToTable("CI_CTL_GRP_CELL_X_TEST_CELL");

                entity.Property(e => e.ControlGroupCellSk)
                    .HasColumnName("CONTROL_GROUP_CELL_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MarketingCellSk)
                    .HasColumnName("MARKETING_CELL_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.ControlGroupCellSkNavigation)
                    .WithMany(p => p.CiCtlGrpCellXTestCellControlGroupCellSkNavigation)
                    .HasForeignKey(d => d.ControlGroupCellSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CGC_X_TST_CELL_FK2");

                entity.HasOne(d => d.MarketingCellSkNavigation)
                    .WithMany(p => p.CiCtlGrpCellXTestCellMarketingCellSkNavigation)
                    .HasForeignKey(d => d.MarketingCellSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CGC_X_TST_CELL_FK1");
            });

            modelBuilder.Entity<CiDynamicTreatmentAttrExt>(entity =>
            {
                entity.HasKey(e => new { e.TreatmentSk, e.TreatmentHashVal })
                    .HasName("DYN_TRT_AT_EXT_PK");

                entity.ToTable("CI_DYNAMIC_TREATMENT_ATTR_EXT");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TreatmentHashVal)
                    .HasColumnName("TREATMENT_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.TreatmentSkNavigation)
                    .WithMany(p => p.CiDynamicTreatmentAttrExt)
                    .HasForeignKey(d => d.TreatmentSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DYN_TRT_AT_EXT_FK1");
            });

            modelBuilder.Entity<CiDynamicTreatmentAttribute>(entity =>
            {
                entity.HasKey(e => new { e.CellPackageSk, e.TreatmentSk, e.TreatmentHashVal, e.PackageHashVal })
                    .HasName("DYN_TREAT_ATTR_PK");

                entity.ToTable("CI_DYNAMIC_TREATMENT_ATTRIBUTE");

                entity.Property(e => e.CellPackageSk)
                    .HasColumnName("CELL_PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TreatmentHashVal)
                    .HasColumnName("TREATMENT_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PackageHashVal)
                    .HasColumnName("PACKAGE_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.HasOne(d => d.CellPackageSkNavigation)
                    .WithMany(p => p.CiDynamicTreatmentAttribute)
                    .HasForeignKey(d => d.CellPackageSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DYN_TREAT_ATTR_FK1");

                entity.HasOne(d => d.TreatmentSkNavigation)
                    .WithMany(p => p.CiDynamicTreatmentAttribute)
                    .HasForeignKey(d => d.TreatmentSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DYN_TREAT_ATTR_FK2");
            });

            modelBuilder.Entity<CiMarketingCell>(entity =>
            {
                entity.HasKey(e => e.MarketingCellSk)
                    .HasName("MKTG_CELL_PK");

                entity.ToTable("CI_MARKETING_CELL");

                entity.Property(e => e.MarketingCellSk)
                    .HasColumnName("MARKETING_CELL_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ControlGroupTypeCd)
                    .HasColumnName("CONTROL_GROUP_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCellCd)
                    .HasColumnName("MARKETING_CELL_CD")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCellDesc)
                    .HasColumnName("MARKETING_CELL_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCellNm)
                    .HasColumnName("MARKETING_CELL_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CampaignSkNavigation)
                    .WithMany(p => p.CiMarketingCell)
                    .HasForeignKey(d => d.CampaignSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MKTG_CELL_FK1");

                entity.HasOne(d => d.ControlGroupTypeCdNavigation)
                    .WithMany(p => p.CiMarketingCell)
                    .HasForeignKey(d => d.ControlGroupTypeCd)
                    .HasConstraintName("MKTG_CELL_FK2");
            });

            modelBuilder.Entity<CiMoOptimizationScenario>(entity =>
            {
                entity.HasKey(e => e.MoOptScenarioSk)
                    .HasName("MO_OPT_SCN_PK");

                entity.ToTable("CI_MO_OPTIMIZATION_SCENARIO");

                entity.Property(e => e.MoOptScenarioSk)
                    .HasColumnName("MO_OPT_SCENARIO_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MoOptScenarioDesc)
                    .HasColumnName("MO_OPT_SCENARIO_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.MoOptScenarioNm)
                    .HasColumnName("MO_OPT_SCENARIO_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MoOptScenarioOwnerNm)
                    .HasColumnName("MO_OPT_SCENARIO_OWNER_NM")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MoOptScenarioRunDttm)
                    .HasColumnName("MO_OPT_SCENARIO_RUN_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MoOptScenarioVersionNo)
                    .HasColumnName("MO_OPT_SCENARIO_VERSION_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CiPackage>(entity =>
            {
                entity.HasKey(e => e.PackageSk)
                    .HasName("PACKAGE_PK");

                entity.ToTable("CI_PACKAGE");

                entity.Property(e => e.PackageSk)
                    .HasColumnName("PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ChannelCd)
                    .HasColumnName("CHANNEL_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PackageCd)
                    .HasColumnName("PACKAGE_CD")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChannelCdNavigation)
                    .WithMany(p => p.CiPackage)
                    .HasForeignKey(d => d.ChannelCd)
                    .HasConstraintName("PACKAGE_FK1");
            });

            modelBuilder.Entity<CiPackageXTreatment>(entity =>
            {
                entity.HasKey(e => new { e.PackageSk, e.PackageHashVal, e.TreatmentSk, e.ContributingCellPackageSk, e.SequenceNo })
                    .HasName("PKG_X_TREAT_PK");

                entity.ToTable("CI_PACKAGE_X_TREATMENT");

                entity.Property(e => e.PackageSk)
                    .HasColumnName("PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PackageHashVal)
                    .HasColumnName("PACKAGE_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ContributingCellPackageSk)
                    .HasColumnName("CONTRIBUTING_CELL_PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("numeric(6, 0)");

                entity.HasOne(d => d.ContributingCellPackageSkNavigation)
                    .WithMany(p => p.CiPackageXTreatment)
                    .HasForeignKey(d => d.ContributingCellPackageSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PKG_X_TREAT_FK3");

                entity.HasOne(d => d.PackageSkNavigation)
                    .WithMany(p => p.CiPackageXTreatment)
                    .HasForeignKey(d => d.PackageSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PKG_X_TREAT_FK1");

                entity.HasOne(d => d.TreatmentSkNavigation)
                    .WithMany(p => p.CiPackageXTreatment)
                    .HasForeignKey(d => d.TreatmentSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PKG_X_TREAT_FK2");
            });

            modelBuilder.Entity<CiPresentedTreatmentHistory>(entity =>
            {
                entity.HasKey(e => new { e.CellPackageSk, e.Rut, e.TreatmentSk, e.TreatmentHashVal, e.PresentedTreatmentHistDttm })
                    .HasName("PRE_TRT_HST_PK");

                entity.ToTable("CI_PRESENTED_TREATMENT_HISTORY");

                entity.Property(e => e.CellPackageSk)
                    .HasColumnName("CELL_PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TreatmentHashVal)
                    .HasColumnName("TREATMENT_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PresentedTreatmentHistDttm)
                    .HasColumnName("PRESENTED_TREATMENT_HIST_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalPresentedInfoId1)
                    .HasColumnName("EXTERNAL_PRESENTED_INFO_ID1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalPresentedInfoId2)
                    .HasColumnName("EXTERNAL_PRESENTED_INFO_ID2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PresentedTreatmentDt)
                    .HasColumnName("PRESENTED_TREATMENT_DT")
                    .HasColumnType("date");

                entity.Property(e => e.ResponseTrackingCd)
                    .HasColumnName("RESPONSE_TRACKING_CD")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiResponse>(entity =>
            {
                entity.HasKey(e => e.ResponseSk)
                    .HasName("RESPONSE_PK");

                entity.ToTable("CI_RESPONSE");

                entity.Property(e => e.ResponseSk)
                    .HasColumnName("RESPONSE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ResponseCd)
                    .IsRequired()
                    .HasColumnName("RESPONSE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseNm)
                    .HasColumnName("RESPONSE_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiResponseChannelResponse>(entity =>
            {
                entity.HasKey(e => new { e.ResponseChannelCd, e.ResponseChannelResponseCd, e.ResponseSk })
                    .HasName("RSP_CHL_RSP_PK");

                entity.ToTable("CI_RESPONSE_CHANNEL_RESPONSE");

                entity.Property(e => e.ResponseChannelCd)
                    .HasColumnName("RESPONSE_CHANNEL_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseChannelResponseCd)
                    .HasColumnName("RESPONSE_CHANNEL_RESPONSE_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseSk)
                    .HasColumnName("RESPONSE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.ResponseChannelCdNavigation)
                    .WithMany(p => p.CiResponseChannelResponse)
                    .HasForeignKey(d => d.ResponseChannelCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RSP_CHL_RSP_FK1");

                entity.HasOne(d => d.ResponseSkNavigation)
                    .WithMany(p => p.CiResponseChannelResponse)
                    .HasForeignKey(d => d.ResponseSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RSP_CHL_RSP_FK2");
            });

            modelBuilder.Entity<CiResponseHistory>(entity =>
            {
                entity.HasKey(e => new { e.CellPackageSk, e.TreatmentSk, e.TreatmentHashVal, e.ResponseSk, e.Rut, e.ResponseDttm })
                    .HasName("RESP_HIST_PK");

                entity.ToTable("CI_RESPONSE_HISTORY");

                entity.Property(e => e.CellPackageSk)
                    .HasColumnName("CELL_PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TreatmentHashVal)
                    .HasColumnName("TREATMENT_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseSk)
                    .HasColumnName("RESPONSE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.ResponseDttm)
                    .HasColumnName("RESPONSE_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalResponseInfoId1)
                    .HasColumnName("EXTERNAL_RESPONSE_INFO_ID1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalResponseInfoId2)
                    .HasColumnName("EXTERNAL_RESPONSE_INFO_ID2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InferredResponseFlg)
                    .HasColumnName("INFERRED_RESPONSE_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseChannelCd)
                    .HasColumnName("RESPONSE_CHANNEL_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDt)
                    .HasColumnName("RESPONSE_DT")
                    .HasColumnType("date");

                entity.Property(e => e.ResponseTrackingCd)
                    .HasColumnName("RESPONSE_TRACKING_CD")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseValueAmt)
                    .HasColumnName("RESPONSE_VALUE_AMT")
                    .HasColumnType("numeric(14, 2)");
            });

            modelBuilder.Entity<CiResponseType>(entity =>
            {
                entity.HasKey(e => e.ResponseTypeCd)
                    .HasName("RESPONSE_TYPE_PK");

                entity.ToTable("CI_RESPONSE_TYPE");

                entity.Property(e => e.ResponseTypeCd)
                    .HasColumnName("RESPONSE_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ResponseTypeDesc)
                    .HasColumnName("RESPONSE_TYPE_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiResponseXCellPackage>(entity =>
            {
                entity.HasKey(e => new { e.ResponseSk, e.CellPackageSk })
                    .HasName("RESP_X_CPKG_PK");

                entity.ToTable("CI_RESPONSE_X_CELL_PACKAGE");

                entity.Property(e => e.ResponseSk)
                    .HasColumnName("RESPONSE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CellPackageSk)
                    .HasColumnName("CELL_PACKAGE_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.EstimatedResponseRt)
                    .HasColumnName("ESTIMATED_RESPONSE_RT")
                    .HasColumnType("numeric(9, 4)");

                entity.Property(e => e.ResponseTypeCd)
                    .HasColumnName("RESPONSE_TYPE_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CellPackageSkNavigation)
                    .WithMany(p => p.CiResponseXCellPackage)
                    .HasForeignKey(d => d.CellPackageSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RESP_X_CPKG_FK1");

                entity.HasOne(d => d.ResponseSkNavigation)
                    .WithMany(p => p.CiResponseXCellPackage)
                    .HasForeignKey(d => d.ResponseSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RESP_X_CPKG_FK2");

                entity.HasOne(d => d.ResponseTypeCdNavigation)
                    .WithMany(p => p.CiResponseXCellPackage)
                    .HasForeignKey(d => d.ResponseTypeCd)
                    .HasConstraintName("RESP_X_CPKG_FK3");
            });

            modelBuilder.Entity<CiTreatCampSetStatus>(entity =>
            {
                entity.HasKey(e => e.TreatCampSetStatusCd)
                    .HasName("TREAT_CAMP_SET_STATUS_PK");

                entity.ToTable("CI_TREAT_CAMP_SET_STATUS");

                entity.Property(e => e.TreatCampSetStatusCd)
                    .HasColumnName("TREAT_CAMP_SET_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TreatCampSetStatusDesc)
                    .HasColumnName("TREAT_CAMP_SET_STATUS_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiTreatCampSetXCampaign>(entity =>
            {
                entity.HasKey(e => new { e.TreatmentCampaignSetSk, e.CampaignSk })
                    .HasName("TCS_X_CAMP_PK");

                entity.ToTable("CI_TREAT_CAMP_SET_X_CAMPAIGN");

                entity.Property(e => e.TreatmentCampaignSetSk)
                    .HasColumnName("TREATMENT_CAMPAIGN_SET_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CampaignSk)
                    .HasColumnName("CAMPAIGN_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DeletedFlg)
                    .HasColumnName("DELETED_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CampaignSkNavigation)
                    .WithMany(p => p.CiTreatCampSetXCampaign)
                    .HasForeignKey(d => d.CampaignSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TCS_X_CAMP_FK2");

                entity.HasOne(d => d.TreatmentCampaignSetSkNavigation)
                    .WithMany(p => p.CiTreatCampSetXCampaign)
                    .HasForeignKey(d => d.TreatmentCampaignSetSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TCS_X_CAMP_FK1");
            });

            modelBuilder.Entity<CiTreatment>(entity =>
            {
                entity.HasKey(e => e.TreatmentSk)
                    .HasName("TREATMENT_PK");

                entity.ToTable("CI_TREATMENT");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CurrentVersionFlg)
                    .HasColumnName("CURRENT_VERSION_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedFlg)
                    .HasColumnName("DELETED_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndDttm)
                    .HasColumnName("END_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDttm)
                    .HasColumnName("START_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.TreatmentCd)
                    .HasColumnName("TREATMENT_CD")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentDesc)
                    .HasColumnName("TREATMENT_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentNm)
                    .HasColumnName("TREATMENT_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentReferenceTxt)
                    .HasColumnName("TREATMENT_REFERENCE_TXT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentReferenceUrl)
                    .HasColumnName("TREATMENT_REFERENCE_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentVersionNo)
                    .HasColumnName("TREATMENT_VERSION_NO")
                    .HasColumnType("numeric(6, 0)");
            });

            modelBuilder.Entity<CiTreatmentCampaignSet>(entity =>
            {
                entity.HasKey(e => e.TreatmentCampaignSetSk)
                    .HasName("TREAT_CAMP_SET_PK");

                entity.ToTable("CI_TREATMENT_CAMPAIGN_SET");

                entity.Property(e => e.TreatmentCampaignSetSk)
                    .HasColumnName("TREATMENT_CAMPAIGN_SET_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DeletedFlg)
                    .HasColumnName("DELETED_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedByUserNm)
                    .HasColumnName("LAST_MODIFIED_BY_USER_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDttm)
                    .HasColumnName("LAST_MODIFIED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.TreatCampSetStatusCd)
                    .HasColumnName("TREAT_CAMP_SET_STATUS_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentCampSetDesc)
                    .HasColumnName("TREATMENT_CAMP_SET_DESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentCampSetFolderTxt)
                    .HasColumnName("TREATMENT_CAMP_SET_FOLDER_TXT")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentCampSetNm)
                    .HasColumnName("TREATMENT_CAMP_SET_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.TreatCampSetStatusCdNavigation)
                    .WithMany(p => p.CiTreatmentCampaignSet)
                    .HasForeignKey(d => d.TreatCampSetStatusCd)
                    .HasConstraintName("TREAT_CAMP_SET_FK1");
            });

            modelBuilder.Entity<CiTreatmentCharUdf>(entity =>
            {
                entity.HasKey(e => new { e.TreatmentSk, e.CharUdfNm, e.TreatmentHashVal })
                    .HasName("TREAT_CH_UDF_PK");

                entity.ToTable("CI_TREATMENT_CHAR_UDF");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CharUdfNm)
                    .HasColumnName("CHAR_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentHashVal)
                    .HasColumnName("TREATMENT_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CharExtColumnNm)
                    .HasColumnName("CHAR_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CharUdfVal)
                    .HasColumnName("CHAR_UDF_VAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TreatmentSkNavigation)
                    .WithMany(p => p.CiTreatmentCharUdf)
                    .HasForeignKey(d => d.TreatmentSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TREAT_CH_UDF_FK1");
            });

            modelBuilder.Entity<CiTreatmentDateUdf>(entity =>
            {
                entity.HasKey(e => new { e.TreatmentSk, e.DateUdfNm, e.TreatmentHashVal })
                    .HasName("TREAT_DT_UDF_PK");

                entity.ToTable("CI_TREATMENT_DATE_UDF");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DateUdfNm)
                    .HasColumnName("DATE_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentHashVal)
                    .HasColumnName("TREATMENT_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DateExtColumnNm)
                    .HasColumnName("DATE_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateUdfVal)
                    .HasColumnName("DATE_UDF_VAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TreatmentSkNavigation)
                    .WithMany(p => p.CiTreatmentDateUdf)
                    .HasForeignKey(d => d.TreatmentSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TREAT_DT_UDF_FK1");
            });

            modelBuilder.Entity<CiTreatmentExt>(entity =>
            {
                entity.HasKey(e => e.TreatmentSk)
                    .HasName("TREAT_EXT_PK");

                entity.ToTable("CI_TREATMENT_EXT");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.TreatmentSkNavigation)
                    .WithOne(p => p.CiTreatmentExt)
                    .HasForeignKey<CiTreatmentExt>(d => d.TreatmentSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TREAT_EXT_FK1");
            });

            modelBuilder.Entity<CiTreatmentNumUdf>(entity =>
            {
                entity.HasKey(e => new { e.TreatmentSk, e.NumUdfNm, e.TreatmentHashVal })
                    .HasName("TREAT_NM_UDF_PK");

                entity.ToTable("CI_TREATMENT_NUM_UDF");

                entity.Property(e => e.TreatmentSk)
                    .HasColumnName("TREATMENT_SK")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumUdfNm)
                    .HasColumnName("NUM_UDF_NM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentHashVal)
                    .HasColumnName("TREATMENT_HASH_VAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NumExtColumnNm)
                    .HasColumnName("NUM_EXT_COLUMN_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumUdfVal)
                    .HasColumnName("NUM_UDF_VAL")
                    .HasColumnType("numeric(17, 2)");

                entity.Property(e => e.ProcessedDttm)
                    .HasColumnName("PROCESSED_DTTM")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TreatmentSkNavigation)
                    .WithMany(p => p.CiTreatmentNumUdf)
                    .HasForeignKey(d => d.TreatmentSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TREAT_NM_UDF_FK1");
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

            modelBuilder.Entity<CommCampos>(entity =>
            {
                entity.HasKey(e => e.ValorCommContactos)
                    .HasName("PK__COMM_CAM__90E7E88A2C6AFFFF");

                entity.ToTable("COMM_CAMPOS");

                entity.Property(e => e.ValorCommContactos)
                    .HasColumnName("VALOR_COMM_CONTACTOS")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

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

            modelBuilder.Entity<CommContactosClau>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.IdCampana });

                entity.ToTable("COMM_CONTACTOS_CLAU");

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

            modelBuilder.Entity<CommContactosMulticanal>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.Idcmpejec, e.IdCampana, e.Canal });

                entity.ToTable("COMM_CONTACTOS_MULTICANAL");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.Idcmpejec).HasColumnName("IDCMPEJEC");

                entity.Property(e => e.IdCampana)
                    .HasColumnName("ID_CAMPANA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue1)
                    .HasColumnName("CUSTOM_VALUE1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue10)
                    .HasColumnName("CUSTOM_VALUE10")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue11)
                    .HasColumnName("CUSTOM_VALUE11")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue12)
                    .HasColumnName("CUSTOM_VALUE12")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue13)
                    .HasColumnName("CUSTOM_VALUE13")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue14)
                    .HasColumnName("CUSTOM_VALUE14")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue15)
                    .HasColumnName("CUSTOM_VALUE15")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue16)
                    .HasColumnName("CUSTOM_VALUE16")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue17)
                    .HasColumnName("CUSTOM_VALUE17")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue18)
                    .HasColumnName("CUSTOM_VALUE18")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue19)
                    .HasColumnName("CUSTOM_VALUE19")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue2)
                    .HasColumnName("CUSTOM_VALUE2")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue20)
                    .HasColumnName("CUSTOM_VALUE20")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue21)
                    .HasColumnName("CUSTOM_VALUE21")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue22)
                    .HasColumnName("CUSTOM_VALUE22")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue23)
                    .HasColumnName("CUSTOM_VALUE23")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue24)
                    .HasColumnName("CUSTOM_VALUE24")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue25)
                    .HasColumnName("CUSTOM_VALUE25")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue3)
                    .HasColumnName("CUSTOM_VALUE3")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue4)
                    .HasColumnName("CUSTOM_VALUE4")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue5)
                    .HasColumnName("CUSTOM_VALUE5")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue6)
                    .HasColumnName("CUSTOM_VALUE6")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue7)
                    .HasColumnName("CUSTOM_VALUE7")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue8)
                    .HasColumnName("CUSTOM_VALUE8")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue9)
                    .HasColumnName("CUSTOM_VALUE9")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcionerror)
                    .HasColumnName("DESCRIPCIONERROR")
                    .IsUnicode(false);

                entity.Property(e => e.DigitoRut)
                    .HasColumnName("DIGITO_RUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivo)
                    .HasColumnName("EJECUTIVO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Emailcontacto)
                    .HasColumnName("EMAILCONTACTO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Error).HasColumnName("ERROR");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FecfinCamp)
                    .HasColumnName("FECFIN_CAMP")
                    .HasColumnType("date");

                entity.Property(e => e.Fechaingreso)
                    .HasColumnName("FECHAINGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechaprocesamiento)
                    .HasColumnName("FECHAPROCESAMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeciniCamp)
                    .HasColumnName("FECINI_CAMP")
                    .HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdWcmWeb)
                    .HasColumnName("ID_WCM_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idejecutivo)
                    .HasColumnName("IDEJECUTIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idsucursal).HasColumnName("IDSUCURSAL");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrecampana)
                    .HasColumnName("NOMBRECAMPANA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ordencmpcanal).HasColumnName("ORDENCMPCANAL");

                entity.Property(e => e.Procesado).HasColumnName("PROCESADO");

                entity.Property(e => e.ResponseTrackingCd)
                    .HasColumnName("RESPONSE_TRACKING_CD")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefonocontacto)
                    .HasColumnName("TELEFONOCONTACTO")
                    .HasMaxLength(50)
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

            modelBuilder.Entity<CommContactosMulticanalPrevia>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.Idcmpejec, e.IdCampana, e.Canal });

                entity.ToTable("COMM_CONTACTOS_MULTICANAL_PREVIA");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.Idcmpejec).HasColumnName("IDCMPEJEC");

                entity.Property(e => e.IdCampana)
                    .HasColumnName("ID_CAMPANA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue1)
                    .HasColumnName("CUSTOM_VALUE1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue10)
                    .HasColumnName("CUSTOM_VALUE10")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue11)
                    .HasColumnName("CUSTOM_VALUE11")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue12)
                    .HasColumnName("CUSTOM_VALUE12")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue13)
                    .HasColumnName("CUSTOM_VALUE13")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue14)
                    .HasColumnName("CUSTOM_VALUE14")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue15)
                    .HasColumnName("CUSTOM_VALUE15")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue16)
                    .HasColumnName("CUSTOM_VALUE16")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue17)
                    .HasColumnName("CUSTOM_VALUE17")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue18)
                    .HasColumnName("CUSTOM_VALUE18")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue19)
                    .HasColumnName("CUSTOM_VALUE19")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue2)
                    .HasColumnName("CUSTOM_VALUE2")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue20)
                    .HasColumnName("CUSTOM_VALUE20")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue21)
                    .HasColumnName("CUSTOM_VALUE21")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue22)
                    .HasColumnName("CUSTOM_VALUE22")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue23)
                    .HasColumnName("CUSTOM_VALUE23")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue24)
                    .HasColumnName("CUSTOM_VALUE24")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue25)
                    .HasColumnName("CUSTOM_VALUE25")
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue3)
                    .HasColumnName("CUSTOM_VALUE3")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue4)
                    .HasColumnName("CUSTOM_VALUE4")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue5)
                    .HasColumnName("CUSTOM_VALUE5")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue6)
                    .HasColumnName("CUSTOM_VALUE6")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue7)
                    .HasColumnName("CUSTOM_VALUE7")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue8)
                    .HasColumnName("CUSTOM_VALUE8")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue9)
                    .HasColumnName("CUSTOM_VALUE9")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DigitoRut)
                    .HasColumnName("DIGITO_RUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ejecutivo)
                    .HasColumnName("EJECUTIVO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Emailcontacto)
                    .HasColumnName("EMAILCONTACTO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FecfinCamp)
                    .HasColumnName("FECFIN_CAMP")
                    .HasColumnType("date");

                entity.Property(e => e.FeciniCamp)
                    .HasColumnName("FECINI_CAMP")
                    .HasColumnType("date");

                entity.Property(e => e.IdWcmWeb)
                    .HasColumnName("ID_WCM_WEB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idejecutivo)
                    .HasColumnName("IDEJECUTIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idsucursal).HasColumnName("IDSUCURSAL");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrecampana)
                    .HasColumnName("NOMBRECAMPANA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ordencmpcanal).HasColumnName("ORDENCMPCANAL");

                entity.Property(e => e.Sucursal)
                    .HasColumnName("SUCURSAL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefonocontacto)
                    .HasColumnName("TELEFONOCONTACTO")
                    .HasMaxLength(50)
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

            modelBuilder.Entity<CommContactosPrima>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.IdCampana });

                entity.ToTable("COMM_CONTACTOS_Prima");

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

            modelBuilder.Entity<CommNegociacion>(entity =>
            {
                entity.HasKey(e => e.Rut)
                    .HasName("PK__COMM_NEG__CAF332594D41E3E5");

                entity.ToTable("COMM_NEGOCIACION");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodcomCodigoDeSegComp1).HasColumnName("CODCOM_CODIGO_DE_SEG_COMP1");

                entity.Property(e => e.CodscoCodigoDeSegComp2).HasColumnName("CODSCO_CODIGO_DE_SEG_COMP2");

                entity.Property(e => e.Fechaingreso)
                    .HasColumnName("FECHAINGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NomcomNombreDeSegComp1)
                    .HasColumnName("NOMCOM_NOMBRE_DE_SEG_COMP1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomscoNombreDeSegComp2)
                    .HasColumnName("NOMSCO_NOMBRE_DE_SEG_COMP2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSolicitud).HasColumnName("NUMERO_SOLICITUD");

                entity.Property(e => e.Procesado).HasColumnName("PROCESADO");

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

                entity.Property(e => e.XmlNegociacion)
                    .HasColumnName("XML_NEGOCIACION")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommNovedadesCampaña>(entity =>
            {
                entity.ToTable("COMM_NOVEDADES_CAMPAÑA");

                entity.HasIndex(e => new { e.IdCampaña, e.IdCanal })
                    .HasName("UQ_COMM_NOVEDADES_CAMPAÑA_ID_CAMPAÑA_ID_CANAL")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("FECHA_FIN")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("FECHA_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.IdCampaña).HasColumnName("ID_CAMPAÑA");

                entity.Property(e => e.IdCanal).HasColumnName("ID_CANAL");
            });

            modelBuilder.Entity<CommNovedadesCampañaMulticanal>(entity =>
            {
                entity.ToTable("COMM_NOVEDADES_CAMPAÑA_MULTICANAL");

                entity.HasIndex(e => new { e.Idcmpejec, e.IdCanal })
                    .HasName("UQ_COMM_NOVEDADES_CAMPAÑA_MULTICANAL_ID_CAMPAÑA_ID_CANAL")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("FECHA_FIN")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("FECHA_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.Fechacarga)
                    .HasColumnName("FECHACARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Glosa)
                    .HasColumnName("GLOSA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCanal).HasColumnName("ID_CANAL");

                entity.Property(e => e.Idcmpejec).HasColumnName("IDCMPEJEC");
            });

            modelBuilder.Entity<CommNovedadesRut>(entity =>
            {
                entity.ToTable("COMM_NOVEDADES_RUT");

                entity.HasIndex(e => new { e.Rut, e.IdCampaña })
                    .HasName("UQ_COMM_NOVEDADES_Rut_IdCam")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCarga).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCampaña).HasColumnName("ID_CAMPAÑA");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");
            });

            modelBuilder.Entity<CommNovedadesRut2>(entity =>
            {
                entity.ToTable("COMM_NOVEDADES_RUT2");

                entity.HasIndex(e => new { e.Rut, e.IdCampaña })
                    .HasName("UQ_COMM_NOVEDADES_Rut_IdCam2")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCarga).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCampaña).HasColumnName("ID_CAMPAÑA");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");
            });

            modelBuilder.Entity<CommNovedadesRutMulticanal>(entity =>
            {
                entity.ToTable("COMM_NOVEDADES_RUT_MULTICANAL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fechacarga)
                    .HasColumnName("FECHACARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Glosa)
                    .HasColumnName("GLOSA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCanal).HasColumnName("ID_CANAL");

                entity.Property(e => e.Idcmpejec).HasColumnName("IDCMPEJEC");

                entity.Property(e => e.Rut)
                    .HasColumnName("RUT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.Vigente).HasColumnName("VIGENTE");
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
        }
    }

    public class hCOMM_CONTACTOS
    {
        public decimal RUT { get; set; }
        public string DIGITO_RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string SUCURSAL { get; set; }
        public string MON_APROBADO { get; set; }
        public string OFERTA_CUPO_1 { get; set; }
        public string OFERTA_CUPO_2 { get; set; }
        public string OFERTA_CUPO_3 { get; set; }
        public string OFERTA_CUPO_4 { get; set; }
        public string OFERTA_CUPO_5 { get; set; }
        public string TASA { get; set; }
        public string EJECUTIVO { get; set; }
        public string EMAIL { get; set; }
        public string RESPONSE_TRACKING_CD { get; set; }
        public string ESTADO { get; set; }
        public string ID_CAMPANA { get; set; }
        public int TIP_CAMPANA { get; set; }
        public string TIP_PRODUCTO { get; set; }
        public string NOTIFICACION { get; set; }
        public string CANALES { get; set; }
        public DateTime? FECINI_WEB { get; set; }
        public DateTime? FECFIN_WEB { get; set; }
        public string TEXTO1_WEB { get; set; }
        public string TEXTO2_WEB { get; set; }
        public string FIN_FLUJO { get; set; }
        public string ESTILO_WEB { get; set; }
        public string ID_WCM_WEB { get; set; }
        public string LINK_WEB { get; set; }
        public string AC_CIERRE_WEB { get; set; }
        public DateTime? FECINI_MOBILE { get; set; }
        public DateTime? FECFIN_MOBILE { get; set; }
        public string TEXTO1_MOBILE { get; set; }
        public string TEXTO2_MOBILE { get; set; }
        public string LINK_MOBILE { get; set; }
        public string AC_CIERRE_MOBILE { get; set; }
        public DateTime? FECINI_AGENDA { get; set; }
        public DateTime? FECFIN_AGENDA { get; set; }
        public string TextoVariable1 { get; set; }
        public string TextoVariable2 { get; set; }
        public string TextoVariable3 { get; set; }
        public string TextoVariable4 { get; set; }
        public string NombreCampana { get; set; }
        public string TipodeFuncional { get; set; }
    }
}
