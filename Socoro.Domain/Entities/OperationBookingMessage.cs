namespace Socoro.Domain.Entities
{
    public class OperationBookingMessage : AuditableEntity
    {
        public Employee Employee { get; set; }
        public Carrier Carrier { get; set; }
        public string Message { get; set; }
    }
}
