using System.Threading.Tasks;
using Abp.Application.Services;
using JenkinsTryOut.Authorization.Accounts.Dto;

namespace JenkinsTryOut.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
