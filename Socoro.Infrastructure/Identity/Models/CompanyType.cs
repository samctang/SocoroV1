using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Infrastructure.Identity.Models
{
    public class CompanyType : AuditableEntity
    {
        public string Description { get; set; }
    }
}
