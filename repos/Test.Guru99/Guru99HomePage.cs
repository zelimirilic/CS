using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test.Guru99
{
    public class Guru99HomePage
    {
        IWebDriver driver;

            By HomePageUserName = By.XPath("//table//tr[@class='heading3']");

        public Guru99HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

       

        public string getHomePageDashboardUserName()
        {
            return driver.FindElement(HomePageUserName).Text;
        }

    }
}
