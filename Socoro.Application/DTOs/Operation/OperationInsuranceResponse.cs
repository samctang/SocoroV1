namespace Socoro.Application.DTOs.Operation
{
    public class OperationInsuranceResponse
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int Freight { get; set; }
        public int Duties { get; set; }
        public int OtherCosts { get; set; }
        public int VoluntaryCoverage { get; set; }
        public int LostProfit { get; set; }
        public int OperationId { get; set; }
    }
}
