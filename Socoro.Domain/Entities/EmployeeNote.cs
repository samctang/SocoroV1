using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class EmployeeNote : AuditableEntity
    {
        public int EmployeeId { get; set; }
        public string Description { get; set; }
    }
}
