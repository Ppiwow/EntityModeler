using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EntityModeler.Configuration.Dto;

namespace EntityModeler.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EntityModelerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
