using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socoro.Application.DTOs.Operation
{
    public class OperationProcessTypeResponse
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Process { get; set; }
        public string Description { get; set; }
    }
}
