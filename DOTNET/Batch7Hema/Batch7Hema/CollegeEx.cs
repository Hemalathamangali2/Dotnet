using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Batch7hema
{
    internal class CollegeEx
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

            Department csDept = new Department("ABC College", "123 College St", "Computer Science", "B.Sc. Computer Science");


            csDept.GetDetails();


            csDept.CourseDetails();
        }
    }
}
