using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Items
{
    public class Food : Item
    {
        public Food()
        {
            
        }

        public Food(int id, string name, double price, string description) : base(id, name, price, description)
        {
            
        }
        public Food(int id, string name, double price, string description, string imageName) : base(id, name, price, description, imageName)
        {

        }
        public Food(string name, double price, string description) : base(name, price, description)
        {

        }
    }
}