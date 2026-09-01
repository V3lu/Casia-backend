using Casia_backend.src.Inventory.Core.Application.Mappings;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddMapster();
TypeAdapterConfig.GlobalSettings.Scan(typeof(InventoryMappingConfig).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<InventoryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("InventoryDb"));
    // For future reference, pattern is "ModuleDb" for other connection strings
    options.EnableSensitiveDataLogging();
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
