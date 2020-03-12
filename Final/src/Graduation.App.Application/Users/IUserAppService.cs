using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Graduation.App.Roles.Dto;
using Graduation.App.Users.Dto;

namespace Graduation.App.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}