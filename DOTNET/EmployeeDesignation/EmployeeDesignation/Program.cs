namespace EmployeeDesignation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            string find = Console.ReadLine();
            string[] op = UserProgramCode.getEmployee(str, find);
            int count = 0;
            foreach (string item in str)
            {
                foreach (char c in item)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        count++;
                    }
                }
            }
            foreach (char item in find)
            {
                if (!char.IsLetterOrDigit(item) && (!char.IsWhiteSpace(item)))
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                if (op.Length == str.Length / 2)
                {
                    Console.WriteLine("All employees belong to same {0} designation", find);
                }
                else
                    foreach (string item in op)
                    {
                        Console.WriteLine(item);
                    }
            }
            Console.ReadLine();
        }
    }
}










//using System;
//using System.Collections.Generic;

//public class UserProgramCode
//{
//    public static string[] getEmployee(string[] input1, string input2)
//    {
//        List<string> employees = new List<string>();
//        input2 = input2.ToLower();

//        foreach (string input in input1)
//        {
//            if (!IsValid(input))
//                return new string[] { "Invalid Input" };
//        }

//        if (!IsValid(input2))
//            return new string[] { "Invalid Input" };

//        for (int i = 0; i < input1.Length; i += 2)
//        {
//            string employeeName = input1[i];
//            string designation = input1[i + 1].ToLower();

//            if (designation == input2)
//            {
//                employees.Add(employeeName);
//            }
//        }

//        if (employees.Count == 0)
//        {
//            return new string[] { $"No employee for {input2} designation" };
//        }

//        HashSet<string> uniqueDesignations = new HashSet<string>();
//        for (int i = 1; i < input1.Length; i += 2)
//        {
//            uniqueDesignations.Add(input1[i].ToLower());
//        }

//        if (uniqueDesignations.Count == 1 && uniqueDesignations.Contains(input2))
//        {
//            return new string[] { $"All employees belong to same {input2} designation" };
//        }

//        return employees.ToArray();
//    }

//    public static bool IsValid(string str)
//    {
//        foreach (char c in str)
//        {
//            if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        string[] input1 = new string[n];
//        for (int i = 0; i < n; i++)
//        {
//            input1[i] = Console.ReadLine();
//        }
//        string input2 = Console.ReadLine();


//        string[] result = UserProgramCode.getEmployee(input1, input2);
//        foreach (string res in result)
//        {
//            Console.WriteLine(res);
//        }
//    }
//}














