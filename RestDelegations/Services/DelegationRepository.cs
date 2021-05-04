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
        public IEnumerable<Delegation> GetAllDelegetaions()
        {
            IEnumerable<Delegation> del = _restDelegationsContext.Delegations;
            return del;
            //throw new NotImplementedException();
        }

        public Delegation GetDelegationById(int delegationId)
        {
            throw new NotImplementedException();
        }
    }
}
