using System;

namespace RestDelegations.Models
{
    public class EmployeeExtGetDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public int WorkingTime { get; set; }
        public decimal Salary { get; set; }
        public string PeriodOfNotice { get; set; }

    }
}
