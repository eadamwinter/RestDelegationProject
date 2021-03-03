using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Entities
{
    public class Delegation
    {
        [Key]
        public int DelegationId { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [MaxLength(50)]
        public string Company { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Code { get; set; }
        
        // travel Home->Delegation
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TravelToStart { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TravelToEnd { get; set; }

        // travel Delegation->Home
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TravelBackStart { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TravelBackEnd { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
    }
}
