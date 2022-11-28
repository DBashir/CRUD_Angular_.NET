using System.ComponentModel.DataAnnotations;

namespace Crud_API.Models
{
    public class Employee
    {
        [Key]
        public Guid guid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }

    }
}
