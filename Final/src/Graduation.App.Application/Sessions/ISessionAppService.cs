using System.Threading.Tasks;
using Abp.Application.Services;
using Graduation.App.Sessions.Dto;

namespace Graduation.App.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
