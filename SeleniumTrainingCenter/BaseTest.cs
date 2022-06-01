using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTrainingCenter
{
    public class BaseTest
    {
        private static readonly IWebDriver _driver = new ChromeDriver();

        protected static IWebDriver Driver
        {
            get => _driver;
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}