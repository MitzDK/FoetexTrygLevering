using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoetexTrygLevering.Pages.Users.Admin
{
public class EditItemModel : PageModel
    {
        private ItemService _itemService;
        private Item _searchedItem;
        private Food _food;
        private NonFood _nonFood;
        private Beverage _beverage;


        [BindProperty] public bool SpecialCondition{ get; set; }

        [Display(Name = "Item ID")]
        [BindProperty] 
        public int Id { get; set; }

        [Display(Name = "Navn:")]
        [Required(ErrorMessage = "Der skal indtastes et navn")]
        [BindProperty]
        public string Name { get; set; }

        [Display(Name ="Item beskrivelse")]
        [Required(ErrorMessage = "Der skal indtastes en beskrivelse")]
        [BindProperty]
        public string Description { get; set; } 

        [Display(Name ="Pris:")]
        [Required(ErrorMessage = "Der skal indtastes en pris")]
        [BindProperty]
        public double Price { get; set; }

        public EditItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        public IActionResult OnGet(int id)
        {
            _searchedItem = _itemService.Search(id);
            if (_searchedItem != null)
            {
                if (_searchedItem is Food)
                {
                    _food = (Food) _searchedItem;
                    Id = _food.ID;
                    Name = _food.Name;
                    Description = _food.Description;
                    Price = _food.Price;
                }
                else if (_searchedItem is NonFood)
                {
                    _nonFood = (NonFood) _searchedItem;
                    SpecialCondition = _nonFood.AgeRestriction;
                    Id = _nonFood.ID;
                    Name = _nonFood.Name;
                    Description = _nonFood.Description;
                    Price = _nonFood.Price;
                }
                else if (_searchedItem is Beverage)
                {
                    _beverage = (Beverage) _searchedItem;
                    SpecialCondition = _beverage.AgeRestriction;
                    Id = _beverage.ID;
                    Name = _beverage.Name;
                    Description = _beverage.Description;
                    Price = _beverage.Price;
                }
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _searchedItem = _itemService.Search(id);
            if (_searchedItem is Food)
            {
                _food = (Food) _searchedItem;
                _food.ID = Id;
                _food.Name = Name;
                _food.Description = Description;
                _food.Price = Price;
            }
            else if (_searchedItem is NonFood)
            {
                _nonFood = (NonFood) _searchedItem;
                _nonFood.AgeRestriction = SpecialCondition;
                _nonFood.ID = Id;
                _nonFood.Name = Name;
                _nonFood.Description = Description;
                _nonFood.Price = Price;
            }
            else if (_searchedItem is Beverage)
            {
                _beverage = (Beverage)_searchedItem;
                _beverage.AgeRestriction = SpecialCondition;
                _beverage.ID = Id;
                _beverage.Name = Name;
                _beverage.Description = Description;
                _beverage.Price = Price;
            }

            return RedirectToPage("Homepage");
        }

        
    }
}

