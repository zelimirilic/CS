using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasic.Selenium;

namespace CSharpBasic.Browsers
{
    class IE : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the element in IE");
        }

        public void FindElement()
        {
            Console.WriteLine("Click the element in IE");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text " + keys);
        }

       
    }
}
