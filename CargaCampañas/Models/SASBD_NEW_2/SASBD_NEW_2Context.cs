using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CargaCampañas.Models.SASBD_NEW_2
{
    public partial class SASBD_NEW_2Context : DbContext
    {
        public SASBD_NEW_2Context()
        {
        }

        public SASBD_NEW_2Context(DbContextOptions<SASBD_NEW_2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TpmCargaData> TpmCargaData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=CLSTGPORTD05;Database=SASBD_NEW_2;Trusted_Connection=False;user id=desa;password=desa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<TpmCargaData>(entity =>
            {
                entity.ToTable("TPM_CargaData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.IdCampaña)
                    .HasColumnName("idCampaña")
                    .HasMaxLength(50);

                entity.Property(e => e.RutConDv)
                    .HasColumnName("RutConDV")
                    .HasMaxLength(50);
            });
        }
    }
}
