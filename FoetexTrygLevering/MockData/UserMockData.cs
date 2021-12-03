using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.MockData
{
    public class UserMockData
    {
        private static List<User> _users = new List<User>()
        {

        };

        public static List<User> GetItems()
        {
            return _users;
        }
    }
}
