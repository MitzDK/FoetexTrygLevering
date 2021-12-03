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
        List<User> SearchByName(string str);
        List<User> SearchByDescription(string str);
        void Delete(int number);
        void Update(int number, User theUser);
        List<User> GetAll();
        void AssignID();
    }
}
