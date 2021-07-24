using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationProcessTypeViewModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Process { get; set; }
        public string Description { get; set; }
    }
}
