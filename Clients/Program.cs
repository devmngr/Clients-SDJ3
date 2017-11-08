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
            Console.WriteLine("Please enter the weight of animal:");

            int weight = Int32.Parse (  Console.ReadLine());

            Console.WriteLine(" The weight of animal is   :" + weight);

        }
    }
}
