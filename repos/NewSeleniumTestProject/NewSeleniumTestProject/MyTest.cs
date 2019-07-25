using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NewSeleniumTestProject
{
    public class MyTest
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void myTest()
        {
            driver.Navigate().GoToUrl("https://www.swtestacademy.com/");
            driver.Manage().Window.Maximize();
            Assert.AreEqual("Software Test Academy", driver.Title);
            driver.Close();
            driver.Quit();
        }
    }
}
