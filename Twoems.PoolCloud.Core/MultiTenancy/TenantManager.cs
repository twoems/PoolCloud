using Abp.MultiTenancy;
using Twoems.PoolCloud.Authorization.Roles;
using Twoems.PoolCloud.Editions;
using Twoems.PoolCloud.Users;

namespace Twoems.PoolCloud.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(EditionManager editionManager)
            : base(editionManager)
        {

        }
    }
}