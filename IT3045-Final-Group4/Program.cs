using IT3045_Final_Group4.Data;
using IT3045_Final_Group4.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add NSwag
builder.Services.AddSwaggerDocument();

// Add Context Scope
builder.Services.AddScoped<ISampleContextDAO, SampleContextDAO>();
builder.Services.AddScoped<IBreakfastFoodContextDAO, BreakfastFoodContextDAO>();

// Add DB Context
builder.Services.AddDbContext<SampleContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
builder.Services.AddDbContext<BreakfastFoodContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));


var app = builder.Build();

// Use OpenAPI / Swagger
app.UseOpenApi();
app.UseSwaggerUi();

// Migrate DB
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var breakfastTable = services.GetRequiredService<BreakfastFoodContext>();
    breakfastTable.Database.Migrate();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
