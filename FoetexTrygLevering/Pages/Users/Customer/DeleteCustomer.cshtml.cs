using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class DeleteCustomerModel : PageModel
    {
        private UserService _userService;

        [BindProperty] public Models.Users.Customer Customer { get; set; }
        public int UserID { get; set; }


        public DeleteCustomerModel(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnGet(int id)
        {
            Customer = (Models.Users.Customer)_userService.GetCustomer(id);
            if (Customer == null) return RedirectToPage("../../Error");

            return Page();
        }

        public IActionResult OnPost()
        {
            
            UserID = _userService.SpecificCustomer(User.Identity.Name).UserID;
            Customer.UserID = UserID;
            _userService.Delete(UserID);
            
            return RedirectToPage("../../LogOut");

        }
    }
}

