using System.Threading.Tasks;
using Abp.Application.Services;
using Twoems.PoolCloud.Roles.Dto;

namespace Twoems.PoolCloud.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
