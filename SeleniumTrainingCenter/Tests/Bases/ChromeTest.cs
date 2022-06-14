using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumTrainingCenter.Tests
{
    public class ChromeTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var option = new ChromeOptions();
            Setup(option);
        }
    }
}
