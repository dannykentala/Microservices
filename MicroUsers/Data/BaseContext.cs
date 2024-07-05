using Microsoft.EntityFrameworkCore;
using MicroUsers.Models;

namespace MicroUsers.Data
{
  public class BaseContext: DbContext
  {
    public BaseContext(DbContextOptions<BaseContext> options): base(options)
    { }

    public DbSet<User> Users {get; set;}
  }
}