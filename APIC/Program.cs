using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIC
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.icndb.com/jokes/random";
            string response;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            Ber valueBer = JsonConvert.DeserializeObject<Ber>(response);
            Console.WriteLine("Сказка: {0}", valueBer.Value.Joke);
            Console.ReadLine();
        }
    }
}
