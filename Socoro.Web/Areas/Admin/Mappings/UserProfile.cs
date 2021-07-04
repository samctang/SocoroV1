using Socoro.Infrastructure.Identity.Models;
using Socoro.Web.Areas.Admin.Models;
using AutoMapper;

namespace Socoro.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}