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
        public class HomepageModel : PageModel
    {
        private ItemService _itemService;
        private UserService _userSerivce;

        public List<Item> Items { get; set; }

        [BindProperty] public int MinPrice { get; set; }
        [BindProperty] public int MaxPrice { get; set; }
        [BindProperty] public string SearchName { get; set; }
        [BindProperty] public string SearchDescription { get; set; }

        public HomepageModel(ItemService itemService)
        {
            _itemService = itemService;
        }

        public void OnGet()
        {
            Items = _itemService.GetAll();
        }

        public IActionResult OnPostFilterPrice()
        {
            Items = _itemService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }
        public IActionResult OnPostNameSearch()
        {
            Items = _itemService.SearchByName(SearchName);
            return Page();
        }

        public IActionResult OnPostSearchDescription()
        {
            Items = _itemService.SearchByDescription(SearchDescription);
            return Page();
        }

    }
}
