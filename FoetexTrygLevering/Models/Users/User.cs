using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public abstract class User
    {
        public string Name {get; set;}
        public string Phone {get; set;}
        public string Email {get; set;}
        public int UserID {get; set;}


        public User()
        {
            
        }

        protected User(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        protected User(int userID, string name, string phone, string email)
        {
            UserID = userID;
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
