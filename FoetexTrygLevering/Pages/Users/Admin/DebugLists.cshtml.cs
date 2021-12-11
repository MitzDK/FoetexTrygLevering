using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Order;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
    public class DebugListsModel : PageModel
    {
        public List<Order> PendingOrders{ get; set; }
        public List<Order> DoneOrders{ get; set; }
        private UserService _userService;
        private OrderService _orderService;
        private ItemService _itemService;

        public DebugListsModel(UserService userService, OrderService orderService, ItemService itemService)
        {
            _userService = userService;
            _orderService = orderService;
            _itemService = itemService;
        }
        public void OnGet()
        {
            PendingOrders = _orderService.GetAllPending();
            DoneOrders = _orderService.GetAll();
        }
    }
}
