using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
    public class CreateBeverageModel : PageModel
    {
        private ItemService _itemService;

        [BindProperty] public Models.Items.Beverage Beverage { get; set; }

        public CreateBeverageModel(ItemService itemService)
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

            _itemService.Add(Beverage);
            return RedirectToPage("Homepage");
        }
    }
}
