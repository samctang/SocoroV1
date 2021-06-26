using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Web.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Agent { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string AgentRefNo { get; set; }
        public string ShipperRefNo { get; set; }
        public string ConsigneeRefNo { get; set; }
        public string PoL { get; set; }
        public string PoD { get; set; }
        public string Addr { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string DestinationAddr { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationState { get; set; }
        public string DestinationZip { get; set; }
        public string DestinationCountry { get; set; }
    }
}
