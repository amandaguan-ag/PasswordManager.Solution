// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PasswordManager.Models
{
  public class PasswordManagerContext : DbContext
  {
    public DbSet<Password> Passwords { get; set; }

    public PasswordManagerContext(DbContextOptions options) : base(options) { }
  }
}
