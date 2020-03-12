using System.Threading.Tasks;
using Abp.Application.Services;
using Graduation.App.Configuration.Dto;

namespace Graduation.App.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}