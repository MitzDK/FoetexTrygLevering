using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class EditCustomerModel : PageModel
    {
        private UserService _userService;

        [BindProperty]
        public Models.Users.Customer Customer { get; set; }

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

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            } 
            _userService.UpdateCustomer(Customer); 

            return RedirectToPage("Homepage");

        }
    }
}
