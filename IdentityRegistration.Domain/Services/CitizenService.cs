using AutoMapper;
using IdentityRegistrationDemo.Data.DbEntities;
using IdentityRegistrationDemo.Data.Repository.Interface;
using IdentityRegistrationDemo.Domain.RequestModels;
using IdentityRegistrationDemo.Domain.ResponseModels;
using IdentityRegistrationDemo.Domain.Services.ServiceInterfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityRegistrationDemo.Domain.Services
{
    public class CitizenService : ICitizenService
    {
        private readonly ICitizenRepository _citizenRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CitizenService> _logger;

        public CitizenService(ICitizenRepository citizenRepository, IMapper mapper, ILogger<CitizenService> logger)
        {
           _citizenRepository = citizenRepository;
            _mapper = mapper;
            _logger = logger;
        }

       

        public async  Task<CitizenResponse> CreateAsync(CitizensRequest citizensRequest)
        {
            var citizenToCreate = _mapper.Map<Citizen>(citizensRequest);
            var createdCitizen = await  _citizenRepository.CreateAsync(citizenToCreate);
            var createdCitizenResponse = _mapper.Map<CitizenResponse>(createdCitizen);
            return createdCitizenResponse; 
        }

        public bool IsExist (long bvn)
        {
            return _citizenRepository.IsExists(bvn);
        }

        public async Task<CitizenResponse> SelectByBvnAsync(long bvn)
        {
           var citizen = await _citizenRepository.GetByBVNAsync(bvn);
           var citizenResponse =  _mapper.Map<CitizenResponse>(citizen);
            return citizenResponse;
        }
    }
}
