using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTrainingCenter.Pages;
using System.Threading;

namespace SeleniumTrainingCenter
{
    [TestClass]
    public class MailTest : BaseTest
    {
        [Test]
        public void TestLoginToGmail()
        {
            string assertFailedMessage = "Could not find username element";

            string email = "emailtesting4565@gmail.com";
            string password = "testingpassword";

            string gmailLoginPageUrl = @"https://accounts.google.com/signin/v2/identifier?passive=1209600&continue=https%3A%2F%2Faccounts.google.com%2Fb%2F1%2FAddMailService&followup=https%3A%2F%2Faccounts.google.com%2Fb%2F1%2FAddMailService&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            var gmailPage = new GmailPage(Driver, gmailLoginPageUrl);

            var LoggedInGmailPage = gmailPage.Login(email, password);
            var loggedEmail = LoggedInGmailPage.GetLoggedInUserEmail();

            Thread.Sleep(System.TimeSpan.FromSeconds(5)); // implicit waiter

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(email, loggedEmail , assertFailedMessage); // Cant find the reason why element does not get found -> GmailPage.cs
        }
        [Test]
        public void TestMultiSelect()
        {

        }
    }
}
