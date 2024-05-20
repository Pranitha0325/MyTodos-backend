using System.Threading.Tasks;
using Abp.Application.Services;
using task.Sessions.Dto;

namespace task.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
