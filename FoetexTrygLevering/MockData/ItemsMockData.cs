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
           //ID, Navn, Pris, Description, Image
            new Food(1, "Hakket oksekød 8-12% fedt øko", 42, "Økologisk hakket oksekød 8-12% fedt 450 g", "Hakkekoed.jpg"),
            new Food(2, "Hakket oksekød 4-7% fedt", 34,"Hakket oksekød 4-7% fedt 400 g", "Hakkekoed.jpg"),
            new Food(3, "Hakket oksekød 14-18% fedt", 30,"Hakket oksekød 14-18% fedt 500 g", "Hakkekoed.jpg"),
            new Food(4, "Hakket oksekød 4-7% fedt øko", 50,"Økologisk hakket oksekød 4-7% fedt 400 g", "Hakkekoed.jpg"),
            new Food(5, "Hakket oksekød 14-18% fedt", 65,"Hakket oksekød 14-18% fedt 1000 g", "Hakkekoed.jpg"),
            new Food(6, "Hakket oksekød 4-7% fedt", 78,"Hakket oksekød 4-7% fedt 1000 g", "Hakkekoed.jpg"),
            new Food(7, "Hakket oksekød 8-12% fedt",  150,"Hakket oksekød 8-12% fedt 2100 g", "Hakkekoed.jpg"),
            new Food(8, "Hakkebøffer", 65,"Hakkebøffer af oksekød 500 g","Hakkeboeffer.jpg"),
            new Food(9, "Hakket oksekød 8-12% fedt", 49,"Slagtermesteren 1000 g","Hakkekoed.jpg"),
            new Food(10, "Entrecotes", 65,"Entrecotebøffer 360 g","Entrecotes.jpg"),
            new Food(11, "Flanksteak", 65, "Okseflanksteak 500 g","Flanksteak.jpg"),

            new Food(52, "Softkernerugbrød øko", 45, "Emmerys , Økologisk kernerugbrød 1 kg","Softkernerugbrød øko.jfif"),
            new Food(53, "Ølandsbrød øko", 45, "Emmerys , Økologisk ølandsbrød 650 g","Ølandsbrød øko.jfif"),
            new Food(54, "Skiveskåret rugbrød øko", 45, "Emmerys , Økologisk rugbrød med solsikke- og græskarkerner 950 g","Skiveskåret softkernerugbrød øko.jfif"),
            new Food(55, "Kernerugbrød", 22, "Schulstad Signaturbrød, Rugbrød med kerner 750 g","Kernerugbrød.jfif"),
            new Food(56, "Solsikkerugbrød", 21, "Schulstad Det Gode, Rugbrød med solsikkekerner 950 g","Solsikkerugbrød.jfif"),
            new Food(57, "Gulerødder øko", 11, "Salling ØKO , Økologiske gulerødder 1 kg","Gulerødder øko.jfif"),
            new Food(58, "Kartofler øko", 11, "Økologiske kartofler 1 kg","Kartofler øko.jfif"),
            new Food(59, "Broccoli øko", 14, "Levevis , Økologisk broccoli 350 g","Broccoli øko.jfif"),
            new Food(60, "Hjertesalat", 12, "Hjertesalat (Bindsalat) 1 stk","Hjertesalat.jfif"),
            new Food(61, "Blomkål øko", 18, "Levevis , Økologisk blomkål 1 stk","Blomkål øko.jfif"),

            new Food(62, "Müslibar m. mælkechokolade", 11, "Salling , Müslibar med havreflager og mælkechokolade 150 g","Müslibar m. mælkechokolade.jfif"),
            new Food(63, "Müslibarer m. chokolade", 21, "Corny , Müslibarer med mælkechokoladeovertræk 150 g","Müslibarer m. chokolade.jfif"),
            new Food(64, "Müslibarer m. mørk chokolade", 11, "Ravensbergen Muesli+, Müslibarer med mørk chokolade og hasselnødder 126 g","Müslibarer m. mørk chokolade og hasselnødder.jfif"),
            new Food(65, "Müslibarer m. choko/banan", 21, "Corny , Müslibarer med banan og mælkechokoladeovertræk 150 g","Müslibarer m. chokolade og banan.jfif"),
            new Food(66, "Müslibarer m. blåbær", 18, "Ravensbergen Muesli+, Müslibarer med blåbær 120 g","Müslibarer m. blåbær.jfif"),
            new Food(67, "Proteinbar m. cookies & cream", 20, "Barebells , Proteinbar med mælkechokolade. Indeholder sødestoffer 55 g","Proteinbar m. cookies & cream.jfif"),
            new Food(68, "Proteinbar m. karamel u. sukker", 20, "Barebells Double Bite, Proteinbar med karamelsmag. Indeholder sødestoffer 55 g","Proteinbar m. karamelknas u. tilsat sukker.jfif"),
            new Food(69, "Proteinbar m. kokossmag", 25, "Nutramino , Proteinbar med kokos og mælkechokoladeovertræk 66 g","Proteinbar m. kokossmag.jfif"),
            new Food(70, "Proteinbar m. hvid chokolade", 20, "Barebells , Proteinbar med hvid chokolade og mandelsmag. Indeholder sødestoffer 55 g","Proteinbar m. hvid chokolade og mandler u. tilsat sukker.jfif"),
            new Food(71, "Protein rawbar øko", 20, "Rawbite , Økologisk daddel- og rosinbar med nødder og protein 50 g","Protein rawbar øko.jfif"),
            new Food(72,"Pebernødder", 25,"Karen Volf 400 g", "Peberndder.jfif"),

            new Beverage(12,"Drikkeyoghurt m. jordbær",14,"Drikkeyoghurt m. jordbær", false,"DrikkeYoghurtJordbaer.jpg"),
            new Beverage(13,"Drikkeyoghurt m. blåbær",14,"Syrnet skummetmælk med blåbær 0,5% fedt 500 ml", false,"DrikkeYoghurtBlaabaer.jpg"),
            new Beverage(14,"Drikkeyoghurt m. hindbær",14,"Syrnet mælk med hindbær 0,6% fedt 500 ml", false,"DrikkeYoghurtHindbaer.jpg"),
            new Beverage(15,"Minimælk 0,4% fedt øko",12,"Økologisk homogeniseret minimælk 0,4% fedt 1 liter", false,"Minimaelk.jpg"),
            new Beverage(16,"Letmælk 1,5% fedt øko",13,"Økologisk letmælk 1 liter", false,"Minimaelk.jpg"),
            new Beverage(17,"Skummetmælk 0,1% fedt øko",12,"Økologisk skummetmælk 1 liter", false,"Skummetmaelk.jpg"),
            new Beverage(18,"Sødmælk 3,5% fedt",11,"Homogeniseret sødmælk 1 liter", false,"Skummetmaelk.jpg"),
            new Beverage(19,"Sødmælk 3,5% fedt øko",14,"Økologisk sødmælk 1 liter", false,"SoedmaelkOko.jpg"),
            new Beverage(20,"Rød saft til opblanding",21,"Multifrugtsaft fra koncentrat 5 l.b", false,"RoedSaft.jpg"),
            new Beverage(21,"Rød saft til opblanding light",21,"Multifrugtsaft fra koncentrat. Indeholder sødestoffer 5 l.b", false,"RoedSaftLight.jpg"),

            new Beverage(22,"Tuborg Classic 18 stk.",88,"Tuborg , Øl 5,94 liter", true,"TuborgClassic18stk.jpg"),
            new Beverage(23,"Grøn Tuborg Pilsner 18 stk.",88,"Tuborg , Øl 5,94 liter", true,"Tuborg18stk.jpg"),
            new Beverage(24,"Carlsberg 20 stk.",88,"Carlsberg , Øl 6,60 liter", true,"Carlsberg20stk.jpg"),
            new Beverage(25,"Primitivo 2020",89,"Montedido Antorino , Vin 75 cl", true,"Primitivo2020.jpg"),
            new Beverage(26,"Valpolicella Ripasso",99,"Le Arche , Rødvin 75 cl", true,"ValpolicellaRipasso.jpg"),
            new Beverage(27,"Appassimento",109,"Il Capolavoro , Rødvin 75 cl", true,"Appassimento.jpg"),
            new Beverage(28,"Pinot Noir 2019",95, "Vignerons Ardéchois , Vin 75 cl", true,"PinotNoir2019.jpg"),
            new Beverage(29,"Vodka",109,"Smirnoff , Vodka 70 cl", true,"SmirnoffVodka.jpg"),
            new Beverage(30,"Vodka",109,"Absolut , Svensk vodka 70 cl", true,"AbsolutVodka.jpg"),
            new Beverage(31,"Vodka",399,"Belvedere , Polish vodka 70 cl", true,"BelvedereVodka.jpg"),

            new NonFood(32,"Toiletpapir 2-lags",10,"Budget 1 kg",false, imageName:"Toiletpapir 2-lags.jfif"),
            new NonFood(33,"Fugtigt toiletpapir sensitiv",15,"Lotus 42 stk",false, imageName:"Fugtigt toiletpapir sensitiv.jfif"),
            new NonFood(34,"Toiletpapir 3-lags",18,"Lotus Comfort 0,76 kg",false, imageName:"Toiletpapir 3-lags.jfif"),
            new NonFood(35,"Toiletpapir 4-lags",25,"Salling , Toiletpapir 4 lag 1,34 kg",true, imageName:"Toiletpapir 4-lags.jfif"),
            new NonFood(36,"Toiletpapir 3 lag 10-pak",27,"Salling 1,25 kg",false, imageName:"Toiletpapir 3 lag 10-pak.jfif"),
            new NonFood(37,"Universalrengøring",25,"Ajax 1250 ml",false,"Universalrengøring.jfif"),
            new NonFood(38,"Toiletrens Ocean Fresh",22,"Klorin 750 ml",false,"Toiletrens Ocean Fresh.jfif"),
            new NonFood(39,"Toiletrens",5,"Salling 1 liter",false,"Toiletrens.jfif"),
            new NonFood(40,"Rengøringsservietter",30,"Ajax 70 stk",false,"Rengøringsservietter.jfif"),
            new NonFood(41,"Badrengøring",28,"Ajax 750 ml",false,"Badrengøring.jfif"),

            new NonFood(42,"Håndsæbe m. aloe vera og lavendel",30,"Eco Care Nordic 500 ml",false,"Håndsæbe m. aloe vera og lavendel.jfif"),
            new NonFood(43,"Håndsæbe parfumefri",12,"Sanex Zero % 300 ml",false,"Håndsæbe parfumefri.jfif"),
            new NonFood(44,"Shower milk m. honning og mælk",24,"Palmolive Naturals 650 ml",false,"Shower milk m. honning og mælk.jfif"),
            new NonFood(45,"Shower gel m. æteriske olier",10,"Palmolive Aroma Sensations 250 ml",false,"Shower gel m. æteriske olier.jfif"),
            new NonFood(46,"Håndsæbe parfumefri Neutral",12,"Neutral 250 ml",false,"Håndsæbe parfumefri Neutral.jfif"),
            new NonFood(47,"Opvaskemiddel citrus",12,"Vel Ultra 500 ml",false,"Opvaskemiddel citrus.jfif"),
            new NonFood(48,"Opvaskemiddel lime",12,"Vel Ultra 500 ml",false,"Opvaskemiddel lime.jfif"),
            new NonFood(49,"Opvaskemiddel sensitiv",12,"Vel Ultra 500 ml",false,"Opvaskemiddel sensitiv.jfif"),
            new NonFood(50,"Opvaskemiddel citronmelisse",21,"Eco Clean Nordic 500 ml",false,"Opvaskemiddel citronmelisse.jfif"),
            new NonFood(51,"Afspændingsmiddel",15,"Salling 1 liter",false,"Afspændingsmiddel.jfif"),
        };

        public static List<Item> GetItems()
        {
            return _items;
        }
    }
}
