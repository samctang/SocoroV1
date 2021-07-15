using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.Shared.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Email { get; set; }
        [Required, Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required, Display(Name = "Contact Phone")]
        public string ContactPhone { get; set; }
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
        [Display(Name = "Documental Email")]
        public string DocumentalEmail { get; set; }
        public int CompanyId { get; set; }
    }
}
