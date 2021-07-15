using AspNetCoreHero.Abstractions.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Socoro.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public int TypeId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyName2 { get; set; }
        public string CompanyDBA { get; set; }
        public string CompanyDBA2 { get; set; }
        public string EIN { get; set; }
        public string PhyAddr1 { get; set; }
        public string PhyAddr2 { get; set; }
        public string PhyCity { get; set; }
        public string PhyState { get; set; }
        public string PhyZip { get; set; }
        public string MailAddr1 { get; set; }
        public string MailAddr2 { get; set; }
        public string MailCity { get; set; }
        public string MailState { get; set; }
        public string MailZip { get; set; }
        public int? NoEmployees { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Operation> Operations { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Carrier> Carriers { get; set; }
    }
}
