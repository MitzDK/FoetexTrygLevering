using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Order;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.MockData
{
    public class OrderMockData
    {
        private static List<Order> _orders = new List<Order>();
        private static List<Order> _pendingOrders = new List<Order>();

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
