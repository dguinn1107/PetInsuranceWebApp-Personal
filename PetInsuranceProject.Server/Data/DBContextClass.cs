using Microsoft.EntityFrameworkCore;

using PetInsuranceProject.Server.Models;


namespace PetInsuranceProject.Server.Data;

public class DBContextClass : DbContext
{
    DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<QuickQuoteModel>()
         .HasKey(q => q.QuoteId);
        modelBuilder.Entity<QuickQuoteModel>()
            .HasOne(q => q.Pet)
            .WithMany()
            .HasForeignKey(q => q.PetId);

        modelBuilder.Entity<PetModel>()
            .HasKey(p => p.PetId);
        modelBuilder.Entity<PetModel>()
            .HasOne(p => p.Breed)
            .WithMany()
            .HasForeignKey(p => p.BreedId);
   
        modelBuilder.Entity<BreedModel>()
            .HasKey(b => b.BreedId);
        modelBuilder.Entity<HealthRecordModel>()
            .HasKey(hr => hr.HealthRecordId);

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


        //NEED TO ADD SETS?



        base.OnModelCreating(modelBuilder);
    }
}







