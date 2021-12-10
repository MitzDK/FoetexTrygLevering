using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.DeliveryDriver
{
    public class DeleteDeliveryDriver : PageModel
    {
        private UserService _userService;

        [BindProperty] public Models.Users.DeliveryDriver Driver { get; set; }
        public int UserID { get; set; }


        public DeleteDeliveryDriver(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnGet(int id)
        {
            Driver = _userService.SpecificDeliveryDriver(User.Identity.Name);
            if (Driver == null) return RedirectToPage("../../Error");

            return Page();
        }

        public IActionResult OnPost()
        {

            UserID = _userService.SpecificDeliveryDriver(User.Identity.Name).UserID;
            Driver.UserID = UserID;
            _userService.Delete(UserID);

            return RedirectToPage("../../LogOut");

        }
    }
}