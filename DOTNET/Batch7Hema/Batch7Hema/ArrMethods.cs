using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    internal class ArrMethods
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5, };
            int[] b = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine("\nElements of a are: ");
            foreach (int i in a)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\nElements of B are: ");
            foreach (int i in b)
            {
                Console.WriteLine(i + " ");
            }
            Array.Copy(a, 0, b, 2, 5);
            Console.WriteLine("\nElements of b after copy");
            foreach (int i in b)
            {
                Console.Write(i + " ");
            }
        }
    }
}

