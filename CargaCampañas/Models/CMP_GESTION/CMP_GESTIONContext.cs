using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CargaCampañas.Models.CMP_GESTION
{
    public partial class CMP_GESTIONContext : DbContext
    {
        public CMP_GESTIONContext()
        {
        }

        public CMP_GESTIONContext(DbContextOptions<CMP_GESTIONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CmpBody> CmpBody { get; set; }
        public virtual DbSet<CmpHead> CmpHead { get; set; }

        public virtual DbQuery<InfoCampañas> InfoCamp { get; set; }

        // Unable to generate entity type for table 'SEG.Area'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.EstadoUsuario'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.MenuWeb'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.Modulo'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.PermisoMenu'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.PermisoServicio'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.Rol'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.Servicio'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.TipoAcceso'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.TipoUsuario'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.TokenValidos'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.Usuario'. Please see the warning messages.
        // Unable to generate entity type for table 'SEG.UsuarioRol'. Please see the warning messages.
        // Unable to generate entity type for table 'LOG.ErroresWebApi'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COMM_Homologacion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_TipoCampaña'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_TipoProducto'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_TipoFuncional'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CMP_EstadoCampaña'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_BODY_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_HEAD_20190103'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_BODY_20190103'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cmp_TipoDueño'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=CLSTGPORTD05;Database=CMP_GESTION;Trusted_Connection=False; user id=desa;password=desa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<CmpBody>(entity =>
            {
                entity.ToTable("Cmp_BODY");

                entity.Property(e => e.Cockpit)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommContacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaModificaReg).HasColumnType("datetime");

                entity.Property(e => e.Mapeo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MapeoImap)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ValorPorDefecto)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmpHead>(entity =>
            {
                entity.ToTable("Cmp_HEAD");

                entity.Property(e => e.DueñoCmp)
                    .HasColumnName("DueñoCMP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompromiso).HasColumnType("datetime");

                entity.Property(e => e.FechaCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaGeneradaMa)
                    .HasColumnName("FechaGeneradaMA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaImap).HasColumnType("datetime");

                entity.Property(e => e.FechaModificaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaRevisa).HasColumnType("datetime");

                entity.Property(e => e.GeneradaMa).HasColumnName("GeneradaMA");

                entity.Property(e => e.IdCampaña)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdWcm)
                    .HasColumnName("IdWCM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdWcmdetalle)
                    .HasColumnName("IdWCMDetalle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCampaña)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFuncional)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipoCampaña)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipoProducto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.UsrGeneradaMa).HasColumnName("UsrGeneradaMA");

                entity.Property(e => e.UsrRespCrm).HasColumnName("UsrRespCRM");

                entity.Property(e => e.UsrRespMa).HasColumnName("UsrRespMA");
            });

        }


    }


    public class InfoCampañas
    {
        public string NombreTipoProducto { get; set; }
        public string NombreFuncional { get; set; }
        public string IdWCM { get; set; }
        public int IdTipoCampaña { get; set; }
    }
}
