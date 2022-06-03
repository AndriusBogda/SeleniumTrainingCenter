using OpenQA.Selenium;
using SeleniumTrainingCenter.PageObjects.PageInterfaces;
using System;

namespace SeleniumTrainingCenter.PageObjects
{
    public class YandexPage : PageBase, IMailPage
    {
        string _mail = "SeleniumTestAndrius";
        string _password = "Qwe123rty456!";

        string YANDEX_MAIL_URL = @"https://mail.yandex.com/";

        By LOGIN_FIRST_BUTTON = By.XPath("//a//span[@class='button2__text' and text()='Log in']");
        By LOGIN_USERNAME_INPUT = By.XPath("//input[@name='login']");
        By LOGIN_PASSWORD_INPUT = By.XPath("//input[@name='passwd']");
        By LOGIN_SECOND_BUTTON = By.XPath("//*[@id='passp:sign-in']");

        By PROFILE_PICTURE = By.CssSelector("div.user-pic user-pic_has-plus_ user-account__pic");
        By LOGOUT_BUTTON = By.XPath("//span[@class='menu__text' and text()='Log out']");

        public YandexPage(IWebDriver driver, string url) : base(driver, url)
        {
        }

        public IMailPage Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public IMailPage Logout()
        {
            throw new NotImplementedException();
        }
    }
}
