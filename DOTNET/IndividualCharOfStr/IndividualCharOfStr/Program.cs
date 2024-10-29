namespace IndividualCharOfStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();

            foreach (char i in str){
                Console.WriteLine(i);
            }
        }
    }
}
