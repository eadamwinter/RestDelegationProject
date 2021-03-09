using RestDelegations.DBContext;
using RestDelegations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly RestDelegationsContext _restDelegationsContext;

        public EmployeeRepository(RestDelegationsContext restDelegationsContext)
        {
            _restDelegationsContext = restDelegationsContext;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _restDelegationsContext.Employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _restDelegationsContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }
    }
}
