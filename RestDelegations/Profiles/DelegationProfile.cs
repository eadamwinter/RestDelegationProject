using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.Profiles
{
    public class DelegationProfile : Profile
    {
        public DelegationProfile()
        {
            CreateMap<Entities.Delegation, Models.DelegationGetDto>();
        }
    }
}
