using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.MockData;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.Services
{
    public class UserService : IUserService
    {
        private List<User> _userList;
        private JsonFileService JsonFileService { get; set; }

        public UserService(JsonFileService jsonFileService)
        {
            JsonFileService = jsonFileService;
            //Udkommenter og brug den nedenunder, hvis du vil bruge Json data istedet for Mock Data
            _userList = UserMockData.GetItems();
            //Udkommenter og brug den ovenover, hvis du vil bruge Mock Data istedet
            //_items = JsonFileService.GetJsonItems().ToList();
        }

        public void Add(User newItem)
        {
            _userList.Add(newItem);
        }

        public User Search(int number)
        {
            foreach (User user in _userList)
            {
                if (number == user.UserID)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> SearchByName(string str)
        {
            List<User> searchList = new List<User>();
            if (string.IsNullOrEmpty(str)) return _userList;
            foreach (User user in _userList)
            {
                if (user.Name.ToLower().Contains(str.ToLower()))
                {
                    searchList.Add(user);
                }
            }
            return searchList;
        }

        public List<User> SearchByPhone(string str)
        {
            List<User> searchList = new List<User>();
            if (string.IsNullOrEmpty(str)) return _userList;
            foreach (User user in _userList)
            {
                if (user.Phone.ToLower().Contains(str.ToLower()))
                {
                    searchList.Add(user);
                }
            }
            return searchList;
        }

        public List<User> SearchByEmail(string str)
        {
            List<User> searchList = new List<User>();
            if (string.IsNullOrEmpty(str)) return _userList;
            foreach (User user in _userList)
            {
                if (user.Email.ToLower().Contains(str.ToLower()))
                {
                    searchList.Add(user);
                }
            }
            return searchList;
        }

        public void Delete(int number)
        {
            _userList.RemoveAt(number - 1);
            AssignID();
            JsonFileService.SaveJsonUsers(_userList);
        }

        public void Update(int number, User theUser)
        {
            User searchUser = Search(number);
            searchUser = theUser;
            JsonFileService.SaveJsonUsers(_userList);
        }

        public List<Admin> GetAllAdmins()
        {
            List<Admin> adminList = new List<Admin>();
            foreach (User user in GetAll())
            {
                if (user is Admin)
                {
                    adminList.Add((Admin)user);
                }
            }
            return adminList;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            foreach (User user in GetAll())
            {
                if (user is Customer)
                {
                    customerList.Add((Customer)user);
                }
            }
            return customerList;
        } 

        public List<DeliveryDriver> GetAllDrivers()
        {
            List<DeliveryDriver> deliveryList = new List<DeliveryDriver>();
            foreach (User user in GetAll())
            {
                if (user is DeliveryDriver)
                {
                    deliveryList.Add((DeliveryDriver)user);
                }
            }

            return deliveryList;
        }

        public List<User> GetAll()
        {
            return _userList;
        }

        public void AssignID()
        {
            foreach (User user in _userList)
            {
                user.UserID = _userList.IndexOf(user) + 1;
            }
        }
    }
}
