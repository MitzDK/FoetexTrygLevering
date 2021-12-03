using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;

namespace FoetexTrygLevering.Services
{
    interface IItemService
    {
        void Add(Item newItem);
        Item Search(int number);
        List<Item> SearchByName(string str);
        List<Item> SearchByDescription(string str);
        void Delete(int number);
        void Update(int number, Item theItem);
        List<Item> GetAll();
        void AssignID();
    }
}
