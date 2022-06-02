using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTrainingCenter.Pages
{
    public class DynamicDataPage : BasePage
    {
        public bool IsDynamicDataTextPresent(string xPath, string text)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            return wait.Until(ExpectedConditions.TextToBePresentInElement(GetElementByXPath(xPath), text));
        }
        public bool HasDynamicDataTextReachedValue(string xPath, int value)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            return wait.Until(driver =>
                {
                    while (Int32.Parse(driver.FindElement(By.XPath(xPath)).Text.TrimEnd('%')) < value);

                    return true;
                });
        }
        public DynamicDataPage GenerateNewDataByButton(string xPath)
        {
            GetElementByXPath(xPath).Click();

            return this;
        }
        public bool IsDynamicElementLoaded(string xPath)
        {
            try
            {
                IsDynamicDataTextPresent(xPath, "First Name :");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public DynamicDataPage Refresh()
        {
            _driver.Navigate().Refresh();

            return this;
        }
        public DynamicDataPage(IWebDriver driver, string url) : base(driver, url)
        {
        }
    }
}
