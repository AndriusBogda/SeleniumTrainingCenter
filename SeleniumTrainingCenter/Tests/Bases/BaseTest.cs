using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace SeleniumTrainingCenter.Tests
{
    public class BaseTest
    {
        private static IWebDriver _driver;

        private readonly string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private readonly string _screenshotPath = @$"{_projectDirectory}\Screenshots";

        protected static IWebDriver Driver
        {
            get => _driver;
        }

        protected string SSPath
        {
            get => _screenshotPath;
        }
        //[SetUp]
        protected static void Setup(DriverOptions driverOptions)
        {
            var browserOptions = driverOptions;
            browserOptions.PlatformName = "Windows 10";
            browserOptions.BrowserVersion = "latest";

            var sauceOptions = new Dictionary<string, object>();
            //sauceOptions.Add("name", TestContext.TestName);
            sauceOptions.Add("username", Environment.GetEnvironmentVariable("SauceLabsMyUsername", EnvironmentVariableTarget.User));
            sauceOptions.Add("accessKey", Environment.GetEnvironmentVariable("SauceLabsMyAccessKey", EnvironmentVariableTarget.User));

            browserOptions.AddAdditionalOption("sauce:options", sauceOptions);
            var sauceUrl = new Uri("https://ondemand.eu-central-1.saucelabs.com/wd/hub");

            _driver = new RemoteWebDriver(sauceUrl, browserOptions);
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}