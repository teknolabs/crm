using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TeknoLabs.Crm.Configuration.Dto;

namespace TeknoLabs.Crm.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CrmAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
