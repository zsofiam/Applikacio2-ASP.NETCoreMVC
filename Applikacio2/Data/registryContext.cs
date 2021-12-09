using System;
using Applikacio2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Applikacio2
{
    public partial class registryContext : DbContext
    {
        public registryContext()
        {
        }

        public registryContext(DbContextOptions<registryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dokumentum> Dokumenta { get; set; }
        public virtual DbSet<Esemeny> Esemenies { get; set; }
        public virtual DbSet<Naplo> Naplos { get; set; }
        public virtual DbSet<Account> Accounts{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source = DESKTOP-AQPJ5PN; Initial Catalog=registry; integrated security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hungarian_CI_AS");

            modelBuilder.Entity<Dokumentum>(entity =>
            {
                entity.ToTable("dokumentum");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("extension");

                entity.Property(e => e.MainId).HasColumnName("main_id");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("source");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Esemeny>(entity =>
            {
                entity.ToTable("esemeny");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Naplo>(entity =>
            {
                entity.HasKey(e => new { e.DokumentumId, e.EsemenyId, e.HappenedAt });

                entity.ToTable("naplo");

                entity.Property(e => e.DokumentumId).HasColumnName("dokumentum_id");

                entity.Property(e => e.EsemenyId).HasColumnName("esemeny_id");

                entity.Property(e => e.HappenedAt).HasColumnName("happened_at");

                entity.HasOne(d => d.Dokumentum)
                    .WithMany(p => p.Naplos)
                    .HasForeignKey(d => d.DokumentumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_naplo_dokumentum");

                entity.HasOne(d => d.Esemeny)
                    .WithMany(p => p.Naplos)
                    .HasForeignKey(d => d.EsemenyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_naplo_esemeny");
            });
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(a => a.Username)
                    .ValueGeneratedNever()
                    .HasMaxLength(50)
                    .HasColumnName("Username");

                entity.Property(a => a.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
