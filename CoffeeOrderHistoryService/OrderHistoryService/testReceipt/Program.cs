using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http;
using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace testReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            string date;
            Console.WriteLine("Hello, please enter the date of receipt (mm-dd-yyyy) enter 03-1-2016 to test: ");
            date = Console.ReadLine();
            Console.WriteLine("**Your Order Summary**");
            Console.WriteLine(getDate(date));
            Console.ReadKey();
            
        }

        public static string getDate(string theDate)
        {
            string url2 = @"http://localhost:10242/OrderHistory.svc/yourHistory/" + theDate;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url2);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);
            return reader.ReadToEnd();

        }
      
    }
}
