using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace GmailTest.Controlls
{
    public class GmailLogin
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public GmailLogin()
        {
            this.ID = string.Empty;
            this.Username = string.Empty;
            this.Password = string.Empty;
        }

        public GmailLogin(string id, string uname, string passw)
        {
            this.ID = id;
            this.Username = uname;
            this.Password = passw;
        }
    }
}
