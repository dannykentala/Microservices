using System.ComponentModel.DataAnnotations;

namespace MicroEmail.Models
{
  public class EmailLog
  {
    public int Id {get; set;}

    [Required]
    public string Email {get; set;}

    [Required]
    public string UserId {get; set;}
  }
}