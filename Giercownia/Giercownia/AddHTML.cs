using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Giercownia
{
    class AddHTML
    {
        private string www, contentstring;
        public string readHTML(string address)
        {
            if (address.IndexOf("https://") < 0) www = "https://" + address;
            else www = address;

            WebRequest request = WebRequest.Create(www);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader read = new StreamReader(dataStream);
            contentstring = read.ReadToEnd();

            read.Close();
            dataStream.Close();
            response.Close();


            return contentstring;
        }
    }
}
