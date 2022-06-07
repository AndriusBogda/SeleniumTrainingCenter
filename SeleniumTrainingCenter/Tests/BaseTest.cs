using Allure.Commons;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTrainingCenter.Tests
{
    public class BaseTest
    {
        private static IWebDriver _driver;

        protected static IWebDriver Driver
        {
            get => _driver;
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public static void Setup()
        {
            _driver = new ChromeDriver();

            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}