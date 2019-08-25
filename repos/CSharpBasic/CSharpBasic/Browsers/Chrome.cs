using CSharpBasic.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Browsers
{
    class Chrome : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the UI element in Chrome");
        }

        public void FindElement()
        {
            Console.WriteLine("Find the element in Chrome");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text " + keys);
        }

    }
}
