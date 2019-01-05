using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EntityModeler.Roles.Dto;
using EntityModeler.Users.Dto;

namespace EntityModeler.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
