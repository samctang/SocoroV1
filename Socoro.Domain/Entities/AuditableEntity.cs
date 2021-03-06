using System;

namespace Socoro.Domain.Entities
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }
    }
}
