using MailerSendApi.Models;
using MicroEmail.Models;

namespace MicroEmail.Services.Emails
{
  public interface IEmailRepository
  {
    Task<string> SendEmail(EmailLog email);
  }
}