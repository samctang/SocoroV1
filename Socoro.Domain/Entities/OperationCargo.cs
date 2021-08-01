﻿using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socoro.Domain.Entities
{
    public class OperationCargo : AuditableEntity
    {
        public string LoadingAddress { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime LoadingDate { get; set; }
        public TimeSpan LoadingTime { get; set; }
        public string Reference { get; set; }
        public int EIN { get; set; }
        public bool Bonded { get; set; }
        public bool Propelled { get; set; }
        public int NoContainers { get; set; }
        public List<Container> Containers { get; set; }
        public int? OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
