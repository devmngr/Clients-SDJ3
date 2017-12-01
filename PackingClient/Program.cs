using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingClient
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebServer.WebServerPortTypeClient webServer = new IWebServer.WebServerPortTypeClient();

            Console.WriteLine("Enter product ID");


            int product = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter tray number :");


            int traynumber = Int32.Parse(Console.ReadLine());


            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {


                case 1:
                    webServer.addProductContent(product, traynumber);
                    break;

                default: break;

            }

            Console.WriteLine("Product packed");




        }
    }

}
