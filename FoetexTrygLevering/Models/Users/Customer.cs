using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public class Customer : User
    {
        [Display(Name = "Bynavn")]
        [Required(ErrorMessage = "Der skal indtastes en adresse")]

        public string CityName { get; set; }
        [Display(Name = "Vejnavn")]
        [Required(ErrorMessage = "Der skal indtastes en adresse")]
        public string Street { get; set; }
        [Display(Name = "Alder")]
        [Required(ErrorMessage = "Der skal indtastes en alder")]
        [Range(15, 120)]
        public int Age { get; set; }
        [Display(Name = "Post nummer:")]
        [Required(ErrorMessage = "Der skal angives et postnummer.")]
        [Range(1000, 9999)]
        public int PostalCode { get; set; }

        public Customer()
        {

        }

        public Customer(string name, string phone, string email, string cityName, string street, int postalCode, int age) : base(name, phone, email)
        {
            PostalCode = postalCode;
            CityName = cityName;
            Street = street;
            Age = age;
        }
        public Customer(int userId, string name, string phone, string email, string cityName, string street, int postalCode, int age) : base(userId, name, phone, email)
        {
            PostalCode = postalCode;
            CityName = cityName;
            Street = street;
            Age = age;
        }

    }
}
