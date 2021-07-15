using AspNetCoreHero.Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Socoro.Domain.Entities
{
    public class Carrier : AuditableEntity
    {
        public int TypeId { get; set; }
        public string CarrierName { get; set; }
        public string Phone { get; set; }
        public string PhoneExt { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhyAddr1 { get; set; }
        public string PhyAddr2 { get; set; }
        public string PhyCity { get; set; }
        public string PhyState { get; set; }
        public string PhyZip { get; set; }
        public int DirectConnection { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
