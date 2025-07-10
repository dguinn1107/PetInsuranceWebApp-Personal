using Microsoft.EntityFrameworkCore;

using PetInsuranceProject.Server.Models;


namespace PetInsuranceProject.Server.Data;

public class DBContextClass : DbContext
{
    public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
    {
    }
    public DbSet<QuickQuoteModel> QuickQuotes { get; set; }
    public DbSet<PetModel> Pets { get; set; }
    public DbSet<BreedModel> Breeds { get; set; }
    public DbSet<HealthRecordModel> HealthRecords { get; set; }
    public DbSet<HealthRecordConditionModel> HealthRecordConditions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<QuickQuoteModel>().HasKey(q => q.QuoteId);
        modelBuilder.Entity<QuickQuoteModel>()
            .HasOne(q => q.Pet)
            .WithMany()
            .HasForeignKey(q => q.PetId);

        modelBuilder.Entity<PetModel>().HasKey(p => p.PetId);
        modelBuilder.Entity<PetModel>()
            .HasOne(p => p.Breed)
            .WithMany()
            .HasForeignKey(p => p.BreedId);

        modelBuilder.Entity<BreedModel>().HasKey(b => b.BreedId);

        modelBuilder.Entity<HealthRecordModel>().HasKey(hr => hr.HealthRecordId);
        modelBuilder.Entity<HealthRecordModel>()
            .HasOne(hr => hr.Pet)
            .WithMany(p => p.HealthRecords)
            .HasForeignKey(hr => hr.PetId);

        modelBuilder.Entity<HealthRecordConditionModel>()
            .HasKey(hrc => new { hrc.HealthRecordId, hrc.ConditionId });
        modelBuilder.Entity<HealthRecordConditionModel>()
            .HasOne(hrc => hrc.HealthRecord)
            .WithMany(hr => hr.HealthRecordConditions)
            .HasForeignKey(hrc => hrc.HealthRecordId);
        modelBuilder.Entity<HealthRecordConditionModel>()
            .HasOne(hrc => hrc.Condition)
            .WithMany(c => c.HealthRecordConditions)
            .HasForeignKey(hrc => hrc.ConditionId);

        base.OnModelCreating(modelBuilder);
    }
}







