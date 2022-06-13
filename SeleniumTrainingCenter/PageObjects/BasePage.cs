﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumTrainingCenter.PageObjects.PageInterfaces;
using System;

namespace SeleniumTrainingCenter.PageObjects
{
    public class BasePage : IPage
    {
        protected IWebDriver _driver;

        protected virtual IWebElement GetElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public bool DoesElementExist(string xPath)
        {
            try
            {
                GetElement(By.XPath(xPath));

                return true;
            }
            catch
            {
                return false;
            }
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
