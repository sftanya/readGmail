using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GmailTest.Controlls;
using System.Web.Script.Serialization;

namespace GmailTest.Actions
{
    public static class CredentialsHelper
    {
        public static List<GmailLogin> GmailCredentials
        {
            get
            {
                var fileData = File.ReadAllText(PathBuilder.GmailCredentialsPath);
                var credentials = new JavaScriptSerializer().Deserialize<List<GmailLogin>>(fileData);

                return credentials;
            }
        }
    }
}
