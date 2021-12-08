using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Helpers;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class FinishPurchaseModel : PageModel
    {
        public Models.Users.Customer Customer { get; set; }
        public List<ShoppingItem> ShoppingCart { get; set; }
        private UserService _userService;
        private ItemService _itemService;


        public FinishPurchaseModel(UserService userService, ItemService itemService)
        {
            _userService = userService;
            _itemService = itemService;

        }

        public void OnGet()
        {
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
        }
    }
}
