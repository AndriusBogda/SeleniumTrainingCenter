using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumTrainingCenter.Tests
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
            try
            {
                _driver = new RemoteWebDriver(new System.Uri("http://localhost:4444/wd/hub/"), new ChromeOptions());
            }
            catch
            {
                throw new System.Exception("wrong url for remote web driver");
            }
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}