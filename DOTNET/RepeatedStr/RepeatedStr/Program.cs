namespace RepeatedStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of arrays in string: ");
            int a = int.Parse(Console.ReadLine());

            string[] strArr = new string[a];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Element{i + 1}:");
                strArr[i] = Console.ReadLine();
            }
            Dictionary<string, int> elementCounts = new Dictionary<string, int>();
            foreach (string str in strArr)
            {
                if (elementCounts.ContainsKey(str))
                {
                    elementCounts[str]++;
                }
                else
                {
                    elementCounts[str] = 1;
                }
            }
            int repeatCount = 0;
            foreach (var item in elementCounts) {
                if (item.Value > 1)
                {
                    repeatCount++;
                    Console.WriteLine($"Element {item.Key} is repeated string {item.Value} times");
        }
            }
        }
    }
}
