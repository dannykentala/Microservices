using MicroUsers.Data;
using MicroUsers.Models;

namespace MicroUsers.Services.Users
{
  public class UsersRepository: IUsersRepository
  {
    private readonly BaseContext _context;

    public UsersRepository (BaseContext context)
    {
      _context = context;  
    }

    public User Create(User user)
    {
      var data = _context.Users.Add(user);
      _context.SaveChanges();
      return data.Entity;
    }
  }

}