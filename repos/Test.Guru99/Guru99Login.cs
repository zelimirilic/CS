using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Test.Guru99
{
    public class Guru99Login
    {
        IWebDriver driver;
        By user99GuruName = By.Name("uid");
        By password99Guru = By.Name("password");
        By titleText = By.ClassName("barone");
        By login = By.Name("btnLogin");

        public Guru99Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void setUserName(string strUserName)
        {
            driver.FindElement(user99GuruName).SendKeys(strUserName);
        }
        public void setPassword(string strPassword)
        {
            driver.FindElement(password99Guru).SendKeys(strPassword);
        }
        public void clickLogin()
        {
            driver.FindElement(login).Click();
        }
        public string getLoginTitle()
        {
            return driver.FindElement(titleText).Text;
        }
        public void loginToGuru99(string strUserNamme, string strPassword)
        {
            this.setUserName(strUserNamme);
            this.setPassword(strPassword);
            this.clickLogin();
        }

    }
}
