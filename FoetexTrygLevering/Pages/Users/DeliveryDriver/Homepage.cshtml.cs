using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.DeliveryDriver
{
    public class HomepageModel : PageModel
    {
        public Models.Users.DeliveryDriver Driver { get; set; }
        public List<Models.Users.DeliveryDriver> Drivers { get; set; }
        private UserService _userService;

        public HomepageModel(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
