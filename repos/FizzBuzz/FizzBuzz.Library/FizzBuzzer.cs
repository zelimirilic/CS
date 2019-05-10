using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {

            string output = null;

            if (input % 3 == 0 && input % 5 == 0)
                output += "FizzBuzz";
            else if (input % 3 == 0)
                output += "Fizz";
            else if (input % 5 == 0)
                output += "Buzz";
            else
            {
                output = input.ToString();
            }

            return output;
        }

    }
}
