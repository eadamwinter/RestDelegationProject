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
        public string Status { get; set; }
        
        // travel Home->Delegation
        [Required]
        public DateTime TravelToStart { get; set; }
        [Required]
        public DateTime TravelToEnd { get; set; }

        // travel Delegation->Home
        [Required]
        public DateTime TravelBackStart { get; set; }
        [Required]
        public DateTime TravelBackEnd { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }


    }
}
