using System.Threading.Tasks;

namespace IdentityRegistrationDemo.Domain.Services.ServiceInterfaces
{
    public interface IService <T,G>
    {
        Task<G> SelectByBvnAsync(long bvn);
    }
}
