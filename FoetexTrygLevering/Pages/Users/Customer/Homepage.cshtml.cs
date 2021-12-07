using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class HomepageModel : PageModel
    {
        public List<Models.Items.Item> ItemList { get; set; }
        [BindProperty] public int MenuChoice { get; set; }
        public Models.Users.Customer Customer { get; set; }
        public List<Item> ShoppingCart { get; set; }

        private UserService _userService;
        private ItemService _itemService;

        public HomepageModel(UserService userService, ItemService itemService)
        {
            _userService = userService;
            _itemService = itemService;
            
        }

        public void OnGet()
        {
            ItemList = _itemService.GetAll();
            Customer = _userService.SpecificCustomer(User.Identity.Name);
        }

        public void OnPost()
        {
            switch (MenuChoice)
            {
                case 1:
                    ItemList = _itemService.GetAll();
                    break;
                case 2:
                    ItemList = _itemService.GetAllFood();
                    break;
                case 3:
                    ItemList = _itemService.GetAllBeverages();
                    break;
                case 4:
                    ItemList = _itemService.GetAllNonFoods();
                    break;
            }
        }
        public IActionResult OnGetUserName()
        {
            ItemList = _itemService.GetAll();
            
            return Page();
        }

    }
}
