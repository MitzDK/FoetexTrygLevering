using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Order;

namespace FoetexTrygLevering.Services
{
    interface IOrderService
    {
        public void CreateOrder();
        public Order UpdateOrder();
        public void DeleteOrder();
        public List<Order> FilterOrderByCustomer(string cusName);
        public List<Order> FilterOrderByPrice(int inputPrice);
        public List<Order> FilterOrderByPostalCode(int inputPostalCode);

        public Order Search(int id);

    }
}
