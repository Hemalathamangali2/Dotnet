namespace Batch7Hema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student number(1-5): ");
            int sno = Convert.ToInt32(Console.ReadLine());
            switch (sno)
            {
                case 1:
                    Console.WriteLine("Iam Student 1");
                    break;
                case 2:
                    Console.WriteLine("Iam Student 2");
                    break;
                case 3:
                    Console.WriteLine("Iam Student 3");
                    break;
                case 4:
                    Console.WriteLine("Iam Student 4");
                    break;
                case 5:
                    Console.WriteLine("Iam Student 5");
                    break;
                default:
                    Console.WriteLine("Invalid student number");
                    break;
            }
        }
    }
}
    
