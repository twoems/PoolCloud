using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using Twoems.PoolCloud.MultiTenancy;
using Twoems.PoolCloud.Users;

namespace Twoems.PoolCloud.Authorization.Roles
{
    public class RoleStore : AbpRoleStore<Tenant, Role, User>
    {
        public RoleStore(
            IRepository<Role> roleRepository,
            IRepository<UserRole, long> userRoleRepository,
            IRepository<RolePermissionSetting, long> rolePermissionSettingRepository,
            ICacheManager cacheManager)
            : base(
                roleRepository,
                userRoleRepository,
                rolePermissionSettingRepository,
                cacheManager)
        {
        }
    }
}