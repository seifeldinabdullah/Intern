using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Data.Entities
{
    public class Employees
    {
        public Guid Id { get; set; }
        
        public string? Name { get; set; }
        public int Age  { get; set; }
        public string? Mail { get; set; }   
        public string? Position { get; set; }
        public double? Salary { get; set; }


        public Guid DeptId { get; set; }

        [ForeignKey(nameof(DeptId))]
        public Department Departments { get; set; }
    }
}
