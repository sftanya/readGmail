using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace GmailTest.Controlls
{
    public class EmailMsgPage : WebPage
    {
        public EmailMsgPage(IWebDriver _driver) : base(_driver) { }

        public IWebElement Body
        {
            get { return driver.FindElement(By.XPath("//*[contains(@class, 'ii gt m')]")); }
        }

        public IWebElement Head
        {
            get { return driver.FindElement(By.XPath("//*[contains(@class, 'hP')]")); }
        }
    }
}
