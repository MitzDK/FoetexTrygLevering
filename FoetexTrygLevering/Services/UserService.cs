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
            throw new NotImplementedException();
        }

        public User Search(int number)
        {
            throw new NotImplementedException();
        }

        public List<User> SearchByName(string str)
        {
            throw new NotImplementedException();
        }

        public List<User> SearchByDescription(string str)
        {
            throw new NotImplementedException();
        }

        public void Delete(int number)
        {
            throw new NotImplementedException();
        }

        public void Update(int number, User theUser)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void AssignID()
        {
            throw new NotImplementedException();
        }
    }
}
