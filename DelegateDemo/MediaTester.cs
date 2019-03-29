using System;

namespace DelegateDemo
{
    class MediaTester
    {
        public delegate int TestMedia();

        public void RunTest(TestMedia testDelegate)
        {
            int result = testDelegate();
            if(result == 0)
            {
                Console.Write("Success !!!");
            }
            else
            {
                Console.WriteLine("Failed...");
            }
        }

    }
}