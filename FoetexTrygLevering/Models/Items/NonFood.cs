using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Items
{
    public class NonFood : Item
    {
        public bool AgeRestriction { get; set; }

        public NonFood()
        {
            
        }

        public NonFood(int id, string name, double price, string description, bool ageRestriction) : base(id, name, price, description)
        {
            AgeRestriction = ageRestriction;
        }
    }
}