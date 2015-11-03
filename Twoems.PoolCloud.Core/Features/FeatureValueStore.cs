using Abp.Application.Features;
using Twoems.PoolCloud.Authorization.Roles;
using Twoems.PoolCloud.MultiTenancy;
using Twoems.PoolCloud.Users;

namespace Twoems.PoolCloud.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}