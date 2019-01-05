using System.Threading.Tasks;
using Abp.Application.Services;
using EntityModeler.Authorization.Accounts.Dto;

namespace EntityModeler.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
