using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Threading.Tasks;
using SeleniumTrainingCenter.Pages;

namespace SeleniumTrainingCenter
{
    [TestClass]
    public class YandexTest : BaseTestClass
    {
        private string _login = "SeleniumTestAndrius";
        private string _password = "Qwe123rty456!";

        private async Task<NewPage> GetLoggedInYandexPage(string login, string password)
        {
            string YANDEX_URL = @"https://yandex.lt/";

            string LOGIN_BUTTON = "//*[@class='b-inline']";
            string LOGIN_TEXTFIELD = "//input[@id='passp-field-login']";
            string PASSWORD_TEXTFIELD = "//input[@id='passp-field-passwd']";
            string NEXT_BUTTON = "//button[@id='passp:sign-in']";

            var yandexPage = new NewPage(base._driver, YANDEX_URL);

            yandexPage.ClickElementByXPath(LOGIN_BUTTON);

            yandexPage.SendKeysByXPath(LOGIN_TEXTFIELD, login);

            yandexPage.ClickElementByXPath(NEXT_BUTTON);

            yandexPage.SendKeysByXPath(PASSWORD_TEXTFIELD, password);

            yandexPage.ClickElementByXPath(NEXT_BUTTON);

            return yandexPage;
        }

        [Test]
        public async Task TestYandexLogin()
        {
            string USERNAME_ELEMENT = "//*[@class='username']";

            var yandexPage = await GetLoggedInYandexPage(_login, _password);

            string AssertFailedMessage = "Could not log in Yangex mail with given username/password";

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(_login, yandexPage.GetElementTextByXPath(USERNAME_ELEMENT), AssertFailedMessage);
        }
    }
}
