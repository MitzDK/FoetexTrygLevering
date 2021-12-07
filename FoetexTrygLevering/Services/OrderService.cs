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
            _orders = JsonFileService.GetJsonOrders();
        }
        public void CreateOrder(Order ord)
        {
            _orders.Add(ord);
        }

        public void UpdateOrder(int number, Order ord)
        {
            Order searchOrder = Search(number);
            searchOrder = ord;
            JsonFileService.SaveJsonOrders(_orders);
        }

        public void DeleteOrder(int number)
        {
            _orders.RemoveAt(number-1);
            AssignID();
            JsonFileService.SaveJsonOrders(_orders);
        }


        public List<Order> FilterOrderByCustomer(string cusName)
        {
            List<Order> searchList = new List<Order>();
            if (string.IsNullOrEmpty(cusName)) return _orders;
            foreach (Order ord in _orders)
            {
                if (ord.Customer.Name.ToLower().Contains(cusName.ToLower()))
                {
                    searchList.Add(ord);
                }
            }

            return searchList;
        }

        public IEnumerable<Order> PriceFilter(int maxPrice, int minPrice)
        {
            List<Order> filterList = new List<Order>();
            foreach (Order ord in _orders)
            {
                if ((minPrice == 0 && ord.TotalPrice <= maxPrice) || (maxPrice == 0 && ord.TotalPrice >= minPrice) ||
                    (ord.TotalPrice >= minPrice && ord.TotalPrice <= maxPrice))
                {
                    filterList.Add(ord);
                }
            }

            return filterList;
        }

        public List<Order> FilterOrderByPostalCode(int inputPostalCode)
        {
            throw new NotImplementedException();
        }

        public Order Search(int id)
        {
            foreach (Order ord in _orders)
            {
                if (id == ord.OrderID)
                {
                    return ord;
                }
            }
            return null;
        }

        public List<Order> GetAll()
        {
            return _orders;
        }

        public void AssignID()
        {
            foreach (Order ord in _orders)
            {
                ord.OrderID = _orders.IndexOf(ord) + 1;
            }
        }
    }
}
