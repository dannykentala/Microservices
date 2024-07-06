using MailerSendApi;
using MicroEmail.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//----- BEGIN PERSONAL SERVICES -----//
builder.Services.AddDbContext<BaseContext> ( options => 
  options.UseMySql
  (
    // MySqlConnection: Alias use in appsettings.json to link mysql database
    builder.Configuration.GetConnectionString("MySqlConnection"),

    // 8.0.20-mysql: Version of Pomelo SQL
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
  )
);
// Repository injection
//----- Libraries injection
builder.Services.AddScoped<MailerSendService>();

//----- END PERSONAL SERVICES -----//

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
