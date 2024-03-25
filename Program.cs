using Microsoft.EntityFrameworkCore;
using CannabisAPI.Data; // Make sure this using statement matches the namespace of your DataContext class

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure DbContext with SQL Server
builder.Services.AddDbContext<DbSet>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CannabisDatabase")));

// Add Swagger/OpenAPI support if in Development environment
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();