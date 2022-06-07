using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.PageObjects;
using System.IO;
using System;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;

namespace SeleniumTrainingCenter.Tests
{
    [TestFixture(Author = "Andrius Bogda", Description = "Test")]
    [AllureNUnit]
    [AllureLink("https://github.com/AndriusBogda/SeleniumTrainingCenter")]
    [TestClass]
    public class YandexTest : BaseTest
    {
        string _mail = "SeleniumTestAndrius";
        string _password = "Qwe123rty456!";

        static string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        static string _screenshotPath = @$"{_projectDirectory}\Screenshots\";

        string YANDEX_MAIL_URL = @"https://mail.yandex.com/";
        string YANDEX_HOME_URL = @"https://yandex.by/";

        //[Test]
        public void TestScreenshot()
        {
            var yandexHome = new BasePage(Driver, YANDEX_HOME_URL);

            yandexHome.TakeScreenshot(_screenshotPath);
        }

        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/AndriusBogda/SeleniumTrainingCenter")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void TestLogin()
        {
            var INBOX_BUTTON = "//span[text()='Inbox']";

            var loginPage = new YandexPage(Driver, YANDEX_MAIL_URL); 

            var loggedInYandex = loginPage.Login(_mail, _password);

            AllureLifecycle.Instance.WrapInStep(
                () => { Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(loggedInYandex.DoesElementExist(INBOX_BUTTON), "Could not find Inbox button in Yandex mail"); }, "Login in Yandex Mail attempt");
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(loggedInYandex.DoesElementExist(INBOX_BUTTON), "Could not find Inbox button in Yandex mail");
        }

        [Test]
        public void TestLogout()
        {
            var YANDEX_TITLE = "//*[text()='Sincerely yours']";

            var loginPage = new YandexPage(Driver, YANDEX_MAIL_URL);

            var loggedInYandex = loginPage.Login(_mail, _password);
            var loggedOutYandex = loggedInYandex.Logout();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(loggedOutYandex.DoesElementExist(YANDEX_TITLE), "Could not find Title in Yandex login page");
        }
    }
}
