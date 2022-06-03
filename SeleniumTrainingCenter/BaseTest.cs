using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTrainingCenter
{
    public class BaseTest
    {
        private static IWebDriver _driver;

        protected static IWebDriver Driver
        {
            get => _driver;
        }

        [SetUp]
        public static void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}