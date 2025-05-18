
namespace MvcProject.Models
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        // public required string FullName { get; set; }
        public required string Name { get; set; }
        public required string Position { get; set; }
        public required decimal Salary { get; set; }
    }
}