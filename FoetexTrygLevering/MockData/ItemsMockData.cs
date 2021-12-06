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
            new Food(1, "Hakket oksekød 8-12% fedt øko", 42, "Økologisk hakket oksekød 8-12% fedt 450 g"),
            new Food(2, "Hakket oksekød 4-7% fedt", 34,"Hakket oksekød 4-7% fedt 400 g"),
            new Food(3, "Hakket oksekød 14-18% fedt", 30,"Hakket oksekød 14-18% fedt 500 g"),
            new Food(4, "Hakket oksekød 4-7% fedt øko", 50,"Økologisk hakket oksekød 4-7% fedt 400 g"),
            new Food(5, "Hakket oksekød 14-18% fedt", 65,"Hakket oksekød 14-18% fedt 1000 g"),
            new Food(6, "Hakket oksekød 4-7% fedt", 78,"Hakket oksekød 4-7% fedt 1000 g"),
            new Food(7, "Hakket oksekød 8-12% fedt",  150,"Hakket oksekød 8-12% fedt 2100 g"),
            new Food(8, "Hakkebøffer", 65,"Hakkebøffer af oksekød 500 g"),
            new Food(9, "Hakket oksekød 8-12% fedt", 49,"Slagtermesteren 1000 g"),
            new Food(10, "Entrecotes", 65,"Entrecotebøffer 360 g"),
            new Food(11, "Flanksteak", 65, "Okseflanksteak 500 g"),

            new Beverage(12,"Drikkeyoghurt m. jordbær",14,"Drikkeyoghurt m. jordbær", false),
            new Beverage(12,"Drikkeyoghurt m. blåbær",14,"Syrnet skummetmælk med blåbær 0,5% fedt 500 ml", false),
            new Beverage(12,"Drikkeyoghurt m. blåbær",14,"Syrnet skummetmælk med blåbær 0,5% fedt 500 ml", false)

        };

        public static List<Item> GetItems()
        {
            return _items;
        }
    }
}
