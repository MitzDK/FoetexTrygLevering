using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;

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

        public IActionResult OnPost()
        {
            foreach (User user in _userService.GetAll())
            {
                if (user is Models.Users.Admin)
                {
                    if (UserName == user.Name)
                    {
                        currentUser = user;
                        return RedirectToPage("Items/GetAllItems");
                    }
                }
                if (user is Models.Users.DeliveryDriver)
                {
                    if (UserName == user.Name)
                    {
                        currentUser = user;
                        return RedirectToPage("Items/GetAllItems");
                    }
                }
                if (user is Models.Users.Customer)
                {
                    if (UserName == user.Name)
                    {
                        currentUser = user;
                        return RedirectToPage("Items/GetAllItems");
                    }
                }
            }
            return Page();
        }
    }
}
