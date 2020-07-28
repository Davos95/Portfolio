using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoFotoCore3.Data.Context
{
    public partial class PortfolioContext1 : DbContext
    {
        public PortfolioContext1()
        {
        }

        public PortfolioContext1(DbContextOptions<PortfolioContext1> options)
            : base(options)
        {
        }

        public  DbSet<Apartado> Apartado { get; set; }
        public  DbSet<Foto> Foto { get; set; }
        public  DbSet<Sesion> Sesion { get; set; }
        public  DbSet<SobreMi> SobreMi { get; set; }
        public  DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-885Q0CE\\SQLEXPRESS01;User=sa;Password=admin123;Initial Catalog=Portfolio");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartado>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Foto>(entity =>
            {
                entity.Property(e => e.UriAzure)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdSesionNavigation)
                    .WithMany(p => p.Foto)
                    .HasForeignKey(d => d.IdSesion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foto_Sesion");
            });

            modelBuilder.Entity<Sesion>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.IdApartadoNavigation)
                    .WithMany(p => p.Sesion)
                    .HasForeignKey(d => d.IdApartado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sesion_Apartado");
            });

            modelBuilder.Entity<SobreMi>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.UriAzure).HasColumnType("text");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
