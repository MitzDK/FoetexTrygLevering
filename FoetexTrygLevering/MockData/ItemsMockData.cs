using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;

namespace FoetexTrygLevering.MockData
{
    public class ItemsMockData
    {
        private static List<Item> _items = new List<Item>()
        {
            //ID, Navn, Pris, Description
            new Food(1, "Hakket Oksekød 450g", 42, ""),
            new Food(2, "", 34, ""),
            new Food(3, "Hakket oksekød 4-7% fedt9", 34,"Hakket oksekød 4-7% fedt 400 g"),
            new Food(4, "Hakket oksekød 14-18% fedt", 30,"Hakket oksekød 14-18% fedt 500 g"),
            new Food(5, "Hakket oksekød 4-7% fedt øko", 50,"Økologisk hakket oksekød 4-7% fedt 400 g"),
            new Food(6, "Hakket oksekød 14-18% fedt", 42,""),
            new Food(7, "Banan", 42,""),
            new Food(8, "Banan", 42,""),
            new Food(9, "Banan",  42,""),
            new Food(10, "Banan", 999, "")
        };

        public static List<Item> GetItems()
        {
            return _items;
        }
    }
}
