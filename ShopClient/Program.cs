using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClient
{
    class Program
    {
        static void Main(string[] args)
        {


            IWebServer.WebServerPortTypeClient webServer = new IWebServer.WebServerPortTypeClient();


            // Console.WriteLine("Enter the id of the product : ");

            //  int infectedProduct = Int32.Parse(Console.ReadLine());


            int infectedProduct = 6;

            int[] infectedProducts = webServer.getInfectedProducts(infectedProduct);


            for (int i = 0; i < infectedProducts.Length; i++)

                Console.WriteLine("infected product: " + infectedProducts[i]);



        }
    }
}
