using System;

namespace Socoro.Application.Features.Operations.Queries.GetAllPaged
{
    public class GetAllOperationsResponse
    {
        public int Id { get; set; }
        public string OperationNo { get; set; }
        public string Agent { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string AgentRefNo { get; set; }
        public string ShipperRefNo { get; set; }
        public string ConsigneeRefNo { get; set; }
        public string PoL { get; set; }
        public string PoD { get; set; }
        public string OriginAddr1 { get; set; }
        public string OriginAddr2 { get; set; }
        public string OriginCity { get; set; }
        public string OriginState { get; set; }
        public string OriginZip { get; set; }
        public string OriginCountry { get; set; }
        public string DestinationAddr1 { get; set; }
        public string DestinationAddr2 { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationState { get; set; }
        public string DestinationZip { get; set; }
        public string DestinationCountry { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}