using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoFotoCore3.Repository.Context
{
    public partial class PictureManagerContext : DbContext
    {
        public PictureManagerContext()
        {
        }

        public PictureManagerContext(DbContextOptions<PictureManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comision> Comision { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Sesion> Sesion { get; set; }
        public virtual DbSet<SesionWorker> SesionWorker { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Work> Work { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-885Q0CE\\SQLEXPRESS01;User=sa;Password=Test1234;Initial Catalog=PictureManager");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comision>(entity =>
            {
                entity.ToTable("COMISION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(25);

                entity.Property(e => e.Ordercomision).HasColumnName("ORDERCOMISION");

                entity.Property(e => e.Photo)
                    .HasColumnName("PHOTO")
                    .HasColumnType("text");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Uriazure)
                    .HasColumnName("URIAZURE")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Picture })
                    .HasName("PK__PHOTO__8D713A40DF570253");

                entity.ToTable("PHOTO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Picture)
                    .HasColumnName("PICTURE")
                    .HasMaxLength(50);

                entity.Property(e => e.Favorite).HasColumnName("FAVORITE");

                entity.Property(e => e.Idsesion).HasColumnName("IDSESION");

                entity.Property(e => e.Orderfavorite).HasColumnName("ORDERFAVORITE");

                entity.Property(e => e.Orderphoto).HasColumnName("ORDERPHOTO");

                entity.Property(e => e.Uriazure)
                    .HasColumnName("URIAZURE")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdsesionNavigation)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.Idsesion)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__PHOTO__IDSESION__66603565");
            });

            modelBuilder.Entity<Sesion>(entity =>
            {
                entity.ToTable("SESION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datesesion)
                    .HasColumnName("DATESESION")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text");

                entity.Property(e => e.Idcomision).HasColumnName("IDCOMISION");

                entity.Property(e => e.Idphoto).HasColumnName("IDPHOTO");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdcomisionNavigation)
                    .WithMany(p => p.Sesion)
                    .HasForeignKey(d => d.Idcomision)
                    .HasConstraintName("FK__SESION__IDCOMISI__6383C8BA");
            });

            modelBuilder.Entity<SesionWorker>(entity =>
            {
                entity.HasKey(e => new { e.Idsesion, e.Idworker })
                    .HasName("PK__SESION_W__C94271464412EDA4");

                entity.ToTable("SESION_WORKER");

                entity.Property(e => e.Idsesion).HasColumnName("IDSESION");

                entity.Property(e => e.Idworker).HasColumnName("IDWORKER");

                entity.Property(e => e.Idwork).HasColumnName("IDWORK");

                entity.HasOne(d => d.IdsesionNavigation)
                    .WithMany(p => p.SesionWorker)
                    .HasForeignKey(d => d.Idsesion)
                    .HasConstraintName("FK__SESION_WO__IDSES__6D0D32F4");

                entity.HasOne(d => d.IdworkNavigation)
                    .WithMany(p => p.SesionWorker)
                    .HasForeignKey(d => d.Idwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__SESION_WO__IDWOR__6A30C649");

                entity.HasOne(d => d.IdworkerNavigation)
                    .WithMany(p => p.SesionWorker)
                    .HasForeignKey(d => d.Idworker)
                    .HasConstraintName("FK__SESION_WO__IDWOR__693CA210");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("USERS");

                entity.HasIndex(e => e.Nick)
                    .HasName("UQ__USERS__E4376C44735B6BCA")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nick)
                    .IsRequired()
                    .HasColumnName("NICK")
                    .HasMaxLength(15);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("PWD")
                    .HasMaxLength(255);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("ROLE")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.ToTable("WORK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("WORKER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.Urlcontact)
                    .HasColumnName("URLCONTACT")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
