using System.Threading.Tasks;
using OpenHr.Configuration.Dto;

namespace OpenHr.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
