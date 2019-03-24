using NUnit.Framework;
using Selenium.Framework;

namespace SeleniumTest
{
    [TestFixture]
    public class BaseClass
    {
        public Driver Driver;

        [OneTimeSetUp]
        public virtual void OneTimeSetUp()
        {
            Driver = new Driver();
            Driver.Initialise();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Dispose();
        }
    }
}
