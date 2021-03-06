using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoetexTrygLevering.Models.Users;

namespace FoetexTrygLevering.MockData
{
    public class UserMockData
    {
        private static List<User> _users = new List<User>()
        {
             //Admin
            //int userId, string name, string phone, string email
            new Admin(2,"Victor Jejlskov","81611117", "Vict1452@edu.zealand.dk"),
            new Admin(3,"Andreas Broberg","51951164", "andr52j4@edu.zealand.dk"),
            new Admin(4,"Frederik Bressendorff", "20987041", "fred03q7@edu.zealand.dk"),
            new Admin(5,"Martin Lylloff","50523160","mart0c95@edu.zealand.dk"),
            new Admin(6,"Zacharias Hirsborg","29847447","zach0118@edu.zealand.dk"),
            
            //Customer
            //int userId, string name, string phone, string email, string address, int age
            new Customer(1, "Guest", "00000000", "123@email.com", "GuestCity", "GuestGade 91", 5683, 18),
            new Customer(7, "Kent Jørgen", "23568790", "KentJørgen@gmail.com", "København K", "Frørupvej 83", 1146, 65),
            new Customer(8, "Birgitte Thomsen", "12436986", "BThomsen@email.com", "København K", "Slipager 9", 1434, 45),
            new Customer(9, "Lars Karlsen", "43512389", "LArskoarlsen@email.com", "Skodsborg", "Hans Schacksvej 8", 2942, 32),
            new Customer(10, "Sebastian Jensen", "23567512", "Sebastian@email.com", "Terndrup", "Hovbanken 8",9575, 25),

            //Delivery Driver
            //int userID, string name, string phone, string email, int accNumber, int postalCode
            new DeliveryDriver(11,"Nansen M. Kristensen","52179934","NansenMKristensen@rhyta.com","3098345678",9390),
            new DeliveryDriver(12,"Mike F. Hansen","22743868","MikeFHansen@armyspy.com","5678453212",7870),
            new DeliveryDriver(13,"Julius C. Bak","25725490","JuliusCBak@teleworm.us","1245795632",1606),
            new DeliveryDriver(14,"Mathias S. Kristoffersen","20763813","MathiasSKristoffersen@teleworm.us","3257485698",1728),
            new DeliveryDriver(15,"Kasper T. Bach","21563739","KasperTBach@dayrep.com","7465231545",5000),
            new DeliveryDriver(16,"TestDriver", "00000000", "Test@test.com", "0000000000", 0000)
        };

        public static List<User> GetItems()
        {
            return _users;
        }
    }
}
