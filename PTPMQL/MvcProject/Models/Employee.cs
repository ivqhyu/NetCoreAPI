using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProject.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public required string FullName { get; set; }
        public required string Position { get; set; }
        public required decimal Salary { get; set; }
    }
}