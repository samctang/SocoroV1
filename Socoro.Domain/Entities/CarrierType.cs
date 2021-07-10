using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class CarrierType : AuditableEntity
    {
        public string Description { get; set; }
    }
}
