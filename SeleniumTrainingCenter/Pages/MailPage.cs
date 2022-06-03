using OpenQA.Selenium;

namespace SeleniumTrainingCenter.Pages
{
    public abstract class MailPage : BasePage
    {
        public abstract GmailPage Login(string email, string password);
        public MailPage(IWebDriver driver, string url) : base(driver, url)
        {
        }
    }
}
