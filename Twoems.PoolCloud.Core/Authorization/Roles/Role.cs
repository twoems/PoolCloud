using Abp.Authorization.Roles;
using Twoems.PoolCloud.MultiTenancy;
using Twoems.PoolCloud.Users;

namespace Twoems.PoolCloud.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}