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
        private int _currentHour;
        private int _currentMinute;
        private Random rnd = new Random();

        public ConfirmationPurchaseModel(UserService userService, ItemService itemService, OrderService orderService)
        {
            _userService = userService;
            _itemService = itemService;
            _orderService = orderService;
        }

        public void CheckTime()
        {
            if (_currentMinute >= 60)
            {
                if (_currentHour != 23)
                {
                    _currentHour += 1;
                    _currentMinute -= 60;
                }
                else if (_currentHour == 23)
                {
                    _currentHour = 0;
                    _currentMinute -= 60;
                }
            }

            if (_currentHour < 10)
            {
                CurrentTime = $"0{_currentHour}";
            }
            else
            {
                CurrentTime = $"{_currentHour}";
            }

            if (_currentMinute < 10)
            {
                CurrentTime += $":0{_currentMinute}";
            }
            else
            {
                CurrentTime += $":{_currentMinute}";
            }
        }

        public void OnGetForward(Order ord)
        {
            _currentHour = DateTime.Now.Hour;
            _currentMinute = DateTime.Now.Minute + rnd.Next(25, 60);
            CheckTime();
            if (ord.IsDelivered == false)
            {
                Order = _orderService.SearchPending(ord.OrderID);
            }
            else
            {
                Order = _orderService.Search(ord.OrderID);
            }

            Customer = _userService.SpecificCustomer(User.Identity.Name);
        }
    }
}
