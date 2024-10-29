using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    internal class Maxmin
    {
        static void Main()
        {
            //int[] numbers = { 3, 5, 1, 4, 2, 0 };

            //Array.Sort(numbers);

            //int firstMax = numbers[numbers.Length - 1];
            //int firstMin = numbers[0];
            //int secondMax = numbers[numbers.Length - 2];
            //int secondMin = numbers[1];

            //Console.WriteLine($"First Max: {firstMax}");
            //Console.WriteLine($"First Min: {firstMin}");
            //Console.WriteLine($"Second Max: {secondMax}");
            //Console.WriteLine($"Second Min: {secondMin}");

            
                int[] numbers = { 3, 5, 1, 4, 2, 5, 0 };

                
                int firstMax = int.MinValue, secondMax = int.MinValue;
                int firstMin = int.MaxValue, secondMin = int.MaxValue;

                foreach (int number in numbers)
                {
                    if (number > firstMax)
                    {
                        secondMax = firstMax; 
                        firstMax = number;     
                    }
                    else if (number > secondMax && number < firstMax)
                    {
                        secondMax = number;    
                    }

                    
                    if (number < firstMin)
                    {
                        secondMin = firstMin; 
                        firstMin = number;    
                    }
                    else if (number < secondMin && number > firstMin)
                    {
                        secondMin = number;   
                    }
                }

            
                Console.WriteLine($"First Max: {firstMax}");
                Console.WriteLine($"First Min: {firstMin}");
                Console.WriteLine($"Second Max: {secondMax}");
                Console.WriteLine($"Second Min: {secondMin}");
            }
        }

    }
}
}

