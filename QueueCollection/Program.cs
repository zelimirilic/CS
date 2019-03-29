using System;
using System.Collections.Generic;


namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<int>();
            myQueue.Enqueue(100);
            int val = myQueue.Dequeue();
            //Console.WriteLine("val: {0}", val);

            for(int i=0; i<50; i++)
            {
                myQueue.Enqueue(i);
               //myQueue.Dequeue();
            }
            foreach(int n in myQueue)
            {
                Console.WriteLine("{0}, ", n);
            }
            var whichValue = myQueue.Dequeue();
            whichValue = myQueue.Dequeue();
            whichValue = myQueue.Dequeue();
            Console.WriteLine("\nDequeued value: {0}", whichValue);

            foreach(int n in myQueue)
            {
                Console.WriteLine("{0}, ", n);
            }
            whichValue = myQueue.Dequeue();
            Console.WriteLine("\nDequeued value: {0}", whichValue);

             foreach(int n in myQueue)
            {
                Console.WriteLine("{0}, ", n);
            }
        }
    }
}
