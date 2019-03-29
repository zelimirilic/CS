using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Item> newItem = Item.GetItems(20);
            foreach(Item n in newItem)
            Console.WriteLine("New item ID = {0}, name = {1}", n.ID, n.Name);
        }

    
    }
}
