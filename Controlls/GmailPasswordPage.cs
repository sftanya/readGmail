using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace GmailTest.Controlls
{
    class GmailPasswordPage : WebPage
    {
        public GmailPasswordPage(IWebDriver _driver) : base(_driver) { }

        public IWebElement PasswTextField
        {
            get { return /*ElementGetter.GetElement(*/driver.FindElement(By.XPath("//input[@id='Passwd']"/*, TimeSpan.FromSeconds(20)*/)); }
        }

        public IWebElement SignInButton
        {
            get { return /*ElementGetter.GetElement(*/driver.FindElement(By.XPath("//*[@id='signIn']"/*, TimeSpan.FromSeconds(20)*/)); }
        }
    }
}
