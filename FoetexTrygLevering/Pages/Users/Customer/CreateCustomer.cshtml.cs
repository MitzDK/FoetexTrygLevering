using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class CreateCustomerModel : PageModel
    {
        private UserService _userService;
        [BindProperty]
        public Models.Users.Customer Customer { get; set; }

        public CreateCustomerModel(UserService userService)
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
            _userService.Add(Customer);
            return RedirectToPage("Homepage");
        }
    }
}
