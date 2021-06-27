using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.ViewModels
{
    public class EmployeeNote
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
    }
}
