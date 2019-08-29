using System;
using CSharpBasic.Browsers;
using CSharpBasic.Selenium;
using CSharpBasic.ExstensionMethod;
using CSharpBasic.Delegates;

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

            //CollectionExample.GenericCollectionWithCustomClass();

            // delegates example
            //C# 1.0
            //Printer p = DelegateTry.PrintValue1;
            //p("Executing automation test.....");

            //C# 2.0
            //Printer p = delegate (string values)
            //{
            //    Console.WriteLine($"The value printed inline {values}");
            //};

            //p("Executing automation test.....");

            //C# 3.0
            //Printer p = (values) => { Console.WriteLine($"The value printed from Lambda Expressions is: {values}"); };
            //p("Executing AT again.....");

            Func<string, string> p = delegate(string values)
            {
                return values;
            };

            Console.WriteLine($"The value from Func<> is ovo! {p("Surprise !!!")}");

            Action<string> pp = delegate (string values)
            {
                Console.WriteLine($"The value from Func<> is this {values}");
            };
            pp("New surprice !!!");

            Action<string> pLambda = values => { Console.WriteLine($"The value from action Lambda is {values}"); };
            pLambda("Excellent surprise !!!");


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
