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
        private static List<Order> _orders = new List<Order>()
        {
            new Order(6, true, (Customer) UserMockData.GetItems()[9], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[17],2),
                new ShoppingItem(ItemsMockData.GetItems()[2],3),
                new ShoppingItem(ItemsMockData.GetItems()[3],5),
                new ShoppingItem(ItemsMockData.GetItems()[4],3),
                new ShoppingItem(ItemsMockData.GetItems()[5],2),
                new ShoppingItem(ItemsMockData.GetItems()[26],4)
            }),
            new Order(7, true, (Customer) UserMockData.GetItems()[5], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[37],2),
                new ShoppingItem(ItemsMockData.GetItems()[22],3),
                new ShoppingItem(ItemsMockData.GetItems()[13],5),
                new ShoppingItem(ItemsMockData.GetItems()[4],3),
                new ShoppingItem(ItemsMockData.GetItems()[15],2),
                new ShoppingItem(ItemsMockData.GetItems()[6],4)
            }),
            new Order(8, true, (Customer) UserMockData.GetItems()[7], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[7],2),
                new ShoppingItem(ItemsMockData.GetItems()[12],3),
                new ShoppingItem(ItemsMockData.GetItems()[13],5),
                new ShoppingItem(ItemsMockData.GetItems()[4],3),
                new ShoppingItem(ItemsMockData.GetItems()[5],2),
                new ShoppingItem(ItemsMockData.GetItems()[26],4)
            }),
            new Order(9, true, (Customer) UserMockData.GetItems()[8], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[37],2),
                new ShoppingItem(ItemsMockData.GetItems()[1],3),
                new ShoppingItem(ItemsMockData.GetItems()[32],5),
                new ShoppingItem(ItemsMockData.GetItems()[4],3),
                new ShoppingItem(ItemsMockData.GetItems()[15],2),
                new ShoppingItem(ItemsMockData.GetItems()[2],4)
            }),
            new Order(10, true, (Customer) UserMockData.GetItems()[6], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[7],2),
                new ShoppingItem(ItemsMockData.GetItems()[2],3),
                new ShoppingItem(ItemsMockData.GetItems()[3],5),
                new ShoppingItem(ItemsMockData.GetItems()[42],3),
                new ShoppingItem(ItemsMockData.GetItems()[1],2),
                new ShoppingItem(ItemsMockData.GetItems()[26],4)
            }),
            new Order(11, true, (Customer) UserMockData.GetItems()[5], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[4],2),
                new ShoppingItem(ItemsMockData.GetItems()[1],3),
                new ShoppingItem(ItemsMockData.GetItems()[32],5),
                new ShoppingItem(ItemsMockData.GetItems()[24],3),
                new ShoppingItem(ItemsMockData.GetItems()[15],2),
                new ShoppingItem(ItemsMockData.GetItems()[26],4)
            })
        };

        private static List<Order> _pendingOrders = new List<Order>()
        {
            //Ny Order -- Order ID -- False (altid false I pending Orders), TypeCast Userlist som Customer, KUN BRUG 5-9 IKKE OVER ELLER UNDER
            //Ny liste af shopping items, som indeholder et eller flere new shoppingitems
            new Order(1, false, (Customer) UserMockData.GetItems()[5], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[1], 3),
                new ShoppingItem(ItemsMockData.GetItems()[2], 4),
                new ShoppingItem(ItemsMockData.GetItems()[3], 5),
                new ShoppingItem(ItemsMockData.GetItems()[4], 3),
                new ShoppingItem(ItemsMockData.GetItems()[5], 2)

            }),
            new Order(2, false, (Customer) UserMockData.GetItems()[6], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[34],1),
                new ShoppingItem(ItemsMockData.GetItems()[25],3),
                new ShoppingItem(ItemsMockData.GetItems()[10],5),
                new ShoppingItem(ItemsMockData.GetItems()[3],3),
                new ShoppingItem(ItemsMockData.GetItems()[15],2),
                new ShoppingItem(ItemsMockData.GetItems()[6],4)
            }),
            new Order(3, false, (Customer) UserMockData.GetItems()[7], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[37],2),
                new ShoppingItem(ItemsMockData.GetItems()[11],3),
                new ShoppingItem(ItemsMockData.GetItems()[32],1),
                new ShoppingItem(ItemsMockData.GetItems()[4],3),
                new ShoppingItem(ItemsMockData.GetItems()[15],2),
                new ShoppingItem(ItemsMockData.GetItems()[26],4)
            }),
            new Order(4, false, (Customer) UserMockData.GetItems()[9], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[17],2),
                new ShoppingItem(ItemsMockData.GetItems()[21],3),
                new ShoppingItem(ItemsMockData.GetItems()[3],5),
                new ShoppingItem(ItemsMockData.GetItems()[4],3),
                new ShoppingItem(ItemsMockData.GetItems()[15],2),
                new ShoppingItem(ItemsMockData.GetItems()[36],4)
            }),
            new Order(5, false, (Customer) UserMockData.GetItems()[8], new List<ShoppingItem>()
            {
                new ShoppingItem(ItemsMockData.GetItems()[27],2),
                new ShoppingItem(ItemsMockData.GetItems()[12],3),
                new ShoppingItem(ItemsMockData.GetItems()[3],5),
                new ShoppingItem(ItemsMockData.GetItems()[4],3),
                new ShoppingItem(ItemsMockData.GetItems()[15],2),
                new ShoppingItem(ItemsMockData.GetItems()[26],4)
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