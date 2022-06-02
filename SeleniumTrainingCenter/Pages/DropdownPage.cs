using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTrainingCenter.Pages
{
    public class DropdownPage : BasePage
    {
        public DropdownPage SelectValue(string xPath, string value)
        {
            SelectElement select = new(GetElementByXPath(xPath));

            select.SelectByValue(value);

            return this;
        }
        public DropdownPage(IWebDriver driver, string url) : base(driver, url)
        {
        }
    }
}
