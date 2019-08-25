using System;
using CSharpBasic.Browsers;
using CSharpBasic.Selenium;
using CSharpBasic.ExstensionMethod;

namespace CSharpBasic
{
    enum Browser
    {
        Chrome,
        Firefox,
        Mozzila,
        Opera,
        IE
    }
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(GetBrowserName(Browser.Chrome));    // Strongly type code

            //IWebDriver driver = new Chrome();
            //driver.SendKeyWithSpecChar("Text about automation testing", "!`~~`!");

            CollectionExample.GenericCollectionWithCustomClass();

            Console.ReadLine();
            
        }
        public static string GetBrowserName(Browser browser)
        {
            if(browser == Browser.Firefox)
            {
                return "Firefox is opened";
            }
            else if(browser == Browser.Chrome)
            {
                return "Chrome is opened";
            }
            else if (browser == Browser.Mozzila)
            {
                return "Mozzila is opened";
            }
            else if (browser == Browser.Opera)
            {
                return "Opera is opened";
            }
            else
            {
                return "IE is opened";
            }
        }
        
    }
}
