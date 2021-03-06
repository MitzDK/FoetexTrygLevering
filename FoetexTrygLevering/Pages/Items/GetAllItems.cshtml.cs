using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Items
{
    public class GetAllItemsModel : PageModel
    {
        public List<Item> Items { get; set; }
        private ItemService _itemService;

        [BindProperty] public int MinPrice { get; set; }
        [BindProperty] public int MaxPrice { get; set; }
        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public string SearchDescription { get; set; }

        public GetAllItemsModel(ItemService itemService)
        {
            _itemService = itemService;
        }

        public void OnGet()
        {
            Items = _itemService.GetAll();
        }

        public IActionResult OnPostNameSearch()
        {
            Items = _itemService.SearchByName(SearchString);
            return Page();
        }

        public IActionResult OnPostDescriptionSearch()
        {
            Items = _itemService.SearchByDescription(SearchDescription);
            return Page();
        }

        public IActionResult OnPostPriceFilter()
        {
            Items = _itemService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }
    }
}
