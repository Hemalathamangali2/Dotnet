namespace SumOfCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int soc = 0;
            int originalNum = num;
            while (num > 0)
            {
                int digit = num % 10;
                soc += digit * digit * digit;
                num /= 10;
            }Console.WriteLine($"The Sum of the cube of the digits of {originalNum} is :{soc}");
        }
    }
}
