using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace SeleniumTrainingCenter.Tests
{
    public class FirefoxTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var option = new FirefoxOptions();
            Setup(option);
        }
    }
}
