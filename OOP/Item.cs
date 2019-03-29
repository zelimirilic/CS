using System;
using System.Collections.Generic;

namespace OOP
{
    class Item
    {
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get; set; }
        
        public static List<Item> GetItems(int numToGet)
        {
            var random = new Random();
            var newList = new List<Item>();
            Item newItem;
            for(int i=0; i<numToGet; i++)
            {
            newItem = new Item() {ID = random.Next(), Name = "myItem" + i.ToString()};
            newList.Add(newItem);
            }
            return newList;
        }
    }
    class Software : Item
    {
        public string ISBN {get; set;}
    }
    class Hardware : Item {
        public string SerialNumber {get; set;}
    }
    class Computer : Hardware {
        public string CPUType {get; set;}
        public string Disks {get; set;}
    }
    class Peripheral : Hardware {
        string Description {get; set;}
    }
}