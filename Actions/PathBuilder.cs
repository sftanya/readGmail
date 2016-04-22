using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GmailTest.Actions
{
    public static class PathBuilder
    {
        //private static string ProjectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        private static string ProjectPath = "C:\\Users\\Support\\documents\\visual studio 2010\\Projects\\ConsoleApplication1\\TestProject1";

        public static string GmailCredentialsPath
        {
            //get { return ProjectPath + "\\Files\\GmailCredentials.json"; }
            get { return ProjectPath + "\\Files\\GmailCredentials.json"; }
        }
    }
}
