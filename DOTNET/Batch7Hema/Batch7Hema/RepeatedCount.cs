using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    class RepeatedCount
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 2, 3, 4, 4, 5, 2};
            Array.Sort(numbers);  

            int count = 1; 

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++; 
                }
                else
                {
                    if (count > 1)
                    {
                        Console.WriteLine($"Number {numbers[i - 1]} appears {count} times.");
                    }
                    count = 1;
                }
            }
        }
    }
}

