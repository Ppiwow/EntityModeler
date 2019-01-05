using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EntityModeler.MultiTenancy.Dto;

namespace EntityModeler.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

