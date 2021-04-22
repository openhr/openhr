using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OpenHr.Configuration.Dto;

namespace OpenHr.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OpenHrAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
