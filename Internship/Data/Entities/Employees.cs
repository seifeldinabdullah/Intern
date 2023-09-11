using System.ComponentModel.DataAnnotations;

namespace Internship.Data.Entities
{
    public class Employees
    {
        public Guid Id { get; set; }
        public required Department DepId { get; set; }
        public string? Name { get; set; }
        public int Age  { get; set; }
        public string? Mail { get; set; }   
        public string? Position { get; set; }
        public double? Salary { get; set; }
    }
}
