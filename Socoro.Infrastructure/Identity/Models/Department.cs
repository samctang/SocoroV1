using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Infrastructure.Identity.Models
{
    public class Department : AuditableEntity
    {
        public string Description { get; set; }
    }
}
