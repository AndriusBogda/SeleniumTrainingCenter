using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTrainingCenter
{
    public class Tests
    {
        [TestClass]
        public class EmailTestBase
        {
            protected const string _chromeDriverPath = @"C:\Users\AndriusBogda\Desktop\chromedriver_win32 (1)";
            protected IWebDriver _driver;

            [TestInitialize]
            public void Initialize()
            {
                _driver = new ChromeDriver(_chromeDriverPath);
            }

            [TestCleanup]
            public void CleanUp()
            {
                _driver.Close();
                _driver.Dispose();
            }
        }
    }
}