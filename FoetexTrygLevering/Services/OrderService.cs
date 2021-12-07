using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Order;

namespace FoetexTrygLevering.Services
{
    public class OrderService : IOrderService
    {
        private List<Order> _orders;
        private JsonFileService JsonFileService { get; set; }

        public OrderService(JsonFileService jsonFileService)
        {
            JsonFileService = jsonFileService;
        }
        public void CreateOrder()
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public List<Order> FilterOrderByCustomer(string cusName)
        {
            throw new NotImplementedException();
        }

        public List<Order> FilterOrderByPrice(int inputPrice)
        {
            throw new NotImplementedException();
        }

        public List<Order> FilterOrderByPostalCode(int inputPostalCode)
        {
            throw new NotImplementedException();
        }

        public Order Search(int id)
        {
            throw new NotImplementedException();
        }
    }
}
