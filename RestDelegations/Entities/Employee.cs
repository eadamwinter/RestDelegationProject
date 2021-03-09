using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestDelegations.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DateOfEmployment { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        public ICollection<Delegation> Delegations { get; set; }





    }
}
