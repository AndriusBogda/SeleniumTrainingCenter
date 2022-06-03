using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTrainingCenter.Pages
{
    public class GmailPage : MailPage
    {
        public GmailPage(IWebDriver driver, string url) : base(driver, url)
        {
        }

        public override GmailPage Login(string email, string password)
        {
            string EMAIL_INPUT = "//input[@class='whsOnd zHQkBf' and @type='email']";
            string PASSWORD_INPUT = "//input[@name='password']";
            string NEXT_BUTTON = "//span[text()='Kitas']";

            GetElementByXPath(EMAIL_INPUT).SendKeys(email);
            GetElementByXPath(NEXT_BUTTON).Click();

            GetElementByXPath(PASSWORD_INPUT).SendKeys(password);
            GetElementByXPath(NEXT_BUTTON).Click();

            return this;
        }

        public string GetLoggedInUserEmail()
        {
            string ICON_ELEMENT = "//*[@class='gb_Ba gbii']";
            string EMAIL_ELEMENT = "//*[@class='DmBVvf ZWVAt']";

            IWebElement TryGetEmail()
            {
                WebDriverWait wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(10));

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(ICON_ELEMENT))).Click();

                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(EMAIL_ELEMENT)));   // CANT LOCATE ELEMENT
            }

            return TryGetEmail().Text;
        }
    }
}
