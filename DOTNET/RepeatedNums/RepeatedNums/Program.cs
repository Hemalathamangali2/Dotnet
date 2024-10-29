using System.Drawing;
using System;

namespace RepeatedNums
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elments of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                int count = 1;
                while (i < size - 1 && arr[i] == arr[i + 1])
                {
                    count++;
                    i++;

                }
                if (count > 1)
                {
                    Console.WriteLine($"{arr[i]} is repeated {count} times");

                }

            }
        }
    }
}










