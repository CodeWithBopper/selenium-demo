using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Framework
{
    public class Driver
    {
        public ChromeDriver Browser;
        public string Title => Browser.Title;
        public string BaseUrl = "https://en.wikipedia.org/wiki/";


        public void Initialise()
        {
            var options = new ChromeOptions();
            options.AddArgument("--window-size=768x1368");
            Browser = new ChromeDriver("C:\\Users\\mjoinson\\source\\repos\\SeleniumTest\\SeleniumTest\\bin\\Debug", options);
        }

        public void BrowseTo(string url)
        {
            Browser.Navigate().GoToUrl(BaseUrl + url);
        }

        public void Dispose()
        {
            Browser?.Quit();
            Browser = null;
        }
    }
}
