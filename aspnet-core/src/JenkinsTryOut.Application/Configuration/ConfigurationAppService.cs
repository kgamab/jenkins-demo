using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using JenkinsTryOut.Configuration.Dto;

namespace JenkinsTryOut.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : JenkinsTryOutAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
