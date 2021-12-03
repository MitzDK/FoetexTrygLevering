using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }

        public Item()
        {
            
        }

        protected Item(string name, double price, int id, string description)
        {
            Name = name;
            Price = price;
            ID = id;
            Description = description;
        }
    }
}
