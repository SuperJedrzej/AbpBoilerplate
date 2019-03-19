using System.Threading.Tasks;
using Abp.Application.Services;
using ExampleProject.Configuration.Dto;

namespace ExampleProject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}