using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebServer.WebServerPortTypeClient webServer = new IWebServer.WebServerPortTypeClient();
            while (true)
            {

                Console.WriteLine("Please enter the weight of animal:");

                int weight = Int32.Parse(Console.ReadLine());

                Console.WriteLine(" The weight of animal is   :" + weight);

                Console.WriteLine(" Press: \n0-Cancel\n1-Register animal");


                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {


                    case 1:
                        webServer.registerAnimal(weight);
                        break;

                    default: break;

                }


            }
        }
    }
}
