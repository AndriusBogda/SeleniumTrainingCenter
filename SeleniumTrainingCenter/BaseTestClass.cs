using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTrainingCenter
{
    [TestClass]
    public class BaseTestClass
    {
        protected const string _chromeDriverPath = @"C:\Users\AndriusBogda\Desktop\chromedriver_win32 (1)";
        protected IWebDriver _driver;

        [SetUp]
        public void Initialize()
        {
            _driver = new ChromeDriver(_chromeDriverPath);
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Close();
            _driver.Dispose();
        }
    }
}