using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.PageObjects;

namespace SeleniumTrainingCenter.Tests
{
    [TestClass]
    public class YandexTest : BaseTest
    {
        string _mail = "SeleniumTestAndrius";
        string _password = "Qwe123rty456!";

        string YANDEX_MAIL_URL = @"https://mail.yandex.com/";

        [Test]
        public void TestLogin()
        {
            var INBOX_BUTTON = "//span[text()='Inbox']";

            var loginPage = new YandexPage(Driver, YANDEX_MAIL_URL); 

            var loggedInYandex = loginPage.Login(_mail, _password);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(loggedInYandex.DoesElementExist(INBOX_BUTTON), "Could not find Inbox button in Yandex mail");
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
