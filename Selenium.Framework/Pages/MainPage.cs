using OpenQA.Selenium;
using Selenium.Framework.Utilities;

namespace Selenium.Framework.Pages
{
    public class MainPage
    {
        private readonly Driver _driver;

        public MainPage(Driver driver)
        {
            _driver = driver;
        }

        public void EnterValueIntoSearchBar(string searchItem)
        {
            _driver.Browser.SendKeys(By.Id("twotabsearchtextbox"), searchItem);
        }
    }
}
