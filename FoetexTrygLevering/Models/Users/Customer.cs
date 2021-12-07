using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;

namespace FoetexTrygLevering.Models.Users
{
    public class Customer : User
    {
        public string Address { get; set; }
        public int Age { get; set; }

        public List<Item> ShoppingCart { get; set; }
        public Customer()
        {
            
        }

        public Customer(string name, string phone, string email, string address, int age) : base(name, phone, email)
        {
            Address = address;
            Age = age;
        }
        public Customer(int userId, string name, string phone, string email, string address, int age) : base(userId, name, phone, email)
        {
            Address = address;
            Age = age;
        }

    }
}
