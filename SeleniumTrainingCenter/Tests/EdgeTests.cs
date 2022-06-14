using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.PageObjects;

namespace SeleniumTrainingCenter.Tests
{
    [TestClass]
    public class EdgeTests : EdgeTest
    {
        string GOOGLE_HOME_URL = @"https://google.com";

        [Test]
        public void Test()
        {
            var SEARCH_INPUT = "//*[@name='q']";

            var homePage = new BasePage(Driver, GOOGLE_HOME_URL);
            homePage.TakeScreenshot(SSPath);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(homePage.DoesElementExist(SEARCH_INPUT), "Could not find search bar in google home page");
        }
    }
}
