namespace Max3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            Console.WriteLine("Enter the numbers: ");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(num);
            Array.Reverse(num);

            int max1 = num[0];
            int max2 = num[1];
            int max3 = num[2];
            Console.WriteLine("The max three elements are: {0},{1},{2}", max1, max2, max3);

        }
    }
}
