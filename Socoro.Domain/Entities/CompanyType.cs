﻿using AspNetCoreHero.Abstractions.Domain;

namespace Socoro.Domain.Entities
{
    public class CompanyType : AuditableEntity
    {
        public string Description { get; set; }
    }
}
