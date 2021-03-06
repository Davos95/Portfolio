﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoFotoCore3.Data.Context
{
    public partial class PortfolioContext : DbContext
    {
        public PortfolioContext()
        {
        }

        public PortfolioContext(DbContextOptions<PortfolioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apartado> Apartado { get; set; }
        public virtual DbSet<Foto> Foto { get; set; }
        public virtual DbSet<Sesion> Sesion { get; set; }
        public virtual DbSet<SobreMi> SobreMi { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS01;Initial Catalog=Portfolio;User ID=sa;Password=admin123");
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

                entity.HasOne(d => d.IdFotoPreviewNavigation)
                    .WithMany(p => p.Sesion)
                    .HasForeignKey(d => d.IdFotoPreview)
                    .HasConstraintName("FK_Sesion_Foto");
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
