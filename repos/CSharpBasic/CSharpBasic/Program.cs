using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        public static void Main(string[] args)
        {

            NonGenericCollection();

            Console.Read();
            
        }
        public static void ArrayExample()
        {
            string[] testcaseName = new string[] {"UserForm", "Login" }; 
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
    }
}
