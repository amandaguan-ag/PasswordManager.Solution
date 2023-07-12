using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PasswordManager.Models
{
    public class PasswordManagerContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Password> Passwords { get; set; }

        public PasswordManagerContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Passwords)
                .WithOne(p => p.User);
        }
    }
}
