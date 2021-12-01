using System.Threading.Tasks;
using Abp.Application.Services;
using JenkinsTryOut.Sessions.Dto;

namespace JenkinsTryOut.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
