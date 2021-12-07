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
public class DeleteItemModel : PageModel
    {
        private ItemService _itemService;
        private Item _searchedItem;
        public Item SearchedItem { get; private set; }

        public DeleteItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        public IActionResult OnGet(int id)
        {
            _searchedItem = _itemService.Search(id);
            SearchedItem = _searchedItem;
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _itemService.Delete(id);
            return RedirectToPage("Homepage");
        }
    }
}
