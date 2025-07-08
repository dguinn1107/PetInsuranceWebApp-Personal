using Microsoft.EntityFrameworkCore;


namespace PetInsuranceProject.Server;

    public class DBContextClass : DbContext
{
    DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
    {

    }


   // public DbSet<PetModel> Pet { get; set; }
    



}  







