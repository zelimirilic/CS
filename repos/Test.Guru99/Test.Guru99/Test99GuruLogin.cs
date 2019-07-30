using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Guru99;





namespace Test.Guru99
{
    
    class Test99GuruLogin
    {
        
        IWebDriver driver;
        Guru99Login objLogin;
        Guru99HomePage objHomePage;

        [Test]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait.Seconds.Equals(10);
            driver.Navigate().GoToUrl("http://demo.guru99.com/V4/");
        }
        [Test]
        public void Test_Home_Page_Appear_Correct()
        {
            
            objLogin = new Guru99Login(driver);
            string loginPageTitle = objLogin.getLoginTitle();
            Assert.True(loginPageTitle.ToLower().Contains("guru99 bank"));
            objLogin.loginToGuru99("mgr123", "mgr!23");
            objHomePage = new Guru99HomePage(driver);
            Assert.True(objHomePage.getHomePageDashboardUserName().ToLower().Contains("manger id : mgr123"));

        }

    }
}
