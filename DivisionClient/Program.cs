using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DivisionClient
{
    class Program
    {



        static void Main(string[] args)
        {
            IWebServer.WebServerPortTypeClient webServer = new IWebServer.WebServerPortTypeClient();


            while (true)
            {
                // weight of part 
                Console.WriteLine("Please enter the weight of a part:");

                int weight = Int32.Parse(Console.ReadLine());
                // a.registerAnimal(weight);

                Console.WriteLine(" The weight of part is   :" + weight);
                // attach to tray 


                Console.WriteLine(" Enter animal ID: ");
                int animal = Int32.Parse(Console.ReadLine());


                Console.WriteLine("Add part to tray; Enter tray ID");

                int tray = Int32.Parse(Console.ReadLine());


                Console.WriteLine(" Press: \n0-Cancel\n1-Register part");


                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {


                    case 1:
                        webServer.addTrayContent(tray, animal, weight);
                        break;

                    default: break;

                }



                Console.WriteLine(" The part was added to the tray number  :" + tray);





            }
        }
    }
}
