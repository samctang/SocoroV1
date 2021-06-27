using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.ViewModels
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
