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

namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class EditCustomerModel : PageModel
    {
        private UserService _userService;

        [BindProperty]
        public Models.Users.Customer Customer { get; set; }

        public int UserID { get; set; }

        public EditCustomerModel(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnGet(int id)
        {
            Customer = (Models.Users.Customer)_userService.GetCustomer(id);
            if (Customer == null) return RedirectToPage("../../Error");

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            UserID = _userService.SpecificCustomer(User.Identity.Name).UserID;
            Customer.UserID = UserID;
            _userService.UpdateCustomer(UserID, Customer);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Customer.Name)
            };
            var identity = new ClaimsIdentity(claims, "MyCookieAuth");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
            return RedirectToPage("Homepage");

        }
    }
}
