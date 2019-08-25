using CSharpBasic.Selenium;

namespace CSharpBasic.ExstensionMethod
{
    public static class WebDriverExtension
    {

        public static void SendKeyWithSpecChar(this IWebDriver driver, string key, string specChar)
        {
            driver.SendKeys(key);
            driver.SendKeys(specChar);
        }
    }
}
