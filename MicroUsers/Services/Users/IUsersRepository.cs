using Microsoft.AspNetCore.Mvc;
using MicroUsers.Models;

namespace MicroUsers.Services.Users
{
  public interface IUsersRepository
  {
    User Create(User users);
  }
}