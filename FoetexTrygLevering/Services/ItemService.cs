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
            _items = ItemsMockData.GetItems();
            //Udkommenter og brug den ovenover, hvis du vil bruge Mock Data istedet
            //_items = JsonFileService.GetJsonItems().ToList();
        }
        public void Add(Item newItem)
        {
            _items.Add(newItem);
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
                if (item.Description.ToLower().Contains(str.ToLower()))
                {
                    searchList.Add(item);
                }
            }

            return searchList;
        }

        public List<Item> SearchByDescription(string str)
        {
            throw new NotImplementedException();
        }

        public void Delete(int number)
        {
            throw new NotImplementedException();
        }

        public void Update(int number, Item theItem)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public void AssignID()
        {
            throw new NotImplementedException();
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
