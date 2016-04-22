using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using GmailTest.Controlls;

namespace GmailTest.Controlls
{
    public class InboxPage : WebPage
    {
        public InboxPage(IWebDriver _driver) : base(_driver) { }

        public IWebElement TableInbox
        {
            get { return driver.FindElement(By.XPath("//*[@id=':3k']")); }
        }

         //gets all table rows
        public List<GmailListRow> TableRows
        {
            get 
            {
                List<GmailListRow> tableRows = new List<GmailListRow>();

                var rows = TableInbox.FindElements(By.XPath("tbody/tr[*]"));

                for (int i = 0; i < rows.Count; i++)
                {
                    tableRows.Add(new GmailListRow(rows[i]));
                }

                return tableRows; 
            }
        }
    }
}
