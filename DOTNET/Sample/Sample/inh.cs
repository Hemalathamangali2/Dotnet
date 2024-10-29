using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class CASBranch
    {
        int BCode;
        string BName;
        string BAddress;
        public void GetBData()
        {
            Console.WriteLine("Enter Branch Details :");
            BCode = Convert.ToInt32(Console.ReadLine());
            BName = Console.ReadLine();
            BAddress = Console.ReadLine();
        }
        public void DisplayData()
        {
            Console.WriteLine("Branch Code : " + BCode);
            Console.WriteLine("BName : " + BName);
            Console.WriteLine("BAddress : " + BAddress);
        }
    }

    class ClsEmployee : CASBranch
    {
        int EId, EAge;
        string EName, EAddress;
        public void GetEData()
        {
            Console.WriteLine("Get Emp Data");
            this.EId = Convert.ToInt32(Console.ReadLine());
            this.EAge = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
        }
        public void DisplayEData()
        {
            Console.WriteLine("EmpID :" + EId);
            Console.WriteLine("EMpAge: " + EAge);
            Console.WriteLine("Emp : " + EName);
            Console.WriteLine("EAddress: " + EAddress);
        }
    }
    class Salary:ClsEmployee
    {
        double Basic, DA, HRA ,Gross;
        public void GetSalData()
        {
            Console.WriteLine("Get Salary Data");
            Basic = Convert.ToDouble(Console.ReadLine());
        }
        public void Calculation()
        {
            DA = 0.4 * Basic;
            HRA = 0.3 * Basic;
            Gross = DA + HRA + Basic;

        }
        public void DisplaySalData()
        {
            Console.WriteLine("Emp Basic: " + Basic);
            Console.WriteLine("Emp DA :" + DA);
            Console.WriteLine("Emp HRA:" + HRA);
            Console.WriteLine("Emp Gross :"+ Gross);
        }
    }
    class Inherit
    {
        static void Main(string[] args)
        {
            Salary obj1 = new Salary();
            obj1.GetBData();
            obj1.GetEData();
            obj1.GetSalData();
            obj1.DisplayData();
            obj1.DisplayEData();
            obj1.Calculation();
            obj1.DisplaySalData();
        }

    }
}

