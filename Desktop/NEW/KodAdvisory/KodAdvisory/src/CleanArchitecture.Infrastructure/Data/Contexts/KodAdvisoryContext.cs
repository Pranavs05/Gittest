using System;
using CleanArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Infrastructure.Data.Contexts
{
    public partial class KodAdvisoryContext : DbContext
    {
        public KodAdvisoryContext()
        {
        }

        public KodAdvisoryContext(DbContextOptions<KodAdvisoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AmortizationCode> AmortizationCode { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetCategory> AssetCategory { get; set; }
        public virtual DbSet<AssetConvention> AssetConvention { get; set; }
        public virtual DbSet<AssetMethodCategory> AssetMethodCategory { get; set; }
        public virtual DbSet<ListedPropertyType> ListedPropertyType { get; set; }
        public virtual DbSet<PropertyTypeCode> PropertyTypeCode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=BOND-PC;Database=KodAdvisory;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AmortizationCode>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BonusDepriciation).HasColumnType("money");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CurrentDepriciation).HasColumnType("money");

                entity.Property(e => e.CurrentYearExpSec179).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PriorBonusDepriciation).HasColumnType("money");

                entity.Property(e => e.PriorExpSec179).HasColumnType("money");

                entity.Property(e => e.PriorRegDepreciation).HasColumnType("money");

                entity.HasOne(d => d.AmortizationCode)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_AmortizationCode");

                entity.HasOne(d => d.AssetCategory)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_AssetCategory");

                entity.HasOne(d => d.AssetConvention)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_AssetConvention");

                entity.HasOne(d => d.Method)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_AssetMethodCategory");

                entity.HasOne(d => d.PropertyType)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_ListedPropertyType");

                entity.HasOne(d => d.PropertyTypeCode)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asset_PropertyTypeCode");
            });

            modelBuilder.Entity<AssetCategory>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetConvention>(entity =>
            {
                entity.Property(e => e.Abbr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetMethodCategory>(entity =>
            {
                entity.Property(e => e.Abbr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListedPropertyType>(entity =>
            {
                entity.Property(e => e.Abbr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PropertyTypeCode>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
