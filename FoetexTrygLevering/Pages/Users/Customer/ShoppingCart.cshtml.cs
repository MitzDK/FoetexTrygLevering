using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Helpers;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FoetexTrygLevering.Pages.Users.Customer
{
    public class ShoppingCartModel : PageModel
    {
        public Models.Users.Customer Customer { get; set; }
        public List<Models.Items.Item> ItemList { get; set; }
        public List<ShoppingItem> ShoppingCart { get; set; }
        public double TotalPrice { get; set; }
        


        private UserService _userService;
        private ItemService _itemService;

        public ShoppingCartModel(UserService userService, ItemService itemService)
        {
            _userService = userService;
            _itemService = itemService;

        }
        public void OnGet()
        {
            Customer = _userService.SpecificCustomer(User.Identity.Name);
            ShoppingCart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "ShoppingCart");
            TotalPrice = 1;
            //ShoppingCart.Sum(i => i.Item.Price * i.Quantity);
        }
        public IActionResult OnPostAddToCart(int id)
        {
            ShoppingCart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "ShoppingCart");
            if (ShoppingCart == null)
            {
                ShoppingCart = new List<ShoppingItem>();
                ShoppingCart.Add(new ShoppingItem()
                {
                    Item = _itemService.Search(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "ShoppingCart", ShoppingCart);
            }
            else
            {
                int index = Exists(ShoppingCart, id);
                if (index == 1)
                {
                    ShoppingCart.Add(new ShoppingItem()
                    {
                        Item = _itemService.Search(id),
                        Quantity = 1
                    });
                }
                else
                {
                    ShoppingCart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "ShoppingCart", ShoppingCart);
            }

            return RedirectToPage("ShoppingCart");
        }

        public IActionResult OnGetDelete(int id)
        {
            ShoppingCart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "ShoppingCart");
            int index = Exists(ShoppingCart, id);
            ShoppingCart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "ShoppingCart", ShoppingCart);
            return RedirectToPage("ShoppingCart");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            ShoppingCart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "ShoppingCart");
            for (int i = 0; i < ShoppingCart.Count; i++)
            {
                ShoppingCart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "ShoppingCart", ShoppingCart);
            return RedirectToPage("ShoppingCart");
        }

        private int Exists(List<ShoppingItem> ShoppingCart, int id)
        {
            for (int i = 0; i < ShoppingCart.Count; i++)
            {
                if (ShoppingCart[i].Item.ID == id)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
