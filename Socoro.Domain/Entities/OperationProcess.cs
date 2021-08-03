namespace Socoro.Domain.Entities
{
    public class OperationProcess : AuditableEntity
    {
        public int TypeId { get; set; }
        public string Status { get; set; }
        public int? OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
