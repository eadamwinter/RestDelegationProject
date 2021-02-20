using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Controllers
{
    [ApiController]
    public class DelegationController : ControllerBase
    {
        [HttpGet("Delegations")]
        public IActionResult AllDelegations()
        {
            return Ok("All delegations");
        }

        [HttpGet("Delegations/{selection}")]
        public IActionResult SelectedDelegation(string selection)
        {
            return Ok("Selected Delegation");
        }

    }
}
