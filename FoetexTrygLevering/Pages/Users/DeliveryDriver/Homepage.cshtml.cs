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
    public class HomepageModel : PageModel
    {
        public Models.Users.DeliveryDriver Driver { get; set; }
        public List<Order> PendingOrders { get; set; }

        private UserService _userService;
        private OrderService _orderService;
        private ItemService _itemService;

        public HomepageModel(UserService userService, OrderService orderService, ItemService itemService)
        {
            _userService = userService;
            _orderService = orderService;
            _itemService = itemService;
        }
        public void OnGet()
        {
            Driver = _userService.SpecificDeliveryDriver(User.Identity.Name);
            PendingOrders = _orderService.GetAllPending();
        }

        public void OnPostSort()
        {
            Driver = _userService.SpecificDeliveryDriver(User.Identity.Name);
            PendingOrders = _orderService.GetAllPending();
            _orderService.SortByPostalCode(PendingOrders);
        }
    }
}
