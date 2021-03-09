using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestDelegations.Entities;
using RestDelegations.Services;
using System;
using System.Collections.Generic;

namespace RestDelegations.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet("Employees")]
        public IActionResult GetAllEmployees()
        {
            IEnumerable<Employee> employees = _employeeRepository.GetAllEmployees();
            var result = _mapper.Map<IEnumerable<Models.EmployeeGetDto>>(employees);
            return Ok(result);
        }
        [HttpGet("Employees/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<Models.EmployeeGetDto>(employee);
            return Ok(result);
        }
        [HttpGet("Employees/{id}/Ext")] // Extended info
        public IActionResult GetEmployeeByIdExt(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<Models.EmployeeExtGetDto>(employee);
            return Ok(result);
        }
    }
}
