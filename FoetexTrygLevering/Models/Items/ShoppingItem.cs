using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Items
{
    public class ShoppingItem
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public ShoppingItem(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }

        public ShoppingItem()
        {
            
        }
        public double GetPrice()
        {
            return Item.Price * Quantity;
        }
    }
}
