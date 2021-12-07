using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
    public class EditUserModel : PageModel
    {
        private UserService _userService;
        private User _searchedUser;
        private Models.Users.Admin _admin;
        private Models.Users.Customer _customer;
        private Models.Users.DeliveryDriver _deliveryDriver;

        [Display(Name = "Navn:")]
        [Required(ErrorMessage = "Der skal indtastes et navn"), MinLength(2), MaxLength(50)]

        public string Name { get; set; }
        [Display(Name = "Telefon:")]
        [Required(ErrorMessage = "Der skal indtastes et telefonnummer.")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Må kun indeholde tal:"), MinLength(8), MaxLength(8)]

        public string Phone { get; set; }
        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Der skal indtastes en E-mail adresse.")]
        public string Email { get; set; }
        public int UserID { get; set; }

        [Display(Name = "Post nummer:")]
        [Required(ErrorMessage = "Der skal angives et postnummer.")]
        [Range(1000, 9999)]
        public int PostalCode { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Der skal indtastes en adresse")]
        public string Address { get; set; }
        [Display(Name = "Alder")]
        [Required(ErrorMessage = "Der skal indtastes en alder")]
        [Range(15, 120)]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Må kun indeholde tal:"), MinLength(16), MaxLength(16)]
        public string AccNumber { get; set; }

        [BindProperty]
        public Models.Users.User Users { get; set; }

        public EditUserModel(UserService userService)
        {
            _userService = userService;
        }

        public EditUserModel(string name, string phone, string email, int userId, int postalCode, string address, int age, string accNumber, User users)
        {
            Name = name;
            Phone = phone;
            Email = email;
            UserID = userId;
            PostalCode = postalCode;
            Address = address;
            Age = age;
            AccNumber = accNumber;
            Users = users;
        }

        public IActionResult OnGet(int Id)
        {
            _searchedUser = _userService.Search(Id);
            if (_searchedUser != null)
            {
                if (_searchedUser is Models.Users.Admin)
                {
                    _admin = (Models.Users.Admin) _searchedUser;
                    Id = _admin.UserID;
                    Name = _admin.Name;
                    Phone = _admin.Phone;
                    Email = _admin.Email;
                }
                else if (_searchedUser is Models.Users.Customer)
                {
                    _customer = (Models.Users.Customer) _searchedUser;
                    Id = _customer.UserID;
                    Name = _customer.Name;
                    Phone = _customer.Phone;
                    Email = _customer.Email;
                    PostalCode = _customer.PostalCode;
                    Age = _customer.Age;
                    Address = _customer.Address;
                }
                else if (_searchedUser is Models.Users.DeliveryDriver)
                {
                    _deliveryDriver = (Models.Users.DeliveryDriver) _searchedUser;
                    Id = _deliveryDriver.UserID;
                    Name = _deliveryDriver.Name;
                    Phone = _deliveryDriver.Phone;
                    Email = _deliveryDriver.Email;
                    PostalCode = _deliveryDriver.PostalCode;
                    AccNumber = _deliveryDriver.AccNumber;
                }
                
            } 
            return Page();
        }

        public IActionResult OnPost(int Id)
        {
            _searchedUser = _userService.Search(Id);
            if (_searchedUser is Models.Users.Admin)
            {
                _admin = (Models.Users.Admin) _searchedUser;
                _admin.UserID = Id;
                _admin.Name = Name;
                _admin.Phone = Phone;
                _admin.Email = Email;
            }
            else if (_searchedUser is Models.Users.Customer)
            {
                _customer = (Models.Users.Customer) _searchedUser;
                _customer.UserID = Id;
                _customer.Name = Name;
                _customer.Phone = Phone;
                _customer.Email = Email;
                _customer.PostalCode = PostalCode;
                _customer.Age = Age;
                _customer.Address = Address;
            }
            else if (_searchedUser is Models.Users.DeliveryDriver)
            {
                _deliveryDriver = (Models.Users.DeliveryDriver) _searchedUser;
                _deliveryDriver.UserID = Id;
                _deliveryDriver.Name = Name;
                _deliveryDriver.Phone = Phone;
                _deliveryDriver.Email = Email;
                _deliveryDriver.PostalCode = PostalCode;
                _deliveryDriver.AccNumber = AccNumber;
            }
            return RedirectToPage("Homepage");
        }  
    }
}
