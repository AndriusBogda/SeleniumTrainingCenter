using OpenQA.Selenium;

namespace SeleniumTrainingCenter.Pages
{
    public class GmailPage : MailPage
    {
        public GmailPage(IWebDriver driver, string url) : base(driver, url)
        {
        }

        public GmailPage Login(string email, string password)
        {
            string EMAIL_INPUT = "//input[@class='whsOnd zHQkBf' and @type='email']";
            string PASSWORD_INPUT = "//input[@name='password']";
            string NEXT_BUTTON = "//button[@class='VfPpkd - LgbsSe VfPpkd - LgbsSe - OWXEXe - k8QpJ VfPpkd - LgbsSe - OWXEXe - dgl2Hf nCP5yc AjY5Oe DuMIQc qfvgSe qIypjc TrZEUc lw1w4b']";

            GetElementByXPath(EMAIL_INPUT).SendKeys(email);
            GetElementByXPath(NEXT_BUTTON).Click();

            NEXT_BUTTON = "//button[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qfvgSe qIypjc TrZEUc lw1w4b']";

            GetElementByXPath(PASSWORD_INPUT).SendKeys(password);
            GetElementByXPath(NEXT_BUTTON).Click();

            return this;
        }
    }
}
