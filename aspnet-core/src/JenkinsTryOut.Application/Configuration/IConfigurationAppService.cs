using System.Threading.Tasks;
using JenkinsTryOut.Configuration.Dto;

namespace JenkinsTryOut.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
