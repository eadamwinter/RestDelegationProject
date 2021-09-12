using Microsoft.EntityFrameworkCore;
using RestDelegations.DBContext;
using RestDelegations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Services
{
    public class DelegationRepository : IDelegationRepository
    {
        private readonly RestDelegationsContext _restDelegationsContext;

        public DelegationRepository(RestDelegationsContext restDelegationsContext)
        {
            _restDelegationsContext = restDelegationsContext;
        }
        public IEnumerable<Delegation> GetAllDelegations()
        {
            IEnumerable<Delegation> del = _restDelegationsContext.Delegations;
            return del;
        }

        public IEnumerable<Delegation> GetAllDelegations(string country)
        {
            IEnumerable<Delegation> del = null;

            if(string.IsNullOrEmpty(country))
            {
                del = GetAllDelegations();
            }
            else
            {
                country = country.Trim();
                del = _restDelegationsContext.Delegations.Where(d => d.Country == country);
            }

            
            return del;
        }

        public IEnumerable<Delegation> GetDelegationByEmployee(int employeeId)
        {

            IEnumerable<Delegation> dels = _restDelegationsContext.Delegations.Where(d => d.EmployeeId == employeeId);
            return dels;
        }

        public Delegation GetDelegationById(int delegationId)
        {
            Delegation del = _restDelegationsContext.Delegations.FirstOrDefault(d => d.DelegationId == delegationId);
            return del;
        }

        public bool DoesEmployeeExist(int employeeId)
        {
            // return _restDelegationsContext.Employees.Any(e => e.EmployeeId == employeeId);

            if(_restDelegationsContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId) == null)
            {
                return false;
            }
            return true;
        }


    }
}
