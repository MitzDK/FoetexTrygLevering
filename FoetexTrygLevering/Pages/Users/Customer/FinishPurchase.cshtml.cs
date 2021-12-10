using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Helpers;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Models.Order;
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
        private OrderService _orderService;

        public double TotalPrice { get; set; }

        public FinishPurchaseModel(UserService userService, ItemService itemService, OrderService orderService)
        {
            _userService = userService;
            _itemService = itemService;
            _orderService = orderService;
        }

        public void OnGet()
        {
            Customer = _userService.SpecificCustomer(User.Identity.Name);
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
            if (ShoppingCart != null && ShoppingCart.Count != 0)
            {
                TotalPrice = ShoppingCart.Sum(i => i.Item.Price * i.Quantity);
            }
        }
        public IActionResult OnPost()
        {
            Customer = _userService.SpecificCustomer(User.Identity.Name);
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
            Order o1 = new Order(Customer, new List<ShoppingItem>(ShoppingCart));
            o1 = _orderService.NewDoneOrder(o1);
            ShoppingCart.Clear();
            HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            return RedirectToPage("ConfirmationPurchase", "Forward", o1);
        }
        public IActionResult OnGetPickUp()
        {
            Customer = _userService.SpecificCustomer(User.Identity.Name);
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
            Order o1 = new Order(Customer, new List<ShoppingItem>(ShoppingCart));
            o1 = _orderService.NewDoneOrder(o1);
            ShoppingCart.Clear();
            HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            return RedirectToPage("ConfirmationPurchase", "Forward", o1);
        }
    }
}
