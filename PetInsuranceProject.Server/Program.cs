using Microsoft.Extensions.Options;

using PetInsuranceProject.Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Default JSON options (preserves ASP.NET Core's camelCase-to-PascalCase binding)
builder.Services.AddControllers();
// Add Entity Framework Core with SQL Server
builder.Services.AddDbContext<DBContextClass>();
    //(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowClient", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowClient");
app.MapControllers();

app.Run();


//TO-DO
// EF Core setup: 
// 1. Install Microsoft.EntityFrameworkCore.SqlServer
// 2. Create DBContextClass : DbContext
// 3. Add "DefaultConnection" string in appsettings.json
// 4. using Microsoft.EntityFrameworkCore;
// CORS: Allows http://localhost:5173 for frontend dev
// CORS to allow Vue dev server