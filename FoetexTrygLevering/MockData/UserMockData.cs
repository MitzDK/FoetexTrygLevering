using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.MockData
{
    public class UserMockData
    {
        private static List<User> _users = new List<User>()
        {
            //Admin
            //int userId, string name, string phone, string email

            //Customer
            //int userId, string name, string phone, string email, string address, int age
            new Customer(1, "Guest", "+4500000000", "123@email.com", "EksempelVej 123", 18)

            //Delivery Driver
            //int userID, string name, string phone, string email, int accNumber, int postalCode




        };

        public static List<User> GetItems()
        {
            return _users;
        }
    }
}
