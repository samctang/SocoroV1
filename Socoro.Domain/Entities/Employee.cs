using System;
using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public string EmployerId { get; set; }
        public string UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
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
        public DateTime? DoB { get; set; }
        public char Gender { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
