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

namespace testCoffeeOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts the users to enter name
            string yourName;
            
            
            Console.WriteLine("Hello, please enter your name: ");
            yourName = Console.ReadLine();
         
            Console.WriteLine(getUsername(yourName) + "\n");
            Console.WriteLine("May I take your Order?\n");
            
            //show menu items
            string url = @"http://localhost:21714/CoffeeOrderService2.svc/menu";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);
            String json = reader.ReadToEnd();
            Console.WriteLine(json);

            //prompts the user to make an order by entering the coffee name
            string orderName;

            Console.WriteLine("\nEnter Coffee Name: ");
            orderName = Console.ReadLine();
            Console.WriteLine(getOrder(orderName) + "\n");
            Console.WriteLine("Thank you");

            Console.ReadKey();
            //processJsonNewtonSoft(json);
        }

        public static string getUsername(string username)
        {
            string url2 = @"http://localhost:21714/CoffeeOrderService2.svc/welcome/" + username;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url2);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);
            return reader.ReadToEnd();

        }

        public static string getOrder(string theOrder)
        {
            string url3 = @"http://localhost:21714/CoffeeOrderService2.svc/yourorder/" + theOrder;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url3);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);
            return reader.ReadToEnd();

        }

    }
}
