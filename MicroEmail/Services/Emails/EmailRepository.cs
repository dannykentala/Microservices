using MailerSendApi;
using MailerSendApi.Models;
using MicroEmail.Data;
using MicroEmail.Models;

namespace MicroEmail.Services.Emails
{
  public class EmailRepository: IEmailRepository
  {
    private readonly BaseContext _context;
    private readonly MailerSendService _mailerSendService;
    

    public EmailRepository(BaseContext context, MailerSendService mailerSend)
    {
      _context = context;
      _mailerSendService = mailerSend;
    }

    public async Task<string> SendEmail(EmailLog email)
    {
      Email newEmail = new Email()
      {
        To = 
        [
          // new Recipent{Email = "handres41@outlook.com"}
          new Recipent{Email = email.Email}
        ],
        Subject = "Email from backend",
        Html = "This is an email generate from backend, but with Library"
      };

      string emailResult = await _mailerSendService.SendEmail(newEmail);

      SaveEmailLog(email);
      return "Email Created";
    }

    private void SaveEmailLog(EmailLog email)
    {
      _context.EmailLogs.Add(email);
      _context.SaveChanges();
    }
  }
}