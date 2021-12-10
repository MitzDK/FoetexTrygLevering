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
        public User SearchedUser { get; set; }
        private UserService _userService;
        private User _searchedUser;
        private Models.Users.Admin _admin;
        private Models.Users.Customer _customer;
        private Models.Users.DeliveryDriver _deliveryDriver;

        [Display(Name = "Name:")]
        [Required(ErrorMessage = "Der skal indtastes et navn"), MinLength(2), MaxLength(50)]
        [BindProperty]
        public string Name { get; set; }
        [Display(Name = "Phone #:")]
        [Required(ErrorMessage = "Der skal indtastes et telefonnummer.")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Må kun indeholde tal:"), MinLength(8), MaxLength(8)]
        [BindProperty]
        public string Phone { get; set; }
        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Der skal indtastes en E-mail adresse.")]
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public int UserID { get; set; }

        [Display(Name = "Postal code:")]
        [Required(ErrorMessage = "Der skal angives et postnummer.")]
        [Range(1000, 9999)]
        [BindProperty]
        public int PostalCode { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Der skal indtastes en adresse")]
        [BindProperty]
        public string Address { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Der skal indtastes en alder")]
        [Range(15, 120)]
        [BindProperty]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Må kun indeholde tal:"), MinLength(16), MaxLength(16)]
        [BindProperty]
        public string AccNumber { get; set; }
        

        public EditUserModel(UserService userService)
        {
            _userService = userService;
        }
        
        public IActionResult OnGet(int Id)
        {
            _searchedUser = _userService.Search(Id);
            if (_searchedUser != null)
            {
                SearchedUser = _searchedUser;
                if (_searchedUser is Models.Users.Admin)
                {
                    _admin = (Models.Users.Admin) _searchedUser;
                    UserID = _admin.UserID;
                    Name = _admin.Name;
                    Phone = _admin.Phone;
                    Email = _admin.Email;
                }
                else if (_searchedUser is Models.Users.Customer)
                {
                    _customer = (Models.Users.Customer) _searchedUser;
                    UserID = _customer.UserID;
                    Name = _customer.Name;
                    Phone = _customer.Phone;
                    Email = _customer.Email;
                    PostalCode = _customer.PostalCode;
                    Age = _customer.Age;
                    Address = _customer.CityName;
                    Address = _customer.Street;
                }
                else if (_searchedUser is Models.Users.DeliveryDriver)
                {
                    _deliveryDriver = (Models.Users.DeliveryDriver) _searchedUser;
                    UserID = _deliveryDriver.UserID;
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
            if (_searchedUser is Models.Users.Customer)
            {
                _customer = (Models.Users.Customer) _searchedUser;
                _customer.UserID = UserID;
                _customer.Name = Name;
                _customer.Phone = Phone;
                _customer.Email = Email;
                _customer.PostalCode = PostalCode;
                _customer.Age = Age;
                _customer.CityName = Address;
                _customer.Street = Address;
                _userService.Update(UserID, _customer);
            }
            else if (_searchedUser is Models.Users.DeliveryDriver)
            {
                _deliveryDriver = (Models.Users.DeliveryDriver) _searchedUser;
                _deliveryDriver.UserID = UserID;
                _deliveryDriver.Name = Name;
                _deliveryDriver.Phone = Phone;
                _deliveryDriver.Email = Email;
                _deliveryDriver.PostalCode = PostalCode;
                _deliveryDriver.AccNumber = AccNumber;
                _userService.Update(UserID, _deliveryDriver);
            }
            return RedirectToPage("Homepage");
        }  
    }
}
