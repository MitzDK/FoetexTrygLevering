using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public class Admin : User
    {
        public Admin()
        {
        }

        public Admin(string name, string phone, string email) : base(name, phone, email)
        {
            
        }
        public Admin(int userId, string name, string phone, string email) : base(userId, name, phone, email)
        {

        }

    }
}
