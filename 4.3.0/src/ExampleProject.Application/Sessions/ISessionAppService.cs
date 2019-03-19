using System.Threading.Tasks;
using Abp.Application.Services;
using ExampleProject.Sessions.Dto;

namespace ExampleProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
