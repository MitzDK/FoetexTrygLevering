using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class HomepageModel : PageModel
    {
        public Models.Users.Customer Customer { get; set; }
        public List<User> Users { get; set; }
        private UserService _userService;

        public HomepageModel(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult OnGet()
        {

            //foreach(User user in )
            return Page();
        }
    }
}
