using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;

namespace FoetexTrygLevering.Services
{
    public class ItemService : IItemService
    {
        private List<Item> _items;
        private JsonFileService JsonFileService { get; set; }

        public ItemService(JsonFileService jsonFileService)
        {

        }
        public void Add(Item newItem)
        {
            throw new NotImplementedException();
        }

        public Item Search(int number)
        {
            throw new NotImplementedException();
        }

        public List<Item> SearchByName(string str)
        {
            throw new NotImplementedException();
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
    }
}
