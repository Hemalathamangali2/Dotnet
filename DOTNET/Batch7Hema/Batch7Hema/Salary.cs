using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Batch7hema
{
    internal class Salary
    {
        int EmpId;
        string EName;
        double HRBasic, DA, HRA, Gross;

        public void getSalary()
        {
            Console.WriteLine("Enter Employee Data: ");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.HRBasic = int.Parse(Console.ReadLine());
        }
        public void calculate()
        {
            this.DA = 0.4 * this.HRBasic;
            this.HRA = 0.5 * this.HRBasic;
            this.Gross = this.DA + this.HRA + this.HRBasic;
        }
        public void displayData()
        {
            Console.WriteLine("EmployeeID :" + this.EmpId);
            Console.WriteLine("Employee Name :" + this.EName);
            Console.WriteLine("HRBasic :" + this.HRBasic);
            Console.WriteLine("DA :" + this.DA);
            Console.WriteLine("HRA :" + this.HRA);
            Console.WriteLine("Gross :" + this.Gross);
        }
       static void Main(string[] args) {

                Salary obj1 = new Salary();
                obj1.getSalary();
                obj1.calculate();
                obj1.displayData();
            }
        }
    }

