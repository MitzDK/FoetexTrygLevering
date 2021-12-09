using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Models.Order;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.MockData
{
    public class OrderMockData
    {
        private static List<Order> _orders = new List<Order>();
        private static List<Order> _pendingOrders = new List<Order>()
        {
            //Ny Order -- Order ID -- False (altid false I pending Orders), TypeCast Userlist som Customer, KUN BRUG 5-9 IKKE OVER ELLER UNDER
            //Ny liste af shopping items, som indeholder et eller flere new shoppingitems
            new Order(1, false, (Customer)UserMockData.GetItems()[5], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[2], 3)
            })
        };

        public static List<Order> GetAllOrders()
        {
            return _orders;
        }
        public static List<Order> GetAllPendingOrders()
        {
            return _pendingOrders;
        }
    }
}
