using System.Threading.Tasks;
using Abp.Application.Services;
using EntityModeler.Sessions.Dto;

namespace EntityModeler.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
