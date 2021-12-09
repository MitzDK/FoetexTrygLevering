using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Items;
using FoetexTrygLevering.Models.Order;
using FoetexTrygLevering.Models.Users;
using Microsoft.AspNetCore.Hosting;

namespace FoetexTrygLevering.Services
{
    public class JsonFileService
    {
        private List<Beverage> _beverages = new List<Beverage>();
        private List<Food> _foods = new List<Food>();
        private List<NonFood> _nonFoods = new List<NonFood>();

        private List<Admin> _admins = new List<Admin>();
        private List<Customer> _customers = new List<Customer>();
        private List<DeliveryDriver> _deliveryDrivers = new List<DeliveryDriver>();

        private List<Order> _doneOrders = new List<Order>();
        private List<Order> _pendingOrders = new List<Order>();

        public List<User> CombineUsers(List<Admin> admins, List<Customer> customers, List<DeliveryDriver> deliveryDrivers)
        {
            List<User> userList = new List<User>();
            foreach (Admin adm in admins)
            {
                userList.Add(adm);
            }
            foreach (Customer cus in customers)
            {
                userList.Add(cus);
            }
            foreach (DeliveryDriver deliv in deliveryDrivers)
            {
                userList.Add(deliv);
            }
            return userList;
        }

        public List<Item> CombineItems(List<Beverage> beverages, List<Food> foods, List<NonFood> nonFoods)
        {
            List<Item> itemList = new List<Item>();
            foreach (Beverage bev in beverages)
            {
                itemList.Add(bev);
            }
            foreach (Food food in foods)
            {
                itemList.Add(food);
            }
            foreach (NonFood nonfood in nonFoods)
            {
                itemList.Add(nonfood);
            }
            return itemList;
        }

        public void SplitItems(List<Item> itemList)
        {
            foreach (Item item in itemList)
            {
                if (item is Beverage)
                {
                    _beverages.Add((Beverage)item);
                }
                if (item is Food)
                {
                    _foods.Add((Food)item);
                }
                if (item is NonFood)
                {
                    _nonFoods.Add((NonFood)item);
                }
            }
        }
        public void SplitUsers(List<User> users)
        {
            foreach (User user in users)
            {
                if (user is Admin)
                {
                    _admins.Add((Admin)user);
                }
                if (user is Customer)
                {
                    _customers.Add((Customer)user);
                }
                if (user is DeliveryDriver)
                {
                    _deliveryDrivers.Add((DeliveryDriver)user);
                }
            }
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileItemBeverageName
        {
            get{ return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Items", "ItemBeverages.json"); }
        }
        private string JsonFileItemFoodName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Items", "ItemFoods.json"); }
        }
        private string JsonFileItemNonFoodName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Items", "ItemNonFoods.json"); }
        }
        private string JsonFileUserAdminName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Users", "UserAdmins.json"); }
        }
        private string JsonFileUserCustomerName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Users", "UserCustomers.json"); }
        }
        private string JsonFileUserDeliveryDriversName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Users", "UserDeliveryDrivers.json"); }
        }
        private string JsonFileOrderName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Orders", "Orders.json"); }
        }

        private string JsonFilePendingOrderName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Orders", "PendingOrders.json"); }
        }

        public void SaveOrders(List<Order> orders)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileOrderName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Order[]>(jsonWriter, orders.ToArray());
            }
        }

        public void SavePendingOrders(List<Order> orders)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFilePendingOrderName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Order[]>(jsonWriter, orders.ToArray());
            }
        }

        public void SaveItemBeverages(List<Beverage> beverageItems)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileItemBeverageName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Beverage[]>(jsonWriter, _beverages.ToArray());
            }
        }
        public void SaveItemFoods(List<Food> foodItems)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileItemFoodName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Food[]>(jsonWriter, _foods.ToArray());
            }
        }
        public void SaveItemNonFoods(List<NonFood> nonFoods)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileItemNonFoodName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<NonFood[]>(jsonWriter, _nonFoods.ToArray());
            }
        }
        public void SaveUserAdmins(List<Admin> admins)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileUserAdminName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Admin[]>(jsonWriter, _admins.ToArray());
            }
        }
        public void SaveUserCustomers(List<Customer> customers)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileUserCustomerName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Customer[]>(jsonWriter, _customers.ToArray());
            }
        }
        public void SaveUserDeliveryDrivers(List<DeliveryDriver> deliveryDrivers)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileUserDeliveryDriversName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<DeliveryDriver[]>(jsonWriter, _deliveryDrivers.ToArray());
            }
        }

        public void SaveJsonItems(List<Item> itemList)
        {
            SplitItems(itemList);
            SaveItemBeverages(_beverages);
            SaveItemFoods(_foods);
            SaveItemNonFoods(_nonFoods);
            _beverages.Clear();
            _foods.Clear();
            _nonFoods.Clear();
        }
        public void SaveJsonUsers(List<User> userList)
        {
            SplitUsers(userList);
            SaveUserAdmins(_admins);
            SaveUserCustomers(_customers);
            SaveUserDeliveryDrivers(_deliveryDrivers);
            _admins.Clear();
            _customers.Clear();
            _deliveryDrivers.Clear();
        }


        public IEnumerable<Order> GetOrders()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileOrderName))
            {
                return JsonSerializer.Deserialize<Order[]>(jsonFileReader.ReadToEnd());
            }
        }

        public IEnumerable<Order> GetPendingOrders()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFilePendingOrderName))
            {
                return JsonSerializer.Deserialize<Order[]>(jsonFileReader.ReadToEnd());
            }
        }
        public IEnumerable<Beverage> GetBeverageItems()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileItemBeverageName))
            {
                return JsonSerializer.Deserialize<Beverage[]>(jsonFileReader.ReadToEnd());
            }
        }
        public IEnumerable<Food> GetFoodItems()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileItemFoodName))
            {
                return JsonSerializer.Deserialize<Food[]>(jsonFileReader.ReadToEnd());
            }
        }
        public IEnumerable<NonFood> GetNonFoodItems()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileItemNonFoodName))
            {
                return JsonSerializer.Deserialize<NonFood[]>(jsonFileReader.ReadToEnd());
            }
        }

        public IEnumerable<Admin> GetAdminUsers()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileUserAdminName))
            {
                return JsonSerializer.Deserialize<Admin[]>(jsonFileReader.ReadToEnd());
            }
        }
        public IEnumerable<Customer> GetCustomerUsers()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileUserCustomerName))
            {
                return JsonSerializer.Deserialize<Customer[]>(jsonFileReader.ReadToEnd());
            }
        }
        public IEnumerable<DeliveryDriver> GetDeliverDriverUsers()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileUserDeliveryDriversName))
            {
                return JsonSerializer.Deserialize<DeliveryDriver[]>(jsonFileReader.ReadToEnd());
            }
        }

        public List<Order> GetJsonOrders()
        {
            return GetOrders().ToList();
        }

        public List<Order> GetJsonPendingOrders()
        {
            return GetPendingOrders().ToList();
        }
        public List<Item> GetJsonItems()
        {
            return CombineItems(GetBeverageItems().ToList(), GetFoodItems().ToList(), GetNonFoodItems().ToList());
        }

        public List<User> GetJsonUsers()
        {
            return CombineUsers(GetAdminUsers().ToList(), GetCustomerUsers().ToList(),
                GetDeliverDriverUsers().ToList());
        }
    }
}
