using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Order;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.DeliveryDriver
{
    public class OrderHistorikModel : PageModel
    {
        public Order Order { get; set; }
        public Models.Users.DeliveryDriver Driver { get; set; }
        private UserService _userService;
        private OrderService _orderService;
        private ItemService _itemService;

        public OrderHistorikModel(UserService userService, OrderService orderService, ItemService itemService)
        {
            _userService = userService;
            _orderService = orderService;
            _itemService = itemService;
        }
        public void OnGet(int id)
        {
            Driver = _userService.SpecificDeliveryDriver(User.Identity.Name);
            Order = _orderService.SearchPending(id);
            Driver.AddOrderToHistory(Order);
            _orderService.DeletePendingOrder(Order);
        }
    }
}
