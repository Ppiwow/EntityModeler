using System.Threading.Tasks;
using EntityModeler.Configuration.Dto;

namespace EntityModeler.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
