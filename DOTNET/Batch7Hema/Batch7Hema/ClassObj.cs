using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    class ClassEmployee
    {
        public int EId;
        public int EAge;
        public string EName, EAddress;
        public void EmpData()
        {
            Console.WriteLine("Enter the employee Details...");
            this.EId = Convert.ToInt32(Console.ReadLine());
            this.EAge = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
        }
        public void DisplayData()
        {
            Console.WriteLine("Employee ID is : " + this.EId);
            Console.WriteLine("Emp Age is: " + this.EAge);
            Console.WriteLine("EName is : " + this.EName);
            Console.WriteLine("EAddress is : " +EAddress);
        }
        class classEx
        {
            static void Main()
            {
                ClassEmployee obj1 = new ClassEmployee();
                ClassEmployee obj2 = new ClassEmployee();
                obj1.EmpData();
                obj2.EmpData();
                obj1.DisplayData();
                obj2.DisplayData();

            }
        }
    }
}
