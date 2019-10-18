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
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Ms.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "Zeljko SvastaPise", "Id");

            //First name
            SeleniumSetMethods.EnterText(driver, "FirstName", "Zeljko", "Name");

            //Middle Name
            SeleniumSetMethods.EnterText(driver, "MiddleName", "Ilic","Name");

            //Gender
            SeleniumSetMethods.Click(driver, "Female", "Name");

            //Languages
            SeleniumSetMethods.Click(driver, "Hindi", "Name");

            //Save
            SeleniumSetMethods.Click(driver, "Save", "Name");
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
