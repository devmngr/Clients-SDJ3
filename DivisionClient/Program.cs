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
        {    // weight of part 
            Console.WriteLine("Please enter the weight of a part:");

            int weight = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" The weight of animal is   :" + weight);

            // attach to tray 

            Console.WriteLine("Please select the tray for the part:");

            int tray= Int32.Parse(Console.ReadLine());

            Console.WriteLine(" The part was added to the tray number  :" + tray);

        }
    }
}
