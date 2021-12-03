using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoetexTrygLevering.Models.Users
{
    public string Address { get; set; }
    public string Age { get; set; }

    public DeliveryDriver(string address, string age)
    {
            Address = address;
            Age = age;
    }
}
