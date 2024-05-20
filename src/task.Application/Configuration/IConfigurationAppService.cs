using System.Threading.Tasks;
using task.Configuration.Dto;

namespace task.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
