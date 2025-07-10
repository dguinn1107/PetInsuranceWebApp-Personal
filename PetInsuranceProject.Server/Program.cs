using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Identity;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using PetInsuranceProject.Server.Data;






var builder = WebApplication.CreateBuilder(args);

var keyVaultName = builder.Configuration["KeyVaultName"];
var keyVaultUri = new Uri($"https://{keyVaultName}.vault.azure.net/");

builder.Configuration.AddAzureKeyVault(keyVaultUri, new DefaultAzureCredential());
builder.Services.AddControllers();



builder.Services.AddDbContext<DBContextClass>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



var app = builder.Build();

app.UseCors("AllowClient");
app.MapControllers();

app.Run();


/////Tomorrow’s tasks:

//Create Azure Key Vault in existing resource group.

//Add secrets (passwords) to Key Vault.

//Update code with correct AddAzureKeyVault usage and usings.

//Build and test Key Vault integration.