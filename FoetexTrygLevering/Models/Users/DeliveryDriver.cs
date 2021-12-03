using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public class DeliveryDriver : User
    {
        public int AccNumber { get; set; }
        public int PostalCode { get; set; }

        public DeliveryDriver(string name, string phone, string email, int accNumber, int postalCode) : base(name, phone, email)
        {
            AccNumber = accNumber;
            PostalCode = postalCode;
        }
        public DeliveryDriver(int userID, string name, string phone, string email, int accNumber, int postalCode) : base(userID, name, phone, email)
        {
            AccNumber = accNumber;
            PostalCode = postalCode;
        }
    }
}
