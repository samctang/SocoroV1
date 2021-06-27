using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.ViewModels
{
    public class OperationProcess
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }
    }
}
