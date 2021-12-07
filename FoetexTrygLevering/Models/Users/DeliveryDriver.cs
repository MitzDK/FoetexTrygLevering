using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public class DeliveryDriver : User
    {
        [Required]
        public string AccNumber { get; set; }


        [Display(Name = "Post nummer:")]
        [Required(ErrorMessage = "Der skal angives et postnummer.")]
        [Range(1000, 9999)]
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
