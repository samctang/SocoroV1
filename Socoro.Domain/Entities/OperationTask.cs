
using System;

namespace Socoro.Domain.Entities
{
    public class OperationTask : AuditableEntity
    {
        public string Note { get; set; }
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }
        public int? OperationProcessId { get; set; }
        public OperationProcess OperationProcess { get; set; }
    }
}
