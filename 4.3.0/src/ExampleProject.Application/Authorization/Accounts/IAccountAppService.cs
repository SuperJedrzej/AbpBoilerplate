using System.Threading.Tasks;
using Abp.Application.Services;
using ExampleProject.Authorization.Accounts.Dto;

namespace ExampleProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
