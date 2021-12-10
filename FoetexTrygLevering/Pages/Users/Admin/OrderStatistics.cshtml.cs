using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Models.Order;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
    public class OrderStatisticsModel : PageModel
    {
        public List<Models.Users.Customer> CustomerList{ get; set; }
        public List<Order> TotalOrders { get; set; } = new List<Order>();
        public List<Order> OldOrders { get; set; } = new List<Order>();
        public List<Order> PendingOrders { get; set; } = new List<Order>();
        public List<ShoppingItem> ShoppedItems { get; set; } = new List<ShoppingItem>();

        
        
        
        private ItemService _itemService;
        private OrderService _orderService;
        private UserService _userService;

        public OrderStatisticsModel(ItemService itemService, OrderService orderService, UserService userService)
        {
            _itemService = itemService;
            _orderService = orderService;
            _userService = userService;
        }

        public void OnGet()
        {
            CombineOrders();
            GetAllShoppedItems();
        }

        public void CombineOrders()
        {
            OldOrders = _orderService.GetAll();
            PendingOrders = _orderService.GetAllPending();
            foreach (Order ord in OldOrders)
            {
                TotalOrders.Add(ord);
            }
            foreach (Order ord in PendingOrders)
            {
                TotalOrders.Add(ord);
            }
        }

        public double CombinePrices()
        {
            double TotalBoughtFor = 0;
            foreach (Order ord in TotalOrders)
            {
                TotalBoughtFor += ord.TotalPrice;
            }

            return TotalBoughtFor;
        }

        public void GetAllShoppedItems()
        {
            foreach (Order ord in TotalOrders)
            {
                foreach (ShoppingItem shopitem in ord.ShoppedItems)
                {
                    ShoppedItems.Add(shopitem);
                }
            }
        }

        public int GetQuantities()
        {
            int totalQuant = 0;
            foreach (ShoppingItem item in ShoppedItems)
            {
                totalQuant += item.Quantity;
            }
            return totalQuant;
        }

        public int AmountBought(Item item)
        {
            int bought = 0;
            foreach (ShoppingItem shopItem in ShoppedItems)
            {
                if (item.Name == shopItem.Item.Name)
                {
                    bought += shopItem.Quantity;
                }
            }
            return bought;
        }

        public Item MostBought()
        {
            int currNumber = 0;
            Item currItem = null;
            foreach (Item item in _itemService.GetAll())
            {
                if (currNumber < AmountBought(item))
                {
                    currNumber = AmountBought(item);
                    currItem = item;
                }
            }
            return currItem;
        }

        public int TotalCustomers()
        {
            int total = 0;
            foreach (Models.Users.Customer user in _userService.GetAllCustomers())
            {
                total += 1;
            }

            return total;
        }        
        public int TotalDrivers()
        {
            int total = 0;
            foreach (Models.Users.DeliveryDriver driver in _userService.GetAllDrivers())
            {
                total += 1;
            }

            return total;
        }




    }
}
