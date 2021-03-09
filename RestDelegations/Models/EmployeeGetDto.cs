using System;

namespace RestDelegations.Models
{
    public class EmployeeGetDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public decimal Salary { get; set; }
    }
}
