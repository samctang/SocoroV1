using System;
using System.Collections.Generic;
namespace Socoro.Domain.Entities
{
    public class Operation : AuditableEntity
    {
        public string OperationNo { get; set; }
        public int TypeId { get; set; }
        public int Agent { get; set; }
        public int Shipper { get; set; }
        public int Consignee { get; set; }
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
        public int? Carrier { get; set; }
        public List<OperationProcess> OperationProcesses { get; set; }
        public int Progress { get; set; }
        public string Status { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
