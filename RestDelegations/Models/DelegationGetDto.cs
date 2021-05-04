using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Models
{
    public class DelegationGetDto
    {
        public string Country { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }
        //public string Code { get; set; }
        public DateTime TravelToStart { get; set; }
        public DateTime TravelToEnd { get; set; }
        public DateTime TravelBackStart { get; set; }
        public DateTime TravelBackEnd { get; set; }
        public int EmployeeId { get; set; }
    }
}
