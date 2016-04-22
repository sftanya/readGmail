using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using GmailTest.Browsers;
using System.IO;
using Newtonsoft.Json;
using GmailTest.Controlls;
using System.Reflection;

namespace GmailTest.Actions
{
    public class GeneralActions
    {
        public void WaitFor(double sec, By path)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(sec));
            IList<IWebElement> elementsA = wait.Until<IList<IWebElement>>((d) =>
            {
                return d.FindElements(path);
            });

            //WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(sec));
            ////    wait.Until(By.Id("ButtonSPFlag"));
            //IWebElement element = wait.Until(x => x.FindElement(path));
        }

        public string ExtractFrom(string body, string leftBound =null , string rightBound = null)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            if ((leftBound != null) || (leftBound.Length != 0))
                leftIndex = body.IndexOf(leftBound) + leftBound.Length;

            if ((rightBound != null) || (rightBound.Length != 0))
                rightIndex = body.IndexOf(rightBound);

            return body.Substring(leftIndex, rightIndex - leftIndex);
        }

        public int CountLetters(string body, char letter)
        {
            int count = body.Count(c => c == letter);
            return count;
        }

        public void ReadCreds(string file = "Files\\GmailCredentials.json")
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), file);
            GmailLogin items = JsonConvert.DeserializeObject<GmailLogin>(path);

            using (StreamReader r = File.OpenText(path))
            {
                JsonSerializer ser = new JsonSerializer();
                GmailLogin log = (GmailLogin)ser.Deserialize(r, typeof(GmailLogin));
            }
        }

        //public void ReadCreds1(string file = "Files\\GmailCredentials.xml")
        //{
        //    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), file);

        //    var content = File.ReadAllBytes(path);
        //    var jsonReader = JsonReaderWriterFactory.CreateJsonReader(content, new System.Xml.XmlDictionaryReaderQuotas());

        //    var root = XElement.Load(jsonReader);


        //    this.Username = root.D

        //    dynamic json = System.Web.Helper

        //}

        //public void ReadCreds2(string file = "Files\\GmailCredentials.xml")
        //{
        //    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), file);

        //    var stream = File.OpenText(file);
        //    string s = stream.ReadToEnd();
        //    var jsonArray = JsonArray.Parse(s);
        //}

        //public void ReadCreds(string file = "Files\\GmailCredentials.xml")
        //{
        //    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), file);

        //    string Json = System.IO.File.ReadAllText(path);
        //    JavaScriptSerializer ser = new JavaScriptSerializer();

        //}

        //public void ReadCreds(string file = "Files\\GmailCredentials.xml")
        //{
        //    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), file);
        //    //XmlTextReader reader = new XmlTextReader(path);

        //    var doc = XDocument.Load(path);

        //    foreach (var c in doc)
        //    {
        //        var user = doc.Descendants("Username");
        //        var pass = doc.Descendants("Password");
        //    }
        //}
    }
}
