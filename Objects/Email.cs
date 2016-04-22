using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GmailTest.Controlls;

namespace GmailTest.Objects
{
    public class Email
    {       
        public string MsgHead { get; private set; }
        public string MsgBody { get; private set; }

        public Email(string mhead, string mbody)
        {
            this.MsgHead = mhead;
            this.MsgBody = mbody;
        }
    }
}
