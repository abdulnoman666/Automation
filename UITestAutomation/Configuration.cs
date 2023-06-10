using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UITestAutomation
{
    public class Configuration
    {
        XDocument doc = XDocument.Parse(File.ReadAllText(@"D:\Automation2\Automation\UITestAutomation\\app.config"));

        public string Get_baseurl()
        {
            var url= doc.Descendants("add").Attributes("value").ElementAt(0).Value;
            return url;
        }

        public string Get_email()
        {
            var email = doc.Descendants("add").Attributes("value").ElementAt(1).Value;
            return email;
        }

        public string Get_password()
        {
            var password = doc.Descendants("add").Attributes("value").ElementAt(2).Value;
            return password;
        }

        public string Get_appUsername()
        {
            var appUsername = doc.Descendants("add").Attributes("value").ElementAt(3).Value;
            return appUsername;
        }

        public string Get_emailPassword()
        {
            var emailPassword = doc.Descendants("add").Attributes("value").ElementAt(4).Value;
            return emailPassword;
        }

    }
}
