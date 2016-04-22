using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GmailTest.Controlls;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Chrome;
using GmailTest.Browsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GmailTest.Objects;

namespace GmailTest.Actions
{
    public static class GmailActions
    {
        public static InboxPage Login(/*GmailLogin loginCreds*/){

            List<GmailLogin> gmailCredentials = CredentialsHelper.GmailCredentials;

            var actualCreds = gmailCredentials.First(c => c.ID == "1");
            
            var loginPage = new GmailLoginPage(Browser.Driver);
            loginPage.LoginTextField.SendKeys(actualCreds.Username);
            loginPage.NextButton.Click();
        
//            GeneralActions generalActions = new GeneralActions();
//            generalActions.WaitFor(10, By.XPath("//*[@id='Passwd']"));

            Thread.Sleep(5000);

            var passPage = new GmailPasswordPage(Browser.Driver);
            passPage.PasswTextField.Click();
            passPage.PasswTextField.SendKeys(actualCreds.Password);
            passPage.SignInButton.Click();

            Thread.Sleep(TimeSpan.FromSeconds(30));

            return new InboxPage(Browser.Driver);
        }

        public static EmailMsgPage OpenFirstUnread(InboxPage page)
        {
       //     bool found = false;

            GmailListRow row = page.TableRows.FirstOrDefault(r => r.GmailListRowUnread == true); //unstead foreach

            if (row != null)
            {
                //found = true;
                
                // row.GmailListRowSubject.Click();

                // string sender = row.GmailListRowSender.Text;
                // row.GmailListRowSender.Click();

                // string sentDate = row.GmailListRowDate.Text;
                row.GmailListRowDate.Click();
            }

            else //(found == false)
                throw new Exception("No unread messages");
 
            Thread.Sleep(TimeSpan.FromSeconds(10));
            
            return new EmailMsgPage(Browser.Driver);
        }

        public static Email GetEmail(EmailMsgPage page)
        {
            return new Email(page.Head.Text, page.Body.Text);
        }
    }
}
