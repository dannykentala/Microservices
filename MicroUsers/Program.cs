using Microsoft.EntityFrameworkCore;
using MicroUsers.Data;
using MicroUsers.Services.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//----- BEGIN PERSONAL SERVICES -----//
builder.Services.AddDbContext<BaseContext>(options =>
  options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
  new MySqlServerVersion(new Version(8, 0, 20))));

// Repository injection
builder.Services.AddScoped<IUsersRepository, UsersRepository>();

//----- END PERSONAL SERVICES -----//

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
