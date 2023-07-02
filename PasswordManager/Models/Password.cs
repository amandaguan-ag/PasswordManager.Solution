using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PasswordManager.Models
{
  public class Password
  {
    public int PasswordId { get; set; }
    public string Site { get; set; }
    public string Username { get; set; }
    public string SitePassword { get; set; }
  }
}
