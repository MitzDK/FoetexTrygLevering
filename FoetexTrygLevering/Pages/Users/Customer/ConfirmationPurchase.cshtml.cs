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
    public class ConfirmationPurchaseModel : PageModel
    {
        public Models.Users.Customer Customer { get; set; }
        public Models.Order.Order Order { get; set; }
        private UserService _userService;
        private ItemService _itemService;
        private OrderService _orderService;
        public int Id { get; set; }
        public string CurrentTime { get; set; }

        public ConfirmationPurchaseModel(UserService userService, ItemService itemService, OrderService orderService)
        {
            _userService = userService;
            _itemService = itemService;
            _orderService = orderService;

        }
        public void OnGetForward(Order ord)
        {
            Order = ord;
            Order.ShoppedItems = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
            Customer = _userService.SpecificCustomer(User.Identity.Name);
            CurrentTime = $"{DateTime.Now.ToString("dd/MM/yy")}: {DateTime.Now.Hour}:{DateTime.Now.Minute + 30}";
        }
    }
}
