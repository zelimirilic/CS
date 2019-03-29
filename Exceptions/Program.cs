using System;



namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Method1();
        }
    }

    class Test
    {
        public void Method1() 
        {
            Console.WriteLine("M1 starts !");
            Method2();
            Console.WriteLine("M1 ends !");
        }
        public void Method2()
        {
            Console.WriteLine("M2 starts !");
            Method3();
            Console.WriteLine("M2 ends !");
        }
        public void Method3()
        {
            Console.WriteLine("M3 starts !");
            Console.WriteLine("File opened...");
            try
            {
            var x = 0;
            var y = 15/x;
            }
            catch(Exception e)
            {
                Console.WriteLine("Caught exception: {0}", e.Message);
            }
            finally
            {
            Console.WriteLine("File closed...");
            }
            Console.WriteLine("M3 ends !");
        }
    }
}
