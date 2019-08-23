using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumTestForEA.Pages
{
    class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement txtUserName => _driver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => _driver.FindElement(By.Name("Password"));

        public IWebElement btnLogin => _driver.FindElement(By.Name("Login"));

        public void PerfomLogin(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }
    }
}
