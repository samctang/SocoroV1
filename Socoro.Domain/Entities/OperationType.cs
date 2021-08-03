namespace Socoro.Domain.Entities
{
    public class OperationType : AuditableEntity
    {
        public string Description { get; set; }
        public string Freight { get; set; }
    }
}
