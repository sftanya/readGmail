using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using GmailTest.Controlls;
using GmailTest.Actions;
using GmailTest.Browsers;
using GmailTest.Objects;
using GmailTest.Extensions;

namespace GmailTest
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver driver;
        string url = "http://www.gmail.com";
        [TestInitialize]
        public void TestSetup()
        {
            Browser.Initialize(url);
        }
        //[TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
        //[TestMethod]
        //public void OpenMail()
        //{
        //    var loginField = driver.FindElement(By.Id("Email"));
        //    loginField.SendKeys("ntest0158");

        //    var nextBtn = driver.FindElement(By.Id("next"));
        //    nextBtn.Click();

        //    Thread.Sleep(5000);

        //    var passwField = driver.FindElement(By.XPath("//*[@id='Passwd']"));
        //    passwField.SendKeys("1991NtesT");

        //    var signInBtn = driver.FindElement(By.XPath("//*[@id='signIn']"));
        //    signInBtn.Click();

        //    Thread.Sleep(30000);

        //    var tableInbox = driver.FindElement(By.XPath("//*[@id=':3k']"));
        //    var unreadMail = tableInbox.FindElement(By.XPath("//tbody/tr[contains(td/div/text(),'unread')]/td[6]"));
        //    unreadMail.Click();

        //    var emailBody = driver.FindElement(By.XPath("//*[contains(@class, 'ii gt m')]"));
        //    string sn = emailBody.Text;
        //    Console.WriteLine("{0}", sn);
        //    int countLetterA = sn.Count(c => c == 'a');

        //    Thread.Sleep(5000);
        //}

        //[DeploymentItem ("Files\\GmailCredentials.json", "Files")]
        [TestMethod]
        public void Email_BodyCount_IsOdd()
        {
//            var loginCreds = new GmailLogin();
            var homePage = GmailActions.Login(/*loginCreds*/);

            var emailPage = GmailActions.OpenFirstUnread(homePage);

            Email email = GmailActions.GetEmail(emailPage);
            var countA = new GeneralActions().CountLetters(email.MsgBody, 'a');
            Assert.IsTrue(countA.IsOdd() ,"Number of letters isn't odd");
        }
    }
}
