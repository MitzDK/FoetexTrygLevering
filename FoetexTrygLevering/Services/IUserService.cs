using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.Services
{
    interface IUserService
    {
        void Add(User newItem);
        User Search(int number);
        Customer SpecificCustomer(string name);
        DeliveryDriver SpecificDeliveryDriver(string name);
        List<User> SearchByName(string str);
        List<User> SearchByPhone(string str);
        List<User> SearchByEmail(string str);
        void Delete(int number);
        void Update(int number, User theUser);
        List<Admin> GetAllAdmins();
        List<Customer> GetAllCustomers();
        List<DeliveryDriver> GetAllDrivers();
        List<User> GetAll();
        void AssignID();
        public void UpdateCustomer(int number, Customer customer);
        public void UpdateDeliveryDriver(int number, DeliveryDriver deliveryDriver);
        User GetCustomer(int id);
        User GetDeliveryDriver(int id);

    }
}
