using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.Pages;

namespace SeleniumTrainingCenter
{
    [TestClass]
    public class DynamicDataTest : BaseTest
    {
        [Test]
        public void TestWaitForDynamicData()
        {
            string DYNAMIC_DATA = "//div[@id='loading']";
            string BUTTON = "//button[@class='btn btn-default']";

            string URL = @"https://demo.seleniumeasy.com/dynamic-data-loading-demo.html";

            var dynamicDataPage = new DynamicDataPage(Driver, URL);
            var generatedNewDataPage = dynamicDataPage.GenerateNewDataByButton(BUTTON);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(generatedNewDataPage.IsDynamicElementLoaded(DYNAMIC_DATA));
        }

        [Test]
        public void TestWaitForDownload()
        {
            string DYNAMIC_DATA = "//div[@class='percenttext']";
            string BUTTON = "//button[@class='btn btn-block btn-primary']";

            string URL = @"https://demo.seleniumeasy.com/bootstrap-download-progress-demo.html";

            var dynamicDataPage = new DynamicDataPage(Driver, URL);
            var generatedNewDataPage = dynamicDataPage.GenerateNewDataByButton(BUTTON);
            if (generatedNewDataPage.HasDynamicDataTextReachedValue(DYNAMIC_DATA, 50))
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(true);
                return;
            }

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
        }
    }
}
