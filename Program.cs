using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beach_time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many degrees is it outside? : ");
            double degreesOutside = double.Parse(Console.ReadLine());
            if (degreesOutside > 24)
            {
                Console.WriteLine("Beach time!");
            }
            else
            {
                Console.WriteLine("I should just stay inside today...");
            }
            Console.ReadLine();
            //If the entry is greater than 24, "Beach time!" Should be displayed.
            //Otherwise it should be shown "I should just stay inside today..."
        }
    }
}
