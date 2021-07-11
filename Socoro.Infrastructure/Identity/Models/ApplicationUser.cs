using Microsoft.AspNetCore.Identity;

namespace Socoro.Infrastructure.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public bool IsActive { get; set; } = false;
        public virtual Employee Employee { get; set; }
    }
}