using Socoro.Application.Constants;
using Socoro.Application.Enums;
using Socoro.Infrastructure.Identity.Models;
using Socoro.Web.Abstractions;
using Socoro.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Socoro.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : BaseController<UserController>
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [Authorize(Policy = Permissions.Users.View)]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> LoadAll()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var allUsersExceptCurrentUser = await _userManager.Users.Where(a => a.Id != currentUser.Id).ToListAsync();
            var model = _mapper.Map<IEnumerable<UserViewModel>>(allUsersExceptCurrentUser);
            return PartialView("_ViewAll", model);
        }

        public async Task<IActionResult> OnGetCreate()
        {
            return new JsonResult(new { isValid = true, html = await _viewRenderer.RenderViewToStringAsync("_Create", new UserViewModel()) });
        }

        [HttpPost]
        public async Task<IActionResult> OnPostCreate(UserViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                MailAddress address = new MailAddress(userModel.Email);
                string userName = address.User;
                var user = new ApplicationUser
                {
                    UserName = userName,
                    Email = userModel.Email,
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    EmailConfirmed = true,
                };
                var result = await _userManager.CreateAsync(user, userModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Roles.KAM.ToString());
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                    var allUsersExceptCurrentUser = await _userManager.Users.Where(a => a.Id != currentUser.Id).ToListAsync();
                    var users = _mapper.Map<IEnumerable<UserViewModel>>(allUsersExceptCurrentUser);
                    var htmlData = await _viewRenderer.RenderViewToStringAsync("_ViewAll", users);
                    return new JsonResult(new { isValid = true, html = htmlData });
                }
                var html = await _viewRenderer.RenderViewToStringAsync("_Create", userModel);
                return new JsonResult(new { isValid = false, html = html });
            }
            return default;
        }
    }
}