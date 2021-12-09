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

        [BindProperty] public Models.Users.DeliveryDriver DeliveryDriver { get; set; }
        public int UserID { get; set; }


        public DeleteDeliveryDriver(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnGet(int id)
        {
            DeliveryDriver = (Models.Users.DeliveryDriver)_userService.GetDeliveryDriver(id);
            if (DeliveryDriver == null) return RedirectToPage("../../Error");

            return Page();
        }

        public IActionResult OnPost()
        {

            UserID = _userService.SpecificDeliveryDriver(User.Identity.Name).UserID;
            DeliveryDriver.UserID = UserID;
            _userService.Delete(UserID);

            return RedirectToPage("../../LogOut");

        }
    }
}