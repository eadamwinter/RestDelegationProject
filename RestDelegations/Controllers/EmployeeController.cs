using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Controllers
{
    public class EmployeeController : ControllerBase
    {
        [HttpGet("Employees")]
        public IActionResult GetAllEmployees()
        {
            return Ok("All Employees");
        }
    }
}
