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
            new Beverage(13,"Drikkeyoghurt m. blåbær",14,"Syrnet skummetmælk med blåbær 0,5% fedt 500 ml", false),
            new Beverage(14,"Drikkeyoghurt m. hindbær",14,"Syrnet mælk med hindbær 0,6% fedt 500 ml", false),
            new Beverage(15,"Minimælk 0,4% fedt øko",12,"Økologisk homogeniseret minimælk 0,4% fedt 1 liter", false),
            new Beverage(16,"Letmælk 1,5% fedt øko",13,"Økologisk letmælk 1 liter", false),
            new Beverage(17,"Skummetmælk 0,1% fedt øko",12,"Økologisk skummetmælk 1 liter", false),
            new Beverage(18,"Sødmælk 3,5% fedt",11,"Homogeniseret sødmælk 1 liter", false),
            new Beverage(19,"Sødmælk 3,5% fedt øko",14,"Økologisk sødmælk 1 liter", false),
            new Beverage(20,"Rød saft til opblanding",21,"Multifrugtsaft fra koncentrat 5 l.b", false),
            new Beverage(21,"Rød saft til opblanding light",21,"Multifrugtsaft fra koncentrat. Indeholder sødestoffer 5 l.b", false),
            
            new Beverage(22,"Tuborg Classic 18 stk.",88,"Tuborg , Øl 5,94 liter", true),
            new Beverage(23,"Grøn Tuborg Pilsner 18 stk.",88,"Tuborg , Øl 5,94 liter", true),
            new Beverage(24,"Carlsberg 20 stk.",88,"Carlsberg , Øl 6,60 liter", true),
            new Beverage(25,"Primitivo 2020",89,"Montedido Antorino , Vin 75 cl", true),
            new Beverage(26,"Valpolicella Ripasso",99,"Le Arche , Rødvin 75 cl", true),
            new Beverage(27,"Appassimento",109,"Il Capolavoro , Rødvin 75 cl", true),
            new Beverage(28,"Pinot Noir 2019",95, "Vignerons Ardéchois , Vin 75 cl", true),
            new Beverage(29,"Vodka",109,"Smirnoff , Vodka 70 cl", true),
            new Beverage(30,"Vodka",109,"Absolut , Svensk vodka 70 cl", true),
            new Beverage(31,"Vodka",399,"Belvedere , Polish vodka 70 cl", true), 

            new NonFood(32,"Prince",55,"20 stk.",true),
            new NonFood(33,"Prince 100",59,"20 stk.",true),
            new NonFood(34,"Prince Rounded",55,"20 stk.",true),
            new NonFood(35,"Prince Rounded 100",59,"20 stk.",true),
            new NonFood(36,"Kings Blue",55,"20 stk.",true),

            new NonFood(37,"LG 75 UHD TV",8999,"75NANO75",false),
            new NonFood(38,"LG 65 OLED TV",12499,"OLED65A1",false),
            new NonFood(39,"LG 55 OLED TV",8999,"OLED55B1",false),
            new NonFood(40,"LG 55 OLED TV",8555,"OLED55C1",false),
            new NonFood(41,"LG 48 OLED TV",55,"OLED48C1",false),
        };

        public static List<Item> GetItems()
        {
            return _items;
        }
    }
}
