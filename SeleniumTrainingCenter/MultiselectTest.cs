using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.Pages;

namespace SeleniumTrainingCenter
{
    [TestClass]
    public class MultiselectTest : BaseTest
    {
        [Test]
        public void TestMultiSelect()
        {
            string URL = @"https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
            string MULTISELECT = "//*[@id='multi-select']";

            var multiselectPage = new MultiselectPage(Driver, URL);

            var options = multiselectPage.GetMultiselectOptionsByXPath(MULTISELECT);

            foreach (var option in options)
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(multiselectPage.DoesOptionExist(option), "option could not be located");
            }
        }

        [Test]
        public void TestEmployeeList()
        {
            string URL = @"https://demo.seleniumeasy.com/table-sort-search-demo.html";

            string TABLE = "#example *";
            string DROPDOWN = "//*[@name='example_length']";

            var dropdownPage = new DropdownPage(Driver, URL);

            var selectedEntriesPage = dropdownPage.SelectValue(DROPDOWN, "10");
            var tablePage = new TablePage(Driver);

            var employees = tablePage.GetListOfEmployeesWhereAgeMoreAndSalaryLessOrEqual(TABLE, 0, int.MaxValue);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(employees.Count == 10);
        }
    }
}
