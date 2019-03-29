using System;
using System.Collections.Generic;

namespace GenericList {
    class Program {
        static void Main (string[] args) {
            var r = new Random ();
            List<int> myList = new List<int> ();
            for (int i = 0; i < 10; i++) {
                myList.Add (r.Next ());
            }
            myList.Sort();
            foreach(int n in myList)
            {
            Console.WriteLine (n);
            }

        }
    }
}