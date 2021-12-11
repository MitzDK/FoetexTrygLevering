using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using FoetexTrygLevering.MockData;
using FoetexTrygLevering.Models.Items;

namespace FoetexTrygLevering.Services
{
    public class ItemService : IItemService
    {
        private List<Item> _items;
        private JsonFileService JsonFileService { get; set; }

        public ItemService(JsonFileService jsonFileService)
        {
            JsonFileService = jsonFileService;
            //Udkommenter og brug den nedenunder, hvis du vil bruge Json data istedet for Mock Data
            //_items = ItemsMockData.GetItems();
            //Udkommenter og brug den ovenover, hvis du vil bruge Mock Data istedet
            _items = JsonFileService.GetJsonItems();
        }

        public void Add(Item newItem)
        {
            _items.Add(newItem);
            AssignID();
            JsonFileService.SaveJsonItems(_items);
        }

        public Item Search(int number)
        {
            foreach (Item item in _items)
            {
                if (number == item.ID)
                {
                    return item;
                }
            }

            return null;
        }

        public List<Item> SearchByName(string str)
        {
            List<Item> searchList = new List<Item>();
            if (string.IsNullOrEmpty(str)) return _items;
            foreach (Item item in _items)
            {
                if (item.Name.ToLower().Contains(str.ToLower()))
                {
                    searchList.Add(item);
                }
            }
            return searchList;
        }

        public List<Item> SearchByDescription(string str)
        {
            List<Item> searchList = new List<Item>();
            if (string.IsNullOrEmpty(str)) return _items;
            foreach (Item item in _items)
            {
                if (item.Description.ToLower().Contains(str.ToLower()))
                {
                    searchList.Add(item);
                }
            }
            return searchList;
        }

        public void Delete(int number)
        {
            _items.RemoveAt(number-1);
            AssignID();
            JsonFileService.SaveJsonItems(_items);
        }

        public void Update(int number, Item theItem)
        {
            Item searchItem = Search(number);
            searchItem = theItem;
            JsonFileService.SaveJsonItems(_items);
        }

        public List<Item> GetAll()
        {
            return _items;
        }
        
        public List<Item> GetAllFood()
        {
            List<Item> foodList = new List<Item>();
            foreach (Item item in GetAll())
            {
                if (item is Food)
                {
                    foodList.Add(item);
                }
            }
            return foodList;
        }

        public List<Item> GetAllBeverages()
        {
            List<Item> beverageList = new List<Item>();
            foreach (Item item in GetAll())
            {
                if (item is Beverage)
                {
                    beverageList.Add(item);
                }
            }
            return beverageList;
        }

        public List<Item> GetAllNonFoods()
        {
            List<Item> nonFoodList = new List<Item>();
            foreach (Item item in GetAll())
            {
                if (item is NonFood)
                {
                    nonFoodList.Add(item);
                }
            }

            return nonFoodList;
        }

        public void AssignID()
        {
            foreach (Item item in _items)
            {
                item.ID = _items.IndexOf(item) + 1;
            }
        }

        public IEnumerable<Item> PriceFilter(int maxPrice, int minPrice)
        {
            List<Item> filterList = new List<Item>();
            foreach (Item item in _items)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            return filterList;
        }
    }
}
