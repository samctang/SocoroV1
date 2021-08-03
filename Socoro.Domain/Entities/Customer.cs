
namespace Socoro.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public int TypeId { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string ContactPhone { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhyAddr1 { get; set; }
        public string PhyAddr2 { get; set; }
        public string PhyCity { get; set; }
        public string PhyState { get; set; }
        public string PhyZip { get; set; }
        public string DocumentalEmail { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
