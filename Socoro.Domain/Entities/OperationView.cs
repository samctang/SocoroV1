using System;
using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class OperationView : AuditableEntity
    {
        public int OperationId { get; set; }
        public int ProcessId { get; set; }
        public string Status { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
