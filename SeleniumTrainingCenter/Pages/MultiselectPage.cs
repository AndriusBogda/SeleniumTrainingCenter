using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumTrainingCenter.Pages
{
    public class MultiselectPage : BasePage
    {
        private ReadOnlyCollection<IWebElement> GetMultiselectOptionsCollectionByXPath(string xPath)
        {
            IWebElement multiselect = GetElementByXPath(xPath);

            return multiselect.FindElements(By.XPath($"{xPath}/option"));
        }

        public List<string> GetMultiselectOptionsByXPath(string xPath)
        {
            List<string> list = new();

            foreach (var element in GetMultiselectOptionsCollectionByXPath(xPath))
            {
                list.Add(element.Text);
            }

            return list;
        }

        public bool DoesOptionExist(string value)
        {
            string xPath = $"//option[@value='{value}']";

            return GetElementByXPath(xPath).Displayed;
        }

        public MultiselectPage(IWebDriver driver, string url) : base(driver, url)
        {
        }
    }
}
