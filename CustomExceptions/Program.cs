using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tester t = new Tester();
                double result = t.DoDivide(77,0);
                Console.WriteLine("Divide 77 and 0 is equal {0}", result);
                result = t.DoDivide(12,4);
                Console.WriteLine("Divide 12 and 4 is equal {0}", result);
                result = t.DoDivide(0,10);
                Console.WriteLine("Divide 0 and 10 is equal {0}", result);
                
            }
            catch(DivideBy0Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public class Tester
        {
            public double DoDivide(double x, double y)
            {
                if(y == 0)
                throw new DivideBy0Exception("You can not divide by 0 !!!");
                if(x == 0)
                throw new MyCustomException("Result can't be zero!");
                return x/y;
            }
        }
        public class MyCustomException : Exception
        {
            public MyCustomException(string message) : base(message)
            {

            }
        }
        public class DivideBy0Exception : Exception
        {
            public DivideBy0Exception(string message) : base(message)
            {
                //Console.WriteLine("You can not divide by 0 !!!");
            }
        }
    }
}
