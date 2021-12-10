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
    public class ShoppingCart2Model : PageModel
    {
        public Models.Users.Customer Customer { get; set; }
        public List<ShoppingItem> ShoppingCart { get; set; }
        public double TotalPrice { get; set; }
        private UserService _userService;
        private ItemService _itemService;

        public ShoppingCart2Model(UserService userService, ItemService itemService)
        {
            _userService = userService;
            _itemService = itemService;

        }
        public void OnGet()
        {
            Customer = _userService.SpecificCustomer(User.Identity.Name);
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");

            if (ShoppingCart != null && ShoppingCart.Count != 0)
            {
                TotalPrice = ShoppingCart.Sum(i => i.Item.Price * i.Quantity);
            }
        }
        public IActionResult OnGetAddToCart(int id)
        {
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
            if (ShoppingCart == null)
            {
                ShoppingCart = new List<ShoppingItem>();
                ShoppingCart.Add(new ShoppingItem
                {
                    Item = _itemService.Search(id),
                    Quantity = 1
                });
                HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            }
            else
            {
                int index = Exists(ShoppingCart, id);
                if (index == -1)
                {
                    ShoppingCart.Add(new ShoppingItem
                    {
                        Item = _itemService.Search(id),
                        Quantity = 1
                    });
                }
                else
                {
                    ShoppingCart[index].Quantity++;
                }
                HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            }

            return RedirectToPage("ShoppingCart");
        }

        public IActionResult OnGetDelete(int id)
        {
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
            int index = Exists(ShoppingCart, id);
            ShoppingCart.RemoveAt(index);
            HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            return RedirectToPage("ShoppingCart2");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            ShoppingCart = HttpContext.Session.GetObjectFromJson<List<ShoppingItem>>("ShoppingCart");
            for (int i = 0; i < ShoppingCart.Count; i++)
            {
                ShoppingCart[i].Quantity = quantities[i];
            }
            HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            return RedirectToPage("ShoppingCart2");
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

        public IActionResult OnPostFinishPurchase()
        {
            return RedirectToPage("FinishPurchase", ShoppingCart);
        }
    }
}
