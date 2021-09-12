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
        // Regular Get method but with possibility to set country argument in header with country name -- filter
        public IActionResult AllDelegations([FromHeader] string country)
        {
            IEnumerable<Delegation> delegations = _delegationRepository.GetAllDelegations(country);
            var result = _mapper.Map<IEnumerable<DelegationGetDto>>(delegations);
            return Ok(result);
        }

        [HttpGet("Delegations/{delegationId}")]
        public IActionResult SelectedDelegation(int delegationId)
        {
            Delegation del = _delegationRepository.GetDelegationById(delegationId);
            if(del==null)
            {
                return NotFound();
            }
            var result = _mapper.Map<DelegationGetDto>(del);
            return Ok(result);
        }

        [HttpGet("Delegations/{employeeId}/all")]
        // ten httphead umozliwia wysylanie tutaj requestow head ktore zwracaja tylko metadane
        [HttpHead("Delegations/{employeeId}/all")]
        public IActionResult DelegationsByEmployee(int employeeId)
        {

            if(!_delegationRepository.DoesEmployeeExist(employeeId))
            {
                return NotFound();
            }

            IEnumerable<Delegation> dels = _delegationRepository.GetDelegationByEmployee(employeeId);
            var result = _mapper.Map<IEnumerable<DelegationGetDto>>(dels);
            return Ok(result);
            
        }

    }
}
