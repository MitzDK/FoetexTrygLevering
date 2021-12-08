﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.Models.Order
{
    public class Order
    {
        public int OrderID { get; set; }
        public bool IsDelivered { get; set; }
        public Customer Customer { get; set; }
        public List<ShoppingItem> ShoppedItems { get; set; }
        public double TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public int PostalCode { get; set; }

        public Order()
        {
            
        }

        public Order(int orderId, bool isDelivered, Customer customer, List<ShoppingItem> shoppedItems)
        {
            OrderID = orderId;
            IsDelivered = isDelivered;
            Customer = customer;
            ShoppedItems = shoppedItems;
            DeliveryAddress = customer.Address;
            PostalCode = customer.PostalCode;
            TotalPrice = shoppedItems.Sum(i => i.Item.Price * i.Quantity);
        }
    }
}