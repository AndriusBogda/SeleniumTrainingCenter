using OpenQA.Selenium;
using SeleniumTrainingCenter.PageObjects.PageInterfaces;
using System;

namespace SeleniumTrainingCenter.PageObjects
{
    public class YandexPage : BasePage, IMailPage
    {
        By LOGIN_INITIAL = By.XPath("//a[@class='control button2 button2_view_classic button2_size_mail-big button2_theme_mail-white button2_type_link HeadBanner-Button HeadBanner-Button-Enter with-shadow']");
        By LOGIN_USERNAME_INPUT = By.XPath("//input[@name='login']");
        By LOGIN_PASSWORD_INPUT = By.XPath("//input[@name='passwd']");
        By LOGIN_BUTTON = By.XPath("//*[@id='passp:sign-in']");

        By PROFILE_PICTURE = By.XPath("//div[@class='user-pic user-pic_has-plus_ user-account__pic']/img[@src]");
        By LOGOUT_BUTTON = By.XPath("//span[@class='menu__text' and text()='Log out']");

        public YandexPage(IWebDriver driver, string url) : base(driver, url)
        {
        }

        public IMailPage Login(string email, string password)
        {
            GetElement(LOGIN_INITIAL).Click();

            GetElement(LOGIN_USERNAME_INPUT).SendKeys(email);
            GetElement(LOGIN_BUTTON).Click();

            GetElement(LOGIN_PASSWORD_INPUT).SendKeys(password);
            GetElement(LOGIN_BUTTON).Click();

            return this;
        }

        public IMailPage Logout()
        {
            GetElement(PROFILE_PICTURE).Click();
            GetElement(LOGOUT_BUTTON).Click();

            return this;
        }
    }
}
