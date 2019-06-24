using AutoMapper;
using IdentityRegistrationDemo.Data.DbEntities;
using IdentityRegistrationDemo.Domain.RequestModels;
using IdentityRegistrationDemo.Domain.ResponseModels;

namespace IdentityRegistrationDemo.Domain.MappingProfiles
{
    public class AutoMappingProfiles : Profile
    {
        public AutoMappingProfiles()
        {
            CreateMap<CitizensRequest, Citizen>();
            CreateMap<Citizen, CitizenResponse>();
        }
    }
}
