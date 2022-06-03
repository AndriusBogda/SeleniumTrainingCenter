using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTrainingCenter.PageObjects
{
    public class PageBase
    {
        protected IWebDriver _driver;

        protected virtual IWebElement GetElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public PageBase(IWebDriver driver)
        {
            _driver = driver;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public PageBase(IWebDriver driver, string url) : this(driver)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
