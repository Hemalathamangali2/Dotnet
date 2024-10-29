using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    internal class SizeOfArr
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("\nElements of array a are: ");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            int b = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref a, b);
            Console.WriteLine("\nElements of new size array: ");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}