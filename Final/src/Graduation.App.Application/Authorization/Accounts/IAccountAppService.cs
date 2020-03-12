using System.Threading.Tasks;
using Abp.Application.Services;
using Graduation.App.Authorization.Accounts.Dto;

namespace Graduation.App.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
