using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace GmailTest.Controlls
{
    public class GmailLoginPage : WebPage
    {
        public GmailLoginPage(IWebDriver _driver) : base(_driver) { }

        public IWebElement LoginTextField
        {
            get { return driver.FindElement(By.XPath("//*[@id='Email']")); }
        }
        public IWebElement NextButton
        {
            get { return driver.FindElement(By.XPath("//*[@id='next']")); }
        }
    }
}
