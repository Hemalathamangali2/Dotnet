using System.Net;

namespace CollegeEx
{
    internal class Program
    {
        interface ICourse
        {
            void CourseDetails();
        }
        public class College
        { 
            private string name;
            private string address;

            public College(string collegeName, string collegeAddress)
            {
                name = collegeName;
                address = collegeAddress;
            }

            public string GetCollegeName()
            {
                return name;
            }

            public string GetAddress()
            {
                return address;
            }


            public virtual void GetDetails()
            {
                Console.WriteLine($"College Name: {name}");
                Console.WriteLine($"Address: {address}");
            }
        }

        public class Department : College, ICourse
        {
            private string departmentName;
            private string courseName;

            public Department(string collegeName, string collegeAddress, string deptName, string course)
                : base(collegeName, collegeAddress)
            {
                departmentName = deptName;
                courseName = course;
            }

            public override void GetDetails()
            {
                base.GetDetails();
                Console.WriteLine($"Department Name: {departmentName}");
            }

            public void CourseDetails()
            {
                Console.WriteLine($"Course Offered: {courseName}");
            }
        }

        static void Main(string[] args)
        {

            Department csDept = new Department("JNTU College", "Kalikiri", "Electronics and Communication Engineering", "BTech");


            csDept.GetDetails();


            csDept.CourseDetails();
        }
    }
}
