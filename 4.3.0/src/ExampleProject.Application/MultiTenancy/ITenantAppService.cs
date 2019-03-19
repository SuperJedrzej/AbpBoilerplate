using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ExampleProject.MultiTenancy.Dto;

namespace ExampleProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
