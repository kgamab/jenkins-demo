using Abp.AutoMapper;
using JenkinsTryOut.Authentication.External;

namespace JenkinsTryOut.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
