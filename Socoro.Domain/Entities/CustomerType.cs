using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class CustomerType : AuditableEntity
    {
        public string Description { get; set; }
    }
}
