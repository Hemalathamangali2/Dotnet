namespace CollegeEx
{
    internal class College
    {
        string name;
        string address;
        int establishedyear;
        int studentcount;
        //Default
        College()
        {
            name = "JB";
            address = "KLD";
            establishedyear = 1990;
            studentcount = 700;
        }
        
        //parameterized 
        College(string name,string address, int year, int students)
        {
            this.name = name;   
            this.address = address;
            this.establishedyear = year;
            this.studentcount = students;
        }
        //copy
        College(College other)
        {
            name =other.name;
            address = other.address;
            establishedyear=other.establishedyear;
            studentcount=other.studentcount; 
        }
        void DisplayDetails()
        {
            Console.WriteLine("CollegeName: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Establishedyear: "+ establishedyear);
            Console.WriteLine("Number  of students:"+ studentcount);
        }
        void UpdateStudentCount(int newCount)
        {
            studentcount = newCount;
        }
        int GetCollegeYears()
        {
            return establishedyear;
        }
        static void Main(string[] args)
        {
            College college1 = new College();
            college1.DisplayDetails();
            Console.WriteLine();


            College College2 = new College("SPW", "TPT", 1999, 500 );
            College2.DisplayDetails();
            Console.WriteLine("College Age: "+ College2.GetCollegeYears() + "years");

            College College3 = new College(College2);
            College3.UpdateStudentCount(1700);
            College2.DisplayDetails();

        }
    }
}
