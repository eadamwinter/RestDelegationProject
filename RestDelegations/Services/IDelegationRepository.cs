using RestDelegations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Services
{
    public interface IDelegationRepository
    {
        IEnumerable<Delegation> GetAllDelegetaions();
        Delegation GetDelegationById(int delegationId);
        IEnumerable<Delegation> GetDelegationByEmployee(int employeeId);
        bool DoesEmployeeExist(int employeeId);
    }
}
