// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PasswordManager.Models
{
  public class PasswordManagerContext : DbContext
  {
    public DbSet<Password> Passwords { get; set; }

    public PasswordManagerContext(DbContextOptions options) : base(options) { }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    //     {
    //         base.OnModelCreating(modelBuilder);

    //         modelBuilder.Entity<Password>(entity =>
    //         {
    //             entity.Property(e => e.SiteEmail)
    //                   .IsRequired()
    //                   .HasMaxLength(256)
    //                   .HasAnnotation("RegularExpression", "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$")
    //                   .HasAnnotation("MaxLength", 256);
    //         });
    //     }
    }
}
