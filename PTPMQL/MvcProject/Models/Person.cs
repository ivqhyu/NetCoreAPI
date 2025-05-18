using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProject.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public  string PersonId { get; set; } =  string.Empty;
        public  string FullName { get; set; } = string.Empty;
        public  string Address { get; set; } = string.Empty;
        public  string Email { get; set; } = string.Empty;


    }
}