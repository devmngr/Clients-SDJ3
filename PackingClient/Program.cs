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
            Console.WriteLine("Choose nr 1 for half animal :");

            Console.WriteLine("Choose nr 2 for one type product :");

            String nr1 = "halfanimal";

            String nr2 = " one type product";

            int  value =  Int32.Parse (Console.ReadLine());
            
            switch (value)
            {
                case 1:
                    Console.WriteLine( "The packed product is: " + nr1);
                    break;
                case 2:
                    Console.WriteLine("The packed product is: " + nr2);
                    break;

                default:
                    Console.WriteLine("Incorrect number entered");
                    break;
            }


            Console.WriteLine("Select a tray where to place the product :");


            int traynumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The product was palced in the tray number :" + traynumber);

            




        }
    }

}
