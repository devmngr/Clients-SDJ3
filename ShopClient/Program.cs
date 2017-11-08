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

            Console.WriteLine("Enter the number of infected product : ");


            int infectedproduct = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The infected product number is :" + infectedproduct);


        }
    }
}
