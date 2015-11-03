using System.Threading.Tasks;
using Abp.Application.Services;
using Twoems.PoolCloud.Users.Dto;

namespace Twoems.PoolCloud.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}