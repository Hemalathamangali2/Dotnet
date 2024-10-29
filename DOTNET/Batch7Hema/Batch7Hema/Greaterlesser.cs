using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    internal class Greaterlesser
    {
        public static void Main(string[] args) {
            int x, y;
            Console.WriteLine("Enter x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("X is greater than Y");
                 }
            else if (x < y)
        {
                Console.WriteLine("Y is greater than X");
            }
        else {
                Console.WriteLine("X and Y are equal");
            }
        }
    }
}
