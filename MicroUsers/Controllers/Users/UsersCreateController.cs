using Microsoft.AspNetCore.Mvc;
using MicroUsers.Models;
using MicroUsers.Services.Users;

namespace MicroUsers.Controllers.Users
{
  [Route("api/users")]
  [ApiController]
  public class UsersCreateController: ControllerBase
  {
    private readonly IUsersRepository _usersRepository;
    public UsersCreateController(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    [HttpPost]
    public User Create([FromBody] User user)
    {
      return _usersRepository.Create(user);
    }
  }
}