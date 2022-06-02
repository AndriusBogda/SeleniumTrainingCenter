using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SeleniumExtras.WaitHelpers;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumTrainingCenter.Entities;
using System.Linq;

namespace SeleniumTrainingCenter.Pages
{
    public class TablePage : BasePage
    {
        private ReadOnlyCollection<IWebElement> GetElementCollection(string cssSelector)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(cssSelector)));
        }
        public List<Employee> GetListOfEmployeesWhereAgeMoreAndSalaryLessOrEqual(string cssSelector, int age, int salary)
        {
            List<Employee> employees = new List<Employee>();
            Employee employee;

            // not sure how to dynamically get correct "td" elements
            var names = GetElementCollection($"{cssSelector} tr td:nth-of-type(6n+1)");
            var offices = GetElementCollection($"{cssSelector} tr td:nth-of-type(6n+2)");
            var positions = GetElementCollection($"{cssSelector} tr td:nth-of-type(6n+3)");
            var ages = GetElementCollection($"{cssSelector} tr td:nth-of-type(6n+4)");
            var salaries = GetElementCollection($"{cssSelector} tr td:nth-of-type(6n+6)");

            for (int i = 0; i < names.Count; i++)
            {
                if (Int32.Parse(ages[i].Text) > age && Int32.Parse(salaries[i].GetAttribute("data-order")) <= salary)
                {
                    employee = new
                    (
                        names[i].Text,
                        offices[i].Text,
                        positions[i].Text
                    );
                    employees.Add(employee);
                }
            }

            return employees;
        }
        public TablePage(IWebDriver driver) : base(driver) 
        { 
        }
        public TablePage(IWebDriver driver, string url) : base(driver, url)
        {
        }
    }
}
