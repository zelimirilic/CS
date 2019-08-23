using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform operation
            element.SendKeys("executeautomation");
            Console.WriteLine("Executed test");
        }
        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
