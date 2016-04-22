using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GmailTest.Browsers
{
    public static class Browser
    {
        public static IWebDriver Driver;

        public static void Initialize(string url)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
        }
    }
}
