using MailerSendApi;
using MailerSendApi.Models;
using MicroEmail.Models;
using MicroEmail.Services.Emails;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApi.Controllers
{
  [Route("api/mail")]
  [ApiController]
  public class MailerSendController: ControllerBase
  {
    private readonly IEmailRepository _emailRepository;
    public MailerSendController(IEmailRepository emailRepository)
    {
      _emailRepository = emailRepository;
    }

    [HttpPost]
    public async Task<string> SendEmail(EmailLog email)
    {
      return await _emailRepository.SendEmail(email);
    }
  }
}