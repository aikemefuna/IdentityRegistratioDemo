using IdentityRegistrationDemo.Data.DbEntities;
using System.Threading.Tasks;

namespace IdentityRegistrationDemo.Data.Repository.Interface
{
    public interface ICitizenRepository
    {
        Task<Citizen> CreateAsync(Citizen obj);
        bool IsExists(long bvn);
        Task<Citizen> GetByBVNAsync(long bvn);
    }
}
