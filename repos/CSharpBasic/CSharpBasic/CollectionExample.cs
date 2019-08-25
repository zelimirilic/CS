using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class CollectionExample
    {
        public static void ArrayExample()
        {
            string[] testcaseName = new string[] { "UserForm", "Login" };
        }
        public static void NonGenericCollection()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "ab");
            table.Add("Password", "ab123");
            table.Add("Button", "Submit");
            table.Add("Comment", "Ready");

            foreach (var key in table.Keys)
            {
                Console.WriteLine("The value for " + key + " is : " + table[key]);
            }
        }
        public static void GenericCollection()
        {
            string[] user1 = new string[] { "Lena", "12", "lena2006@gmail.com", "063/7340280" };
            string[] user2 = new string[] { "Snezana", "32", "snezanilic@gmail.com", "063/207779" };
            string[] user3 = new string[] { "Nikolina", "9", "nikolina2010@gmail.com", "062/1017508" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]> { };

            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);

            foreach (var value in dict)
            {
                string[] userInfo = value.Value;
                foreach (var user in userInfo)
                {
                    Console.WriteLine(user);
                }
            }

        }
        public static void GenericCollectionWithCustomClass()
        {
            List<User> users = new List<User>();
            users.Add(new User { UserId = 1001, Name = "Prva", Age = 11, Email = "mail1@gmail.com", Phone = 11112233, Addresses = new Address { Street = "SomeStreet1", Country="Serbia", FlatName="Promaja"} });
            users.Add(new User { UserId = 1002, Name = "Druga", Age = 12, Email = "mail2@gmail.com", Phone = 222226587, Addresses = new Address { Street = "SomeStreet2", Country = "Hungary", FlatName = "Promaja" } });
            users.Add(new User { UserId = 1003, Name = "Treca", Age = 13, Email = "mail3@gmail.com", Phone = 333335698, Addresses = new Address { Street = "SomeStreet3", Country = "Bulgaria", FlatName = "Promaja" } });
            users.Add(new User { UserId = 1004, Name = "Cetvrta", Age = 14, Email = "mail4@gmail.com", Phone = 444446985, Addresses = new Address { Street = "SomeStreet4", Country = "Rusia", FlatName = "Promaja" } });

            //foreach (var item in users)
            //{
            //    Console.WriteLine("The user {0}, with age {2} and email {3} has phone {4} and his name is {1}", item.UserId, item.Name, item.Age, item.Email, item.Phone);

            //}
            var userList = from user in users
                           where user.Age > 11 & user.Age < 14
                           select new { FirtsName = user.Name, Ages = user.Age, PhoneNumber = user.Phone, Address = user.Addresses };
            var userlist = users.Where(x => x.Age == 14).Select(x => x);

            foreach(var user in userList)
            {
                Console.WriteLine("The user {0} which is {1} years old has mobile phone which number is {2} and lives in {3}.", user.FirtsName, user.Ages, user.PhoneNumber, user.Address.Country);
            }
        }


    }
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public Address Addresses { get; set; }

    }
    public class Address
    {
        public string FlatName { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
    }
}
