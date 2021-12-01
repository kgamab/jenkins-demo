using Abp.AutoMapper;
using JenkinsTryOut.Sessions.Dto;

namespace JenkinsTryOut.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
