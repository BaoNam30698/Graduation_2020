using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Graduation.App.Roles.Dto;

namespace Graduation.App.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
