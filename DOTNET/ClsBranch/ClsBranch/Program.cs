namespace ClsBranch
{
    class ClsBranch
    {
        int BCode;
        string BName, BAddress;
        public void GetBData()
        {
            Console.Write("Enter Branch Detail:-");
            BCode = Convert.ToInt32(Console.ReadLine());
            BName = Console.ReadLine();
            BAddress = Console.ReadLine();
        }
        public void DisplayBData()
        {
            Console.WriteLine("Branch code is:-" + BCode);
            Console.WriteLine("Branch Name is:-" + BName);
            Console.WriteLine("Branch Address is:"+BAddress); 
        }
    }
    interface ClsEmplyee
    {
        void GetEmpData();
        void DisplayEmpData();
    }
    class ClsManager : ClsBranch, ClsEmplyee
    {
        int EmpId; string EName;
        double Bonus, CA;
        public void GetEmpData()
        {
            Console.Write("Enter Manager Details:-");
            EmpId = Convert.ToInt32(Console.ReadLine());
            EName = Console.ReadLine();
            Bonus = Convert.ToDouble(Console.ReadLine());
            CA = Convert.ToDouble(Console.ReadLine());

        }
        public void DisplayEmpData()
        {
            Console.WriteLine("manager id is:-" + EmpId);
            Console.WriteLine("manager name is:-" + EName);
            Console.WriteLine("manager Bonus is:-" + Bonus);
            Console.WriteLine("manager CA is:-" + CA);
        }
    }

    class ClsMPLinheritance
    {
        static void Main(string[] args)
        {
            ClsManager obj1 = new ClsManager();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.DisplayBData();
            obj1.DisplayEmpData();
            Console.ReadLine();
        }
    }
}
