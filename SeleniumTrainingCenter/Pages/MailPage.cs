using OpenQA.Selenium;

namespace SeleniumTrainingCenter.Pages
{
    public abstract class MailPage : BasePage
    {
        public MailPage(IWebDriver driver, string url) : base(driver, url)
        {
        }
    }
}
