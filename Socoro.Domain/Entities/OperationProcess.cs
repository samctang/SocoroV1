using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class OperationProcess : AuditableEntity
    {
        public int TypeId { get; set; }
        public string Description { get; set; }
    }
}
