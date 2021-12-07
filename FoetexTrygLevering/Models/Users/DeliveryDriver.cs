using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public class DeliveryDriver : User
    {
        public string AccNumber { get; set; }
        [Required, MinLength(4), MaxLength(4)]
        public int PostalCode { get; set; }

        public DeliveryDriver(string name, string phone, string email, string accNumber, int postalCode) : base(name, phone, email)
        {
            AccNumber = accNumber;
            PostalCode = postalCode;
        }
        public DeliveryDriver(int userID, string name, string phone, string email, string accNumber, int postalCode) : base(userID, name, phone, email)
        {
            AccNumber = accNumber;
            PostalCode = postalCode;
        }
    }
}
