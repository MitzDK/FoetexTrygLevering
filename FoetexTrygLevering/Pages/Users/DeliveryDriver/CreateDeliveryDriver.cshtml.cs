using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.DeliveryDriver
{
    public class CreateDeliveryDriverModel : PageModel
    {
        private UserService _userService;
        [BindProperty]
        public Models.Users.DeliveryDriver DeliveryDriver { get; set; }

        public CreateDeliveryDriverModel(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.Add(DeliveryDriver);
            return RedirectToPage("GetAllUsers");
        }
    }
}
