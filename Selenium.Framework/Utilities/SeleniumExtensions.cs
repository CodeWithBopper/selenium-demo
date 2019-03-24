using OpenQA.Selenium;

namespace Selenium.Framework.Utilities
{
    public static class SeleniumExtensions
    {
        public static void SendKeys(this IWebDriver driver, By selector, string value)
            {
                driver.FindElement(selector).SendKeys(value);
            }
        }
    }
}
