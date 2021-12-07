using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Items
{
    public class Item
    {
        [Display(Name = "Item name")]
        [Required(ErrorMessage = "A name is required"), MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "Item Price")]
        [Required(ErrorMessage = "A price is required")]
        [Range(typeof(double), "0", "100000", ErrorMessage = "Prisen skal være mellem {1} og {2}")]
        public double Price { get; set; }


        public int ID { get; set; }

        [Display(Name = "Item description")]
        [Required(ErrorMessage = "A description is required"), MaxLength(10000000)]
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
        public Item(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
