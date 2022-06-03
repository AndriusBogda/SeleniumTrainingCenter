using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.Pages;

namespace SeleniumTrainingCenter
{
    [TestClass]
    public class AlertTest : BaseTest
    {
        private AlertPage alertPage;

        [SetUp]
        public void SetupTwo()
        {
            string URL = @"https://demo.seleniumeasy.com/javascript-alert-box-demo.html";

            alertPage = new AlertPage(Driver, URL);
        }

        [Test]
        public void TestAlertIsPresent()
        {
            string BUTTON = "//button[@class='btn btn-default']";

            var OpenedAlertOnPage = alertPage.OpenAlert(BUTTON);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(OpenedAlertOnPage.IsAlertPresent());
        }

        [Test]
        public void TestAlertStateTrue()
        {
            string BUTTON = "//button[@class='btn btn-default']";

            var OpenedAlertOnPage = alertPage.OpenAlert(BUTTON);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(OpenedAlertOnPage.IsAlertSameState(true));
        }

        [Test]
        public void TestAlertStateFalse()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(alertPage.IsAlertSameState(false));
        }

        [Test]
        public void TestAlertConfirm()
        {
            string BUTTON = "//button[@class='btn btn-default btn-lg']";
            string ALERT_ANSWER_ELEMENT = "//p[@id='confirm-demo']";

            var OpenedAlertOnPage = alertPage.OpenAlert(BUTTON);

            var confirmedAlertPage = OpenedAlertOnPage.ConfirmAlert();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(confirmedAlertPage.GetConfirmBoxAnser(ALERT_ANSWER_ELEMENT), "You pressed OK!");
        }

        [Test]
        public void TestAlertCancel()
        {
            string BUTTON = "//button[@class='btn btn-default btn-lg' and text()='Click me!']";
            string ALERT_ANSWER_ELEMENT = "//p[@id='confirm-demo']";

            var OpenedAlertOnPage = alertPage.OpenAlert(BUTTON);

            var canceledAlertPage = OpenedAlertOnPage.CancelAlert();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(canceledAlertPage.GetConfirmBoxAnser(ALERT_ANSWER_ELEMENT), "You pressed Cancel!");
        }

        [Test]
        public void TestAlertBox()
        {
            string text = "this";
            string BUTTON = "//button[text()='Click for Prompt Box']";
            string ALERT_ANSWER_ELEMENT = "//p[@id='prompt-demo']";

            var OpenedAlertOnPage = alertPage.OpenAlert(BUTTON);
            var confirmedAlertPage = OpenedAlertOnPage.ConfirmAlert(text);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(confirmedAlertPage.GetConfirmBoxAnser(ALERT_ANSWER_ELEMENT), $"You have entered '{text}' !");
        }
    }
}
