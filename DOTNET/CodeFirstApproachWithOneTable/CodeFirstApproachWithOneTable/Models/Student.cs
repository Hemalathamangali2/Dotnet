using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachWithOneTable.Models
{

    public class Student
    {
            [Key] 
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
    }
}
