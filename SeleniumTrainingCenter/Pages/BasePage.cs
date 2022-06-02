using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTrainingCenter.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;
        protected IWebElement GetElementByXPath(string xPath)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
        }
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public BasePage(IWebDriver driver, string url) : this(driver)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
