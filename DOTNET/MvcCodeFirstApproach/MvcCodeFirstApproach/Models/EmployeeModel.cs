using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCodeFirstApproach.Models
{
    [Table ("tblEmployees")]
    public class EmployeeModel
    {
       [Key]
       public int Id { get; set; }
       [Required]
       public string EmployeeName { get; set; } 
       public double EmployeePhone { get; set; }
       public string Job { get; set; }
       public double Salary { get; set; }
    }
}
