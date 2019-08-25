using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasic.Selenium;

namespace CSharpBasic.Browsers
{
    class Firefox : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the element in Firefox");
        }

        public void FindElement()
        {
            Console.WriteLine("Find the element in Firefox");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text " + keys);
        }


    }
}
