using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Authentication;

namespace FoetexTrygLevering.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty] public string UserName { get; set; }
        [BindProperty] public string Password { get; set; }
        private User currentUser;
        private UserService _userService;

        public IndexModel(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            foreach (User user in _userService.GetAll())
            {
                if (user is Models.Users.Admin)
                {
                    if (UserName == user.Name)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Name),
                            new Claim("UserID", user.UserID.ToString())
                        };
                        var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                        return RedirectToPage("Users/Admin/Homepage");
                    }
                }
                if (user is Models.Users.DeliveryDriver)
                {
                    if (UserName == user.Name)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Name),
                            new Claim("UserID", user.UserID.ToString())
                        };
                        var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                        return RedirectToPage("Users/DeliveryDriver/Homepage");
                    }
                }
                if (user is Models.Users.Customer)
                {
                    if (UserName == user.Name)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Name),
                            new Claim("UserID", user.UserID.ToString())
                        };
                        var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                        return RedirectToPage("Users/Customer/Homepage");
                    }
                }
            }
            return Page();
        }
    }
}
