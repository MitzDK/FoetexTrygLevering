using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.DeliveryDriver
{
    public class EditDeliveryDriverModel : PageModel
    {
        private UserService _userService;

        [BindProperty]
        public Models.Users.DeliveryDriver Driver { get; set; }

        public int UserID { get; set; }

        public EditDeliveryDriverModel(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnGet(int id)
        {
            Driver = _userService.SpecificDeliveryDriver(User.Identity.Name);
            if (Driver == null) return RedirectToPage("../../Error");

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            UserID = _userService.SpecificDeliveryDriver(User.Identity.Name).UserID;
            Driver.UserID = UserID;
            _userService.UpdateDeliveryDriver(UserID, Driver); //UpdateDeliveryDriver skal implementeres

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Driver.Name)
            };
            var identity = new ClaimsIdentity(claims, "MyCookieAuth");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
            return RedirectToPage("Homepage");

        }
    }
}