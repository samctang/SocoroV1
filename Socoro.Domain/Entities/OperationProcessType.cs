using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socoro.Domain.Entities
{
    public class OperationProcessType : AuditableEntity
    {
        public int TypeId { get; set; }
        public string Description { get; set; }
    }
}
