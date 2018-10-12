using System.Threading.Tasks;
using TeknoLabs.Crm.Configuration.Dto;

namespace TeknoLabs.Crm.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
