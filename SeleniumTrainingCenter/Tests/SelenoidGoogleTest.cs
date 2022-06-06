using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.PageObjects;
using System;
using System.IO;

namespace SeleniumTrainingCenter.Tests
{
    [TestClass]
    public class SelenoidGoogleTest : BaseTest
    {
        static readonly string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        static readonly string _screenshotPath = @$"{_projectDirectory}\Screenshots\";

        string GOOGLE_HOME_URL = @"https://google.com";

        [Test]
        public void TestTakeScreenshotOfGooglePage()
        {
            var SEARCH_INPUT = "//*[@name='q']";

            var homePage = new BasePage(Driver, GOOGLE_HOME_URL);
            // Can not use _screenshotPath here, it will not work, so I used hard coded path.
            homePage.TakeScreenshot(@"C:\Users\AndriusBogda\Desktop\");

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(homePage.DoesElementExist(SEARCH_INPUT), "Could not find search bar in google home page");
        }
    }
}
