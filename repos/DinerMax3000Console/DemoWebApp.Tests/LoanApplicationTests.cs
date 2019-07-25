using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DemoWebApp.Tests
{
    public class LoanApplicationTests
    {
        [Fact]

        public void StartApplication()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();
        }
    }
}
