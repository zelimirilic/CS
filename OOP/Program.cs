using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Item newItem = Item.GetItem();
            Console.WriteLine("\nNew item ID = {0}, name = {1}\n", newItem.ID, newItem.Name);
        }

    
    }
}
