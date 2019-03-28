namespace OOP
{
    class Item
    {
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get; set; }
        
        public static Item GetItem()
        {
            var newItem = new Item() {ID = 101, Name = "myItem"};
            return newItem;
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