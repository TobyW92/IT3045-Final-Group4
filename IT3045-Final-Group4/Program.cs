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
builder.Services.AddScoped<ITreeTableContextDAO, TreeTableContextDAO>();
builder.Services.AddScoped<ISampleContextDAO, SampleContextDAO>();
        // TEST
builder.Services.AddScoped<ITeamMemberContextDAO, TeamMemberContextDAO>();

// Add DB Context
builder.Services.AddDbContext<SampleContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
        // TEST
builder.Services.AddDbContext<TeamMemberContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"))); 

var app = builder.Build();

// Use OpenAPI / Swagger
app.UseOpenApi();
app.UseSwaggerUi();

// Migrate DB
using (var scope = app.Services.CreateScope())
{
    
    var services = scope.ServiceProvider;
    var db = services.GetRequiredService<SampleContext>();
    db.Database.Migrate(); 
    var teamDb = services.GetRequiredService<TeamMemberContext>();
teamDb.Database.Migrate(); // TEST 
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
