using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.Shared.Models
{
    public class CarrierViewModel
    {
        public int Id { get; set; }
        [Required, Display(Name = "Carrier Type")]
        public int TypeId { get; set; }
        [Required, Display(Name = "Carrier Name")]
        public string CarrierName { get; set; }
        public string Phone { get; set; }
        [Display(Name = "Ext.")]
        public string PhoneExt { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Address Line 1")]
        public string PhyAddr1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string PhyAddr2 { get; set; }
        [Display(Name = "City")]
        public string PhyCity { get; set; }
        [Display(Name = "State")]
        public string PhyState { get; set; }
        [Display(Name = "Zip Code")]
        public string PhyZip { get; set; }
        [Required, Display(Name = "Direct Connection")]
        public int DirectConnection { get; set; }
        public int CompanyId { get; set; }
    }
}
