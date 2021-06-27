using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Socoro.Model.Core;

namespace Socoro.Model.Entities
{
    public class OperationView : IIdentifier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int ProcessId { get; set; }
        public string Status { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
