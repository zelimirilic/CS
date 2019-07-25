using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample
{
    public class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchTextFromAboutPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            AboutPage about = home.goToAboutPage();
            ResultPage result = about.Search("selenium c#");
            result.ClickOnFirstArticle();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
