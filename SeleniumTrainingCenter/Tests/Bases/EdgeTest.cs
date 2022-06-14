using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace SeleniumTrainingCenter.Tests
{
    public class EdgeTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var option = new EdgeOptions();
            Setup(option);
        }
    }
}
