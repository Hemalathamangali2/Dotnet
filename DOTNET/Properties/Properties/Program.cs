using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    class properties
    {
        int EmpId, EAge; string EName, EmailAddress;
        public int PEmpId
        {
            set
            {
                EmpId = value;
            }
            get
            {
                return EmpId;
            }
        }
        public int PAge
        {
            set
            {
                EAge = value;
            }
            get
            {
                return EAge;
            }
        }
        public string PEName
        {
            set
            {
                EName = value;
            }
            get
            {
                return EName;
            }
        }
        public string PAddress
        {
            set
            {
                PAddress = value;
            }
            get
            {
                return PAddress;
            }
        }
        static void Main(string[] args)
        {
            properties obj1 = new properties();
            Console.WriteLine("Enter EmpId: ");
            obj1.PEmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Age: ");
            obj1.PAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EName: ");
            obj1.PEName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            obj1.PAddress = Console.ReadLine();

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Name: {obj1.PEName}");
            Console.WriteLine($"Employee ID: {obj1.PEmpId}");
            Console.WriteLine($"Age: {obj1.PAge}");
            Console.WriteLine($"Address: {obj1.PAddress}");
        }

    }
}