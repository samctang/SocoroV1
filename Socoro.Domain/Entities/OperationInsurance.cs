namespace Socoro.Domain.Entities
{
    public class OperationInsurance : AuditableEntity
    {
        public int Value { get; set; }
        public int Freight { get; set; }
        public int Duties { get; set; }
        public int OtherCosts { get; set; }
        public int VoluntaryCoverage { get; set; }
        public int LostProfit { get; set; }
        public int? OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
