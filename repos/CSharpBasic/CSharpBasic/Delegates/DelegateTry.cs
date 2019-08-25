using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Delegates
{
    //Declaration delegates
    delegate void Printer(string printValue);
    class DelegateTry
    {
        public static void PrintValue(string values)
        {
            Console.WriteLine($"The value is {values}.");
        }
        
        
    }
}
