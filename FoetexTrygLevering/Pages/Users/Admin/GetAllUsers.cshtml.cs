using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
    public class GetAllUsersModel : PageModel
    {
        private UserService _userService;

        public List<Models.Users.User> ListUsers { get; private set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Email { get; set; }
        [BindProperty] public string Phone { get; set; }
        [BindProperty] public string SearchID { get; set; }
        private int _searchID;

        public GetAllUsersModel(UserService userService)
        {
            _userService = userService;
        }
        public void OnGet()
        {
            ListUsers = _userService.GetAll();
        }

        public IActionResult OnPostNameSearch()
        {
            ListUsers = _userService.SearchByName(Name).ToList();
            return Page();
        }

        public IActionResult OnPostEmailSearch()
        {
            ListUsers = _userService.SearchByEmail(Email).ToList();
            return Page();
        }

        public IActionResult OnPostPhoneSearch()
        {
            ListUsers = _userService.SearchByPhone(Phone).ToList();
            return Page();
        }
        public IActionResult OnPostIDSearch()
        {
            List<User> searchList = new List<User>();
            try
            {
                _searchID = Convert.ToInt32(SearchID);
            }
            catch
            {
                SearchID = "Du skal taste et tal!";
                return Page();
            }
            searchList.Add(_userService.Search(_searchID));
            ListUsers = searchList;
            if (ListUsers[0] == null)
            {
                ListUsers = _userService.GetAll();
            }
            return Page();
        }


    }
}

