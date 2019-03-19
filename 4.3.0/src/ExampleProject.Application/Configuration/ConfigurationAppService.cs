using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ExampleProject.Configuration.Dto;

namespace ExampleProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ExampleProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
