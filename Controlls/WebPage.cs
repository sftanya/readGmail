using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace GmailTest.Controlls
{
    public class WebPage
    {
        public static IWebDriver driver;

        public WebPage(IWebDriver _driver)
        {
            driver = _driver;
        }
    }
}
