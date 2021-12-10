using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Helpers;
using FoetexTrygLevering.MockData;
using FoetexTrygLevering.Models.Order;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FoetexTrygLevering.Services
{
    public class OrderService : IOrderService
    {
        private List<Order> _orders;
        private List<Order> _pendingOrders;
        private bool _isOrderSorted;
        private JsonFileService JsonFileService { get; set; }

        public OrderService(JsonFileService jsonFileService)
        {
            JsonFileService = jsonFileService;
            //_orders = JsonFileService.GetJsonOrders();
            _orders = OrderMockData.GetAllOrders();
            _pendingOrders = OrderMockData.GetAllPendingOrders();
            //_pendingOrders = JsonFileService.GetJsonPendingOrders();
            AssignPendingID();
            AssignID();
        }
        public void CreateOrder(Order ord)
        {
            _orders.Add(ord);
            ord.OrderID = _orders[_orders.IndexOf(ord) - 1].OrderID + 1;
            JsonFileService.SaveOrders(_orders);
        }

        public void CreatePendingOrder(Order ord)
        {
            _pendingOrders.Add(ord);
            AssignPendingID();
            JsonFileService.SavePendingOrders(_pendingOrders);
            //Udkommenter linjen nedenunder når vi begynder at bruge json
        }

        public Order NewPendingOrder(Order ord)
        {
            CreatePendingOrder(ord);
            ord.IsDelivered = false;
            return _pendingOrders[_pendingOrders.IndexOf(ord)];
        }
        public Order NewDoneOrder(Order ord)
        {
            CreateOrder(ord);
            ord.IsDelivered = true;
            return _orders[_orders.IndexOf(ord)];
        }

        public void UpdateOrder(int number, Order ord)
        {
            Order searchOrder = Search(number);
            searchOrder = ord;
            JsonFileService.SaveOrders(_orders);
            JsonFileService.SavePendingOrders(_pendingOrders);

        }

        public void DeleteOrder(Order ord)
        {
            _orders.RemoveAt(_orders.IndexOf(ord));
            JsonFileService.SaveOrders(_orders);
            JsonFileService.SavePendingOrders(_pendingOrders);
        }
        public void DeletePendingOrder(Order ord)
        {
            _pendingOrders.RemoveAt(_pendingOrders.IndexOf(ord));
            _orders.Add(ord);
            JsonFileService.SaveOrders(_orders);
            JsonFileService.SavePendingOrders(_pendingOrders);
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
        public Order SearchPending(int id)
        {
            foreach (Order ord in _pendingOrders)
            {
                if (id == ord.OrderID)
                {
                    return ord;
                }
            }
            return null;
        }

        public void SortByPostalCode(List<Order> orderList)
        {
            if (_isOrderSorted == false)
            {
                orderList.Sort();
                _isOrderSorted = true;
            }
            else
            {
                orderList.Reverse();
                _isOrderSorted = false;
            }

        }

        public List<Order> GetAll()
        {
            return _orders;
        }

        public void AssignPendingID()
        {
            foreach (Order ord in _pendingOrders)
            {
                ord.OrderID = _pendingOrders.IndexOf(ord) + 1;
            }
        }

        public void AssignID()
        {
            foreach (Order ord in _orders)
            {
                ord.OrderID = _orders.IndexOf(ord) + 1;
            }
        }

        public List<Order> GetAllPending()
        {
            return _pendingOrders;
        }

    }
}
