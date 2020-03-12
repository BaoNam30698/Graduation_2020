using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Graduation.App.Configuration.Dto;

namespace Graduation.App.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
