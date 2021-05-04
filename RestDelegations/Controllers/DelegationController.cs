using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestDelegations.Entities;
using RestDelegations.Models;
using RestDelegations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Controllers
{
    [ApiController]
    public class DelegationController : ControllerBase
    {
        private readonly IDelegationRepository _delegationRepository;
        private readonly IMapper _mapper;

        public DelegationController(IDelegationRepository delegationRepository, IMapper mapper)
        {
            _delegationRepository = delegationRepository ?? throw new NotImplementedException(nameof(delegationRepository));
            _mapper = mapper ?? throw new NotImplementedException(nameof(mapper));
        }

        [HttpGet("Delegations")]
        public IActionResult AllDelegations()
        {
            IEnumerable<Delegation> delegations = _delegationRepository.GetAllDelegetaions();
            var result = _mapper.Map<IEnumerable<DelegationGetDto>>(delegations);
            return Ok(result);
        }

        [HttpGet("Delegations/{selection}")]
        public IActionResult SelectedDelegation(string selection)
        {
            return Ok("Selected Delegation");
        }

    }
}
