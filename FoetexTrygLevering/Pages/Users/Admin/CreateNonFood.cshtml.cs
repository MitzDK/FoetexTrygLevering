using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
    public class CreateNonFoodModel : PageModel
    {
        private ItemService _itemService;

        [BindProperty] public Models.Items.NonFood NonFood { get; set; }

        public CreateNonFoodModel(ItemService itemService)
        {
            _itemService = itemService;
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

            _itemService.Add(NonFood);
            return RedirectToPage("Homepage");
        }
    }
}
