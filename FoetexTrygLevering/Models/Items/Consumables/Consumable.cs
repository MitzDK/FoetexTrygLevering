using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Items.Consumables
{
    public abstract class Consumable : Item
    {
        public int ExpDate { get; set; }

        public Consumable()
        {
            
        }

        protected Consumable(int expDate)
        {
            ExpDate = expDate;
        }
    }
}
