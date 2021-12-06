using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public abstract class User
    {
        [Display(Name="Navn:")]
        [Required(ErrorMessage = "Der skal indtastes et navn"), MinLength(2), MaxLength(50)]

        public string Name {get; set;}
        [Display(Name ="Telefon:" )]
        [Required(ErrorMessage = "Der skal indtastes et telefonnummer."), MinLength(8), MaxLength(8)]
        public string Phone {get; set;}
        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Der skal indtastes en E-mail adresse.")]
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
