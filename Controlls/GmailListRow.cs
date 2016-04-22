using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using GmailTest.Controlls;
using GmailTest.Actions;

namespace GmailTest.Controlls
{
    public class GmailListRow 
    {
        public IWebElement row;

        public GmailListRow(IWebElement _row)
        {
            row = _row;
        }

        public IWebElement GmailListRowChecked
        {
            get { return row.FindElement(By.XPath("td[2]")); }
        }

        public IWebElement GmailListRowStarred
        {
            get { return row.FindElement(By.XPath("td[3]/span")); }
        }

        public IWebElement GmailListRowSender
        {
            get { return row.FindElement(By.XPath("td[4]/div[2]/span"));}
        }

        public bool GmailListRowUnread
        {
            get {
                try{
                    row.FindElement(By.XPath("td[4][contains(div[1]/text(),'unread, ')]"));
                    return true;
                }
                catch { return false; }
            }
        }

        public IWebElement GmailListRowSubject
        {
            get { return row.FindElement(By.XPath("td[6]")); }
        }

        public IWebElement GmailListRowDate
        {
            get { return row.FindElement(By.XPath("td[8]/span")); }
        }
    }
}
