using Abp.Application.Services;
using OpenHr.MultiTenancy.Dto;

namespace OpenHr.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

