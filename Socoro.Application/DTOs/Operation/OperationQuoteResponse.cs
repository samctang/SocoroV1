namespace Socoro.Application.DTOs.Operation
{
    public class OperationQuoteResponse
    {
        public int Id { get; set; }
        public int Profit { get; set; }
        public int Documentation { get; set; }
        public int FF { get; set; }
        public int VGM { get; set; }
        public int Inland { get; set; }
        public int Others { get; set; }
        public string Explanation { get; set; }
        public int OperationId { get; set; }
    }
}
