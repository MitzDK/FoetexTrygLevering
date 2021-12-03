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

        public DeliveryDriver(int accNumber, int postalCode)
        {
            AccNumber = accNumber;
            postalCode = PostalCode;
        }
    }
}
