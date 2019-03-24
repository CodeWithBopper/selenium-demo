using NUnit.Framework;
using Selenium.Framework;
using Selenium.Framework.Pages;

namespace SeleniumTest
{
    public class MainPageTests : BaseClass
    {
        public static Driver Driver;
        private MainPage _mainPage;

        [OneTimeSetUp]
        public override void OneTimeSetUp()
        {
            base.OneTimeSetUp();

            _mainPage = new MainPage(Driver);
        }

        [SetUp]
        public void SetUp()
        {
            Driver.BrowseTo("");
        }

        [Test]
        public void SelectTalkTab()
        {
            _mainPage.EnterValueIntoSearchBar("Kindle Fire");
            Assert.That(Driver.Title, Contains.Substring("Amazon.co.uk"));
        }
    }
}
