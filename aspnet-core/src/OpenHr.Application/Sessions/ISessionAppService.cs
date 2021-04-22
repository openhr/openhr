using System.Threading.Tasks;
using Abp.Application.Services;
using OpenHr.Sessions.Dto;

namespace OpenHr.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
