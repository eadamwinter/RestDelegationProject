using RestDelegations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Services
{
    public class DelegationRepository : IDelegationRepository
    {
        public IEnumerable<Delegation> GetAllDelegetaions()
        {
            throw new NotImplementedException();
        }

        public Delegation GetDelegationById(int delegationId)
        {
            throw new NotImplementedException();
        }
    }
}
