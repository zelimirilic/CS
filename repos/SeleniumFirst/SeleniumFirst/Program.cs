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
            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {

            //Login to App
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("Execute", "Automation");


            pageEA.FillUserForm("ZI", "Mr.", "Zeljko", "Adama");
            
           







            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", "Id");

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "Zeljko SvastaPiseBukvalno", "Name");

            //Console.WriteLine("The value from input Title is : " + SeleniumGetMethods.GetTextFromDDL("TitleId", "Id"));
            //Console.WriteLine("The value from input Initial is : " + SeleniumGetMethods.GetText("Initial", "Name"));

            ////First name
            //SeleniumSetMethods.EnterText("FirstName", "Zeljko", "Name");

            ////Middle Name
            //SeleniumSetMethods.EnterText("MiddleName", "Ilic","Name");

            ////Gender
            //SeleniumSetMethods.Click("Female", "Name");

            ////Languages
            //SeleniumSetMethods.Click("Hindi", "Name");

            ////Save
            //SeleniumSetMethods.Click("Save", "Name");
        }
        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }
        [TearDown]
        public void CleanUp()
        {
            //PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
