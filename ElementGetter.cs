using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GmailTest.Controlls;
using OpenQA.Selenium;
namespace GmailTest
{
    public static class ElementGetter
    {
        public static IWebElement GetElement(IWebDriver driver, string path, TimeSpan span)
        {
            var startWaitingTime = DateTime.Now;
            var endWaitinTime = startWaitingTime + span;
            IWebElement element = null;

            while (DateTime.Now != endWaitinTime && element == null)
            {
                var isVisible = false;
                try
                {
                    element = driver.FindElement(By.XPath(path));
                    isVisible = element.Displayed;
                    if (!isVisible)
                        throw new Exception("Elelement not visible");
                }
                catch
                {
                    //ignore
                }
                if (element == null && DateTime.Now > endWaitinTime)
                    throw new Exception("Element not found");
            }
            return element;
        }
    }
}
