using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumTestForEA.Pages
{
    class UserformPage
    {
        private IWebDriver _driver;

        public UserformPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement txtInitial => _driver.FindElement(By.Id("Initial"));
        public IWebElement txtFirstName => _driver.FindElement(By.Id("FirstName"));
        public IWebElement txtLastName => _driver.FindElement(By.Id("MiddleName"));
        public IWebElement chkLanguageHimdi => _driver.FindElement(By.Name("Hindi"));

        public void EnterUserForm(string initial, string firstName, string middleName, string language)
        {
            txtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtLastName.SendKeys(middleName);
            chkLanguageHimdi.Click();
        }


    }
}
