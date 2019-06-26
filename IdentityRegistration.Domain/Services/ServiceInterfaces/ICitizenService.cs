using IdentityRegistrationDemo.Domain.RequestModels;
using IdentityRegistrationDemo.Domain.ResponseModels;
using System.Threading.Tasks;

namespace IdentityRegistrationDemo.Domain.Services.ServiceInterfaces
{
    public interface ICitizenService : IService<CitizensRequest, CitizenResponse>
    {
        Task<CitizenResponse> CreateAsync(CitizensRequest citizensRequest);
        bool IsExist(long bvn);
        
    }
}
