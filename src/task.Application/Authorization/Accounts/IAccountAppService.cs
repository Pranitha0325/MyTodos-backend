using System.Threading.Tasks;
using Abp.Application.Services;
using task.Authorization.Accounts.Dto;

namespace task.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
