using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PetInsuranceProject.Server.Models;

namespace PetInsuranceProject.Server.Database;

public partial class PetInsuranceContext : DbContext
{
    public PetInsuranceContext()
    {
    }

    public PetInsuranceContext(DbContextOptions<PetInsuranceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Breed> Breeds { get; set; }

    public virtual DbSet<HealthCondition> HealthConditions { get; set; }

    public virtual DbSet<HealthRecord> HealthRecords { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<QuickQuote> QuickQuotes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Breed>(entity =>
        {
            entity.HasKey(e => e.BreedId).HasName("PK__Breed__9B220BB1AE49773A");

            entity.ToTable("Breed");

            entity.Property(e => e.BreedId)
                .ValueGeneratedNever()
                .HasColumnName("breedId");
            entity.Property(e => e.BreedName)
                .HasMaxLength(50)
                .HasColumnName("breedName");
        });

        modelBuilder.Entity<HealthCondition>(entity =>
        {
            entity.HasKey(e => e.ConditionId).HasName("PK__HealthCo__A29757BC655C743D");

            entity.ToTable("HealthCondition");

            entity.Property(e => e.ConditionId)
                .ValueGeneratedNever()
                .HasColumnName("conditionId");
            entity.Property(e => e.ConditionName)
                .HasMaxLength(50)
                .HasColumnName("conditionName");
        });

        modelBuilder.Entity<HealthRecord>(entity =>
        {
            entity.HasKey(e => e.HealthRecordId).HasName("PK__HealthRe__59B2D406124E2D5E");

            entity.ToTable("HealthRecord");

            entity.Property(e => e.HealthRecordId)
                .ValueGeneratedNever()
                .HasColumnName("healthRecordId");
            entity.Property(e => e.Healthy).HasColumnName("healthy");
            entity.Property(e => e.PetId).HasColumnName("petId");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("recordDate");

            entity.HasMany(d => d.Conditions).WithMany(p => p.HealthRecords)
                .UsingEntity<Dictionary<string, object>>(
                    "HealthRecordCondition",
                    r => r.HasOne<HealthCondition>().WithMany()
                        .HasForeignKey("ConditionId")
                        .HasConstraintName("FK_HRC_Condition"),
                    l => l.HasOne<HealthRecord>().WithMany()
                        .HasForeignKey("HealthRecordId")
                        .HasConstraintName("FK_HRC_HealthRecord"),
                    j =>
                    {
                        j.HasKey("HealthRecordId", "ConditionId");
                        j.ToTable("HealthRecordCondition");
                        j.IndexerProperty<Guid>("HealthRecordId").HasColumnName("healthRecordId");
                        j.IndexerProperty<int>("ConditionId").HasColumnName("conditionId");
                    });
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId).HasName("PK__Pet__DDF8507959E8B8E4");

            entity.ToTable("Pet");

            entity.Property(e => e.PetId)
                .ValueGeneratedNever()
                .HasColumnName("petId");
            entity.Property(e => e.BreedId).HasColumnName("breedId");
            entity.Property(e => e.PetAge).HasColumnName("petAge");
            entity.Property(e => e.PetName)
                .HasMaxLength(50)
                .HasColumnName("petName");
            entity.Property(e => e.PetSex).HasColumnName("petSex");

            entity.HasOne(d => d.Breed).WithMany(p => p.Pets)
                .HasForeignKey(d => d.BreedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pet_Breed");
        });

        modelBuilder.Entity<QuickQuote>(entity =>
        {
            entity.HasKey(e => e.QuoteId);

            entity.ToTable("QuickQuote");

            entity.Property(e => e.QuoteId)
                .ValueGeneratedNever()
                .HasColumnName("quoteId");
            entity.Property(e => e.PetId).HasColumnName("petId");
            entity.Property(e => e.QuoteEmail)
                .HasMaxLength(50)
                .HasColumnName("quoteEmail");
            entity.Property(e => e.QuoteUserFirstName)
                .HasMaxLength(50)
                .HasColumnName("quoteUserFirstName");
            entity.Property(e => e.QuoteUserLastName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("quoteUserLastName");

            entity.HasOne(d => d.Pet).WithMany(p => p.QuickQuotes)
                .HasForeignKey(d => d.PetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuickQuote_Pet");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
