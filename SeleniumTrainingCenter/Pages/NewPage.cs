using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTrainingCenter.Pages
{
    public class NewPage : BasePage
    {
        public IWebDriver Driver
        {
            get => base._driver;
        }
        public string Url
        {
            get => base._driver.Url;
            set => base._driver.Navigate().GoToUrl(value);
        }

        private IWebElement GetElementByXPath(string xPath)
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 10));

            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xPath)));
        }

        public void SendKeysByXPath(string xPath, string content)
        {
            GetElementByXPath(xPath).SendKeys(content);
        }

        public void ClickElementByXPath(string xPath)
        {
            GetElementByXPath(xPath).Click();
        }

        public string GetElementTextByXPath(string xPath)
        {
            return GetElementByXPath(xPath).Text;
        }

        public NewPage(IWebDriver driver, string url) : base(driver)
        {
            Url = url;
        }
    }
}