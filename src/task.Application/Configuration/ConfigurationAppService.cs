using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using task.Configuration.Dto;

namespace task.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : taskAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
