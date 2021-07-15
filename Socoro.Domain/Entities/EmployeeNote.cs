using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class EmployeeNote : AuditableEntity
    {
        public string Description { get; set; }
        public Employee Employee { get; set; }
    }
}
