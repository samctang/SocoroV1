using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationViewModel
    {
        public int Id { get; set; }
        [HiddenInput]
        public string OperationNo { get; set; }
        [Required, Display(Name = "Operation Type")]
        public int TypeId { get; set; }
        [Required, Display(Name = "Destination Agent")]
        public string Agent { get; set; }
        [Required]
        public string Shipper { get; set; }
        [Required]
        public string Consignee { get; set; }
        [Display(Name = "Agent Reference Number")]
        public string AgentRefNo { get; set; }
        [Display(Name = "Shipper Reference Number")]
        public string ShipperRefNo { get; set; }
        [Display(Name = "Consignee Reference Number")]
        public string ConsigneeRefNo { get; set; }
        [Required, Display(Name = "Port of Loading (PoL)")]
        public string PoL { get; set; }
        [Required, Display(Name = "Port of Discharge (PoD)")]
        public string PoD { get; set; }
        [Required, Display(Name = "Origin Address Line 1")]
        public string OriginAddr1 { get; set; }
        [Display(Name = "Origin Address Line 2")]
        public string OriginAddr2 { get; set; }
        [Required, Display(Name = "Origin City")]
        public string OriginCity { get; set; }
        [Required, Display(Name = "Origin State")]
        public string OriginState { get; set; }
        [Required, Display(Name = "Origin Zip Code")]
        public string OriginZip { get; set; }
        [Required, Display(Name = "Origin Country")]
        public string OriginCountry { get; set; }
        [Display(Name = "Destination Address Line 1")]
        public string DestinationAddr1 { get; set; }
        [Display(Name = "Destination Address Line 2")]
        public string DestinationAddr2 { get; set; }
        [Required, Display(Name = "Destination City")]
        public string DestinationCity { get; set; }
        [Display(Name = "Destination State")]
        public string DestinationState { get; set; }
        [Display(Name = "Destination Zip Code")]
        public string DestinationZip { get; set; }
        [Display(Name = "Destination Country")]
        public string DestinationCountry { get; set; }
        public int Progress { get; set; }
        public string Status { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int CompanyId { get; set; }
    }
}
