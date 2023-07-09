using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace PasswordManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Password> Passwords { get; set; }
        
    }

}
