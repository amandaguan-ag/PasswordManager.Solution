using System.ComponentModel.DataAnnotations;

namespace PasswordManager.Models
{
    public class Password
    {
        public int PasswordId { get; set; }

        public ApplicationUser User { get; set; }

        public string Site { get; set; }
        public string SiteUsername { get; set; }
        public string SiteEmail { get; set; }
        public string SitePassword { get; set; }
    }
}
