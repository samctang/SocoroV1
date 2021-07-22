using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class OperationProcessType : AuditableEntity
    {
        public int TypeId { get; set; }
        public string Process { get; set; }
        public string Description { get; set; }
    }
}
