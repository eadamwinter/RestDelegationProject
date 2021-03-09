using RestDelegations.Entities;
using System.Collections.Generic;

namespace RestDelegations.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
    }
}
