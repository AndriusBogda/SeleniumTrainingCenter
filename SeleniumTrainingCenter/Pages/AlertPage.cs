using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTrainingCenter.Pages
{
    public class AlertPage : BasePage
    {
        public AlertPage OpenAlert(string xPath)
        {
            GetElementByXPath(xPath).Click();

            return this;
        }

        public bool IsAlertPresent()
        {
            IAlert GetAlertIsPresent()
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

                return wait.Until(ExpectedConditions.AlertIsPresent());
            }

            try
            {
                GetAlertIsPresent();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsAlertSameState(bool state)
        {
            bool GetAlertState(bool state)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));

                return wait.Until(ExpectedConditions.AlertState(state));
            }

            try
            {
                if (GetAlertState(state))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public AlertPage ConfirmAlert()
        {
            _driver.SwitchTo().Alert().Accept();

            return this;
        }

        public AlertPage ConfirmAlert(string text)
        {
            _driver.SwitchTo().Alert().SendKeys(text);
            _driver.SwitchTo().Alert().Accept();

            return this;
        }

        public AlertPage CancelAlert()
        {
            _driver.SwitchTo().Alert().Dismiss();

            return this;
        }

        public string GetConfirmBoxAnser(string xPath)
        {
            return GetElementByXPath(xPath).Text;
        }

        public AlertPage(IWebDriver driver, string url) : base(driver, url)
        {
        }
    }
}
