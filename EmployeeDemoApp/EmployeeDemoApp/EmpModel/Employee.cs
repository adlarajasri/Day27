using System.ComponentModel.DataAnnotations;

namespace EmployeeDemoApp.EmpModel
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
    }
}
