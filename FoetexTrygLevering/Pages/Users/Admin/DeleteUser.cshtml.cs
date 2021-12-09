using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Models.Users;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
    public class DeleteUserModel : PageModel
    {
        private UserService _userService;
        private User _searchedUser;
        public User SearchedUser { get; private set; }

        public DeleteUserModel(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult OnGet(int id)
        {
            _searchedUser = _userService.Search(id);
            SearchedUser = _searchedUser;
            return Page();
        }

        public IActionResult OnPost(int id)
        {
           _userService.Delete(id);
            return RedirectToPage("Homepage");
        }
       
    }
}
