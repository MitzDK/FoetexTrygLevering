using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users
{
    public class GetAllUsersModel : PageModel
    {
        public List<User> Users { get; set; }
        private UserService _userService;


        [BindProperty] public string SearchString { get; set; }

        public GetAllUsersModel(UserService userService)
        {
            _userService = userService;
        }
        public void OnGet()
        {
            _userService.GetAll();
        }

        public IActionResult OnPostNameSearch()
        {
            Users = _userService.SearchByName(SearchString).ToList();
            return Page();
        }
    }
}
