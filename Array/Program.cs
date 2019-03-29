using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array {
    class Program {
        private const string Value = "ItemID = {0}, item.";

        static void Main (string[] args) {
            var items = new Item[5];
            Random r = new Random ();

            for (int i = 0; i < items.Length; i++) {
                items[i] = new Item (r.Next ());
            }

            Console.WriteLine ("Items : ");
            foreach (Item i in items) {
                Console.WriteLine ("ItemID = {0}", i.ID);
            }

            Item myItem = items[1];
            Console.WriteLine ("ID of second Item is: {0}", myItem.ID);

            var Authors = new String[5];
            Authors[0] = "Fokner";
            Authors[1] = "Andric";
            Authors[2] = "Selinger";
            Authors[3] = "Dostojevski";
            Authors[4] = "Selimovic";
            for(int i=0; i<Authors.Length; i++)
            {
            Console.WriteLine("Authors....{0}", Authors[i]);
            }
            foreach(String n in Authors)
            {
                Console.WriteLine(n);
            }

            


        }
    }
}