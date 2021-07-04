using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class OperationType : AuditableEntity
    {
        public string Description { get; set; }
    }
}
