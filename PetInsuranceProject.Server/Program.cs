var builder = WebApplication.CreateBuilder(args);

// Default JSON options (preserves ASP.NET Core's camelCase-to-PascalCase binding)
builder.Services.AddControllers();

// CORS to allow Vue dev server
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