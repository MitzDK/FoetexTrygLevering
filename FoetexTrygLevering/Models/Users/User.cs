using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public abstract class User
    {
        public string Navn {get; set;}
        public string Tlf {get; set;}
        public string Email {get; set;}
        public int UserID {get; set;}

    }
}
