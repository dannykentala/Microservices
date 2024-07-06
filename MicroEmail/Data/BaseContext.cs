using MailerSendApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroEmail.Data
{
  // BaseContext
  public class BaseContext: DbContext
  {
    public BaseContext(DbContextOptions<BaseContext> options): base(options)
    { }

    // Remember that model is singular, and table is plural
    // DbSet<Model> SqlTable
    public DbSet<Recipent> Recipents {get; set;}
  }
}