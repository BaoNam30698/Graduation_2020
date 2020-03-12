using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Graduation.App.MultiTenancy.Dto;

namespace Graduation.App.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
