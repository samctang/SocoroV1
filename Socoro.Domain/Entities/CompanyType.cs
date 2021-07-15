using AspNetCoreHero.Abstractions.Domain;
using System.Collections.Generic;

namespace Socoro.Domain.Entities
{
    public class CompanyType : AuditableEntity
    {
        public string Description { get; set; }
    }
}
