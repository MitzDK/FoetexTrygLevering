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

        public Item(int id, string name, double price, string description)
        {
            Name = name;
            Price = price;
            ID = id;
            Description = description;
        }
    }
}
