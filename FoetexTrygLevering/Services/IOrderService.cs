using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Order;

namespace FoetexTrygLevering.Services
{
    interface IOrderService
    {
        public void CreateOrder(Order ord);
        public void UpdateOrder(int number, Order ord);
        public void DeleteOrder(int number);
        public List<Order> FilterOrderByCustomer(string cusName);
        public IEnumerable<Order> PriceFilter(int maxPrice, int minPrice);
        public List<Order> FilterOrderByPostalCode(int inputPostalCode);
        public void AssignID();
        public Order Search(int id);
        public List<Order> GetAll();
        public void CreatePendingOrder(Order ord);
    }
}
